using System;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace FemtoHTTPServer
{
    /// <summary>
    /// HttpApplication class implements a windowless Windows Froms application
    /// that implements a simple static & CGI HTTP Web server using built-in
    /// HTTPListener class.
    /// </summary>
    partial class HttpApplication : ApplicationContext
    {
        #region " Application Lifecycle "
        static Mutex mutex = new Mutex(true, "info.maxchan.cs.femtohttpd");

        private NotifyIcon icon;
        private ToolStripMenuItem openSettings;
        private ToolStripMenuItem startServer;
        private ToolStripMenuItem stopServer;

        private void InitializeComponents()
        {
            icon = new NotifyIcon();
            icon.Text = Properties.Resources.UI_TRAY_ICON_TITLE;
            icon.Icon = Properties.Resources.UI_WEB_SERVER_STOPPED_ICON;
            icon.Visible = true;
            icon.ContextMenuStrip = new ContextMenuStrip();

            openSettings = new ToolStripMenuItem(Properties.Resources.UI_TRAY_MENU_OPEN_SETTINGS, Properties.Resources.UI_OPEN_SETTINGS_IMG);
            openSettings.Click += new EventHandler(OpenSettings);
            icon.ContextMenuStrip.Items.Add(openSettings);
    
            icon.ContextMenuStrip.Items.Add(new ToolStripSeparator());

            startServer = new ToolStripMenuItem(Properties.Resources.UI_TRAY_MENU_START_SERVER, Properties.Resources.UI_SERVER_START_IMG);
            startServer.Click += new EventHandler(StartServer);
            icon.ContextMenuStrip.Items.Add(startServer);

            stopServer = new ToolStripMenuItem(Properties.Resources.UI_TRAY_MENU_STOP_SERVER, Properties.Resources.UI_SERVER_STOP_IMG);
            stopServer.Enabled = false;
            stopServer.Click += new EventHandler(StopServer);
            icon.ContextMenuStrip.Items.Add(stopServer);

            icon.ContextMenuStrip.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem exit = new ToolStripMenuItem(Properties.Resources.UI_TRAY_MENU_QUIT);
            exit.Click += new EventHandler(ExitApplication);
            exit.Image = Properties.Resources.UI_CLOSE;
            icon.ContextMenuStrip.Items.Add(exit);

            icon.DoubleClick += new EventHandler(OpenSettings);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                openSettings.Dispose();
                startServer.Dispose();
                stopServer.Dispose();
                server.Close();
                icon.Dispose();
            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!HttpListener.IsSupported)
            {
                MessageBox.Show(Properties.Resources.ERR_UNSUPPORTED, Properties.Resources.UI_ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.Run(new HttpApplication());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show(Properties.Resources.ERR_DUPLICATE_INSTANCE, Properties.Resources.UI_ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ServerSettings serverSettings;

        private void OpenSettings(object sender, EventArgs e)
        {
            if (server.IsListening)
                return;

            startServer.Enabled = false;

            serverSettings = new ServerSettings();
            serverSettings.Show(result => {
                startServer.Enabled = true;
            });
        }

        private void StartServer(object sender, EventArgs e)
        {
            if (server.IsListening)
                return;

            startServer.Enabled = false;
            openSettings.Enabled = false;

            try
            {
                Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format(Properties.Resources.ERR_EXCEPTION_FORMAT, ex.GetType().Name, ex.Message, ex.StackTrace), Properties.Resources.UI_ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                syncInterface();
            }
        }

        private void StopServer(object sender, EventArgs e)
        {
            if (!server.IsListening)
                return;

            stopServer.Enabled = false;

            try
            {
                Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format(Properties.Resources.ERR_EXCEPTION_FORMAT, ex.GetType().Name, ex.Message, ex.StackTrace), Properties.Resources.UI_ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                syncInterface();
            }
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            try
            {
                if (server.IsListening)
                    Stop();
            }
            finally
            {
                Dispose(true);
                Application.Exit();
            }
        }

        private void syncInterface()
        {
            bool started = server.IsListening;

            startServer.Enabled = !started;
            openSettings.Enabled = !started;
            stopServer.Enabled = started;
            icon.Icon = started ? Properties.Resources.UI_WEB_SERVER_RUNNING_ICON : Properties.Resources.UI_WEB_SERVER_STOPPED_ICON;
        }
        #endregion

        private HttpListener server;

        protected HttpApplication()
        {
            server = new HttpListener();
            InitializeComponents();
        }

        /// <summary>
        /// Starts the HTTP server asynchronously.
        /// </summary>
        private void Start()
        {
            server.Prefixes.Clear();
            foreach (var item in Properties.Settings.Default.Prefixes)
            {
                server.Prefixes.Add(item);
            }

            server.Start();
            server.BeginGetContext(new AsyncCallback(HandleRequest), null);
        }

        /// <summary>
        /// Stop the HTTP server.
        /// </summary>
        private void Stop()
        {
            server.Stop();
        }

        /// <summary>
        /// Handles incoming requests asynchronously.
        /// </summary>
        /// <param name="ar">Information regarding the incoming connection.</param>
        private void HandleRequest(IAsyncResult ar)
        {
            try
            {
                HttpListenerContext ctx = server.EndGetContext(ar);
                server.BeginGetContext(new AsyncCallback(HandleRequest), null);
                ThreadPool.QueueUserWorkItem(new WaitCallback(HandleContext), ctx);
            }
            catch (Exception)
            {
                ;
            }
        }

        /// <summary>
        /// Running in another thread, actually parsing the outputs.
        /// </summary>
        /// <param name="state"></param>
        private void HandleContext(object state)
        {
            HttpListenerContext ctx = (HttpListenerContext)state;
            string documentRoot = Environment.ExpandEnvironmentVariables(Properties.Settings.Default.WebRoot);

            try
            {
                if (ctx.Request.Url.AbsolutePath.StartsWith("/.femto/"))
                {
                    HandleFemptoPage(ctx);
                }
                else
                {
                    string localPath = Path.Combine(Environment.ExpandEnvironmentVariables(Properties.Settings.Default.WebRoot), ctx.Request.Url.LocalPath.TrimStart('/'));
                    FileInfo file = new FileInfo(localPath);
                    string[] pathext = Environment.GetEnvironmentVariable("PATHEXT").ToUpper().Split(';');
                    
                    if (Directory.Exists(localPath))
                    {
                        bool activated = false;
                        DirectoryInfo directory = new DirectoryInfo(localPath);
                        foreach (var f in directory.EnumerateFiles())
                        {
                            if (Path.GetFileNameWithoutExtension(f.Name).ToUpper() == "INDEX")
                            {
                                if (pathext.Contains(f.Extension.ToUpper()))
                                {
                                    CGIPage(ctx, f.FullName);
                                }
                                else
                                {
                                    StaticPage(ctx, f.FullName);
                                }
                                activated = true;
                                break;
                            }
                        }
                        
                        if (!activated)
                            DirectoryListing(ctx, localPath);
                    }
                    else if (!file.Exists)
                    {
                        if (file.Name == "favicon.ico")
                            Favicon(ctx);
                        else
                            FileNotFound(ctx);
                    }
                    else if (pathext.Contains(file.Extension.ToUpper()))
                    {
                        CGIPage(ctx, localPath);
                    }
                    else
                    {
                        StaticPage(ctx, localPath);
                    }
                }
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
                ctx.Response.OutputStream.Close();
            }
        }
    }
}
