using System;
using System.Text;
using System.Net;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace FemtoHTTPServer
{
    partial class HttpApplication
    {
        private void HandleFemptoPage(HttpListenerContext ctx)
        {
            string resourceKey = Path.GetFileName(ctx.Request.Url.LocalPath);
            string extension = Path.GetExtension(resourceKey);
            string mime = MimeTypes.MimeTypeMap.GetMimeType(extension);

            switch (resourceKey)
            {
                case "femto.ico":
                    Favicon(ctx);
                    break;

                default:
                    Regex regex = new Regex("[^A-Z]");
                    resourceKey = regex.Replace(resourceKey.ToUpper(), "_");

                    object obj = Properties.Resources.ResourceManager.GetObject(resourceKey);
                    if (obj == null)
                    {
                        FileNotFound(ctx);
                    }
                    else if ((obj is byte[]) || (obj is string))
                    {
                        byte[] buf = (obj is string) ? Encoding.UTF8.GetBytes((string)obj) : (byte[])obj;

                        ctx.Response.ContentType = mime;
                        ctx.Response.ContentLength64 = buf.Length;
                        if (obj is string)
                            ctx.Response.ContentEncoding = Encoding.UTF8;
                        ctx.Response.OutputStream.Write(buf, 0, buf.Length);
                    }
                    else if (obj is Bitmap)
                    {
                        Bitmap img = (Bitmap)obj;

                        ctx.Response.ContentType = mime;
                        img.Save(ctx.Response.OutputStream, ImageFormat.Png);
                    }
                    else
                    {
                        FileNotFound(ctx);
                    }
                    break;
            }
        }

        private void Favicon(HttpListenerContext ctx)
        {
            ctx.Response.ContentType = MimeTypes.MimeTypeMap.GetMimeType(".ico");
            Properties.Resources.UI_WEB_SERVER_ICON.Save(ctx.Response.OutputStream);
        }

        private void FileNotFound(HttpListenerContext ctx)
        {
            Error(ctx, 404, Properties.Resources.ERR_FILE_NOT_FOUND);
        }

        private void Error(HttpListenerContext ctx, int errorCode, string message)
        {
            ctx.Response.StatusCode = errorCode;
            ctx.Response.ContentType = "text/html";
            ctx.Response.ContentEncoding = Encoding.UTF8;

            string file = string.Format(Properties.Resources.FILE_NOT_FOUND_TEMPLATE, WebUtility.HtmlEncode(ctx.Request.Url.AbsolutePath), errorCode.ToString(), ctx.Response.StatusDescription, WebUtility.HtmlEncode(message));

            byte[] buf = Encoding.UTF8.GetBytes(file);
            ctx.Response.OutputStream.Write(buf, 0, buf.Length);
        }

        private void Exception(HttpListenerContext ctx, Exception ex)
        {
            ctx.Response.StatusCode = 500;
            ctx.Response.ContentType = "text/html";
            ctx.Response.ContentEncoding = Encoding.UTF8;

            string file = string.Format(Properties.Resources.EXCEPTION_TEMPLATE, WebUtility.HtmlEncode(ex.GetType().Name), WebUtility.HtmlEncode(ex.Message), WebUtility.HtmlEncode(ex.StackTrace));

            byte[] buf = Encoding.UTF8.GetBytes(file);
            ctx.Response.OutputStream.Write(buf, 0, buf.Length);
        }
    }
}