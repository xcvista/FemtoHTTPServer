using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Text;
using System.Linq;

namespace FemtoHTTPServer
{
    partial class HttpApplication
    {
        private void StaticPage(HttpListenerContext ctx, string localPath)
        {
            try
            {
                FileInfo file = new FileInfo(localPath);
                Stream fileStream = file.OpenRead();

                ctx.Response.ContentType = MimeTypes.MimeTypeMap.GetMimeType(file.Extension);
                ctx.Response.ContentLength64 = file.Length;
                fileStream.CopyTo(ctx.Response.OutputStream);
                fileStream.Close();
            }
            catch (UnauthorizedAccessException)
            {
                Error(ctx, 403, Properties.Resources.ERR_UNAUTHORIZED);
            }
            catch (DirectoryNotFoundException)
            {
                FileNotFound(ctx);
            }
            catch (Exception ex)
            {
                Exception(ctx, ex);
            }
        }

        private void CGIPage(HttpListenerContext ctx, string localPath)
        {
            Process subprocess = new Process();

            try
            {
                subprocess.StartInfo.FileName = localPath;
                subprocess.StartInfo.CreateNoWindow = true;
                subprocess.StartInfo.ErrorDialog = false;
                subprocess.StartInfo.UseShellExecute = false;
                subprocess.StartInfo.RedirectStandardInput = true;
                subprocess.StartInfo.RedirectStandardOutput = true;
                subprocess.StartInfo.RedirectStandardError = true;
                subprocess.StartInfo.WorkingDirectory = Path.GetDirectoryName(localPath);

                var envp = subprocess.StartInfo.EnvironmentVariables;
                envp.Clear();
                envp["DOCUMENT_ROOT"] = Environment.ExpandEnvironmentVariables(Properties.Settings.Default.WebRoot);
                envp["GATEWAY_INTERFACE"] = "CGI/1.1";
                envp["QUERY_STRING"] = ctx.Request.Url.Query;
                envp["REMOTE_ADDR"] = ctx.Request.RemoteEndPoint.Address.ToString();
                envp["REMOTE_HOST"] = ctx.Request.RemoteEndPoint.Address.ToString();
                envp["REMOTE_PORT"] = ctx.Request.RemoteEndPoint.Port.ToString();
                envp["REQUEST_METHOD"] = ctx.Request.HttpMethod;
                envp["REQUEST_SCHEME"] = ctx.Request.Url.Scheme;
                envp["REQUEST_URI"] = ctx.Request.RawUrl;
                envp["SCRIPT_FILENAME"] = localPath;
                envp["SCRIPT_NAME"] = ctx.Request.Url.AbsolutePath;
                envp["SERVER_NAME"] = Environment.MachineName;
                envp["SERVER_ADDR"] = ctx.Request.LocalEndPoint.Address.ToString();
                envp["SERVER_PORT"] = ctx.Request.LocalEndPoint.Port.ToString();
                envp["SERVER_SOFTWARE"] = "FemtoHTTPServer/1.0";
                envp["PWD"] = Path.GetDirectoryName(localPath);

                foreach (string envars in new string[] { "PATH", "PATHEXT" })
                {
                    envp[envars] = Environment.GetEnvironmentVariable(envars);
                }

                foreach (string header in ctx.Request.Headers)
                {
                    string envar = String.Format("HTTP_{0}", header.Replace('-', '_').ToUpper());
                    envp[envar] = ctx.Request.Headers[header];
                }

                subprocess.ErrorDataReceived += (sender, e) => {
                    if (e.Data == null)
                    {
                        return;
                    }

                    Console.Error.WriteLine(e.Data);
                };

                subprocess.Start();
                subprocess.BeginErrorReadLine();
                ctx.Request.InputStream.CopyTo(subprocess.StandardInput.BaseStream);

                while (true)
                {
                    string line = subprocess.StandardOutput.ReadLine();

                    if (line.Trim().Length == 0)
                    {
                        break;
                    }

                    var location = line.IndexOf(':');
                    if (location < 0)
                        throw new InvalidDataException();

                    string key = line.Substring(0, location).Trim();
                    string value = line.Substring(location).Trim();

                    if (key == "Status")
                    {
                        var namestart = value.IndexOf(' ');
                        if (namestart < 0)
                        {
                            ctx.Response.StatusCode = Convert.ToInt32(value);
                        }
                        else
                        {
                            ctx.Response.StatusCode = Convert.ToInt32(value.Substring(0, namestart));
                            ctx.Response.StatusDescription = value.Substring(namestart).Trim();
                        }
                    }
                    else
                    {
                        ctx.Response.Headers.Add(key, value);
                    }
                }
                subprocess.StandardOutput.BaseStream.CopyTo(ctx.Response.OutputStream);

                subprocess.WaitForExit();
            }
            catch (UnauthorizedAccessException)
            {
                Error(ctx, 403, Properties.Resources.ERR_UNAUTHORIZED);
            }
            catch (DirectoryNotFoundException)
            {
                FileNotFound(ctx);
            }
            catch (Exception ex)
            {
                Exception(ctx, ex);
            }
            finally
            {
                subprocess.Close();
            }
        }

        private void DirectoryListing(HttpListenerContext ctx, string localPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(localPath);

                string remotePath = ctx.Request.Url.AbsolutePath;

                string[] remotePathComponents = remotePath.Split('/');
                StringBuilder remotePathAnnotated = new StringBuilder();
                for (int idx = 0; idx < remotePathComponents.Length; idx++)
                {
                    string link = string.Join("/", remotePathComponents.Take(idx + 1));
                    if (remotePathComponents[idx].Length > 0 || idx == 0)
                        remotePathAnnotated.AppendFormat("<a href=\"{0}\">{1}{2}</a>", (link.Length > 0) ? link : "/", WebUtility.HtmlEncode(remotePathComponents[idx]), (idx != 0 && idx >= remotePathComponents.Length - 1) ? "" : "/");
                }

                StringBuilder listing = new StringBuilder();
                if (remotePath != "/")
                    listing.Append("<tr><td><i class=\"back\"></i><a href=\"..\">../</a></td><td>-</td><td>-</td></tr>\n");

                foreach (var item in dir.EnumerateFileSystemInfos())
                {
                    bool isDirectory = (item.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
                    listing.AppendFormat("<tr><td><i class=\"{0}\"></i><a href=\"{1}{3}\">{2}{3}</a></td><td>{4}</td><td>{5}</td></tr>\n",
                        isDirectory ? "directory" : "file", item.Name, WebUtility.HtmlEncode(item.Name), isDirectory ? "/" : "",
                        item.LastWriteTime, isDirectory ? "-" : ((FileInfo)item).Length.ToDiskSize());
                }

                string page = string.Format(Properties.Resources.DIRLIST_TEMPLATE, WebUtility.HtmlEncode(remotePath), remotePathAnnotated, listing);

                ctx.Response.ContentType = "text/html";
                ctx.Response.ContentEncoding = Encoding.UTF8;
                byte[] buf = Encoding.UTF8.GetBytes(page);
                ctx.Response.OutputStream.Write(buf, 0, buf.Length);
            }
            catch (UnauthorizedAccessException)
            {
                Error(ctx, 403, Properties.Resources.ERR_UNAUTHORIZED);
            }
            catch (DirectoryNotFoundException)
            {
                FileNotFound(ctx);
            }
            catch (Exception ex)
            {
                Exception(ctx, ex);
            }
        }

    }

    internal static class DiskSize
    {
        public static string ToDiskSize(this long value)
        {
            string[] units = { "B", "kB", "MB", "GB", "TB", "PB", "EB" };
            int idx = 0;
            double val = value;
            while (val > 1000)
            {
                val /= 1000;
                idx++;
            }

            return string.Format("{0:#.##}{1}", val, units[idx]);
        }
    }
}
