﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FemtoHTTPServer.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FemtoHTTPServer.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap BACK_PNG {
            get {
                object obj = ResourceManager.GetObject("BACK_PNG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] DIR_LIST_CSS {
            get {
                object obj = ResourceManager.GetObject("DIR_LIST_CSS", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap DIRECTORY_PNG {
            get {
                object obj = ResourceManager.GetObject("DIRECTORY_PNG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width&quot; /&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///    &lt;title&gt;Directory &amp;middot; {0}&lt;/title&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;/.femto/system.css&quot; /&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text.css&quot; href=&quot;/.femto/dir-list.css&quot; /&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;/.femto/sfui.css&quot; /&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;/.femto/scp.css&quot; /&gt;
        ///    &lt;link rel=&quot;icon&quot; type=&quot;image/x-icon&quot; href=&quot;/.femto/fem [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string DIRLIST_TEMPLATE {
            get {
                return ResourceManager.GetString("DIRLIST_TEMPLATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Another instance of FemtoHTTPServer is already running. 的本地化字符串。
        /// </summary>
        internal static string ERR_DUPLICATE_INSTANCE {
            get {
                return ResourceManager.GetString("ERR_DUPLICATE_INSTANCE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0}: {1}
        ///{2} 的本地化字符串。
        /// </summary>
        internal static string ERR_EXCEPTION_FORMAT {
            get {
                return ResourceManager.GetString("ERR_EXCEPTION_FORMAT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The file you have requested cannot be found. 的本地化字符串。
        /// </summary>
        internal static string ERR_FILE_NOT_FOUND {
            get {
                return ResourceManager.GetString("ERR_FILE_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 At least one listening port required. 的本地化字符串。
        /// </summary>
        internal static string ERR_NO_PORT_DEFINED {
            get {
                return ResourceManager.GetString("ERR_NO_PORT_DEFINED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Web Root path invalid. 的本地化字符串。
        /// </summary>
        internal static string ERR_PATH_INVALID {
            get {
                return ResourceManager.GetString("ERR_PATH_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Port designator have to follow this format: http://*:1234/ 的本地化字符串。
        /// </summary>
        internal static string ERR_PORT_SYNTAX {
            get {
                return ResourceManager.GetString("ERR_PORT_SYNTAX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 You are not allowed to load this file. 的本地化字符串。
        /// </summary>
        internal static string ERR_UNAUTHORIZED {
            get {
                return ResourceManager.GetString("ERR_UNAUTHORIZED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 FemtoHTTPServer not supported on this platform. 的本地化字符串。
        /// </summary>
        internal static string ERR_UNSUPPORTED {
            get {
                return ResourceManager.GetString("ERR_UNSUPPORTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width&quot; /&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///    &lt;title&gt;Error 500 &amp;middot; Internal server error&lt;/title&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;/.femto/system.css&quot; /&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;/.femto/sfui.css&quot; /&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;/.femto/scp.css&quot; /&gt;
        ///    &lt;link rel=&quot;icon&quot; type=&quot;image/x-icon&quot; href=&quot;/.femto/femto.ico&quot; /&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;header id=&quot;page-header&quot; [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string EXCEPTION_TEMPLATE {
            get {
                return ResourceManager.GetString("EXCEPTION_TEMPLATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] FEMTO_HTML {
            get {
                object obj = ResourceManager.GetObject("FEMTO_HTML", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width&quot; /&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///    &lt;title&gt;Error {1} &amp;middot; {2}&lt;/title&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;/.femto/system.css&quot; /&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;/.femto/sfui.css&quot; /&gt;
        ///    &lt;link rel=&quot;stylesheet&quot; type=&quot;text/css&quot; href=&quot;/.femto/scp.css&quot; /&gt;
        ///    &lt;link rel=&quot;icon&quot; type=&quot;image/x-icon&quot; href=&quot;/.femto/femto.ico&quot; /&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;header id=&quot;page-header&quot;&gt;
        ///        &lt;h1&gt;Err [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string FILE_NOT_FOUND_TEMPLATE {
            get {
                return ResourceManager.GetString("FILE_NOT_FOUND_TEMPLATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap FILE_PNG {
            get {
                object obj = ResourceManager.GetObject("FILE_PNG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] JQUERY_JS {
            get {
                object obj = ResourceManager.GetObject("JQUERY_JS", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_CSS {
            get {
                object obj = ResourceManager.GetObject("SCP_CSS", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_L_EOT {
            get {
                object obj = ResourceManager.GetObject("SCP_L_EOT", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_L_SVG {
            get {
                object obj = ResourceManager.GetObject("SCP_L_SVG", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_L_TTF {
            get {
                object obj = ResourceManager.GetObject("SCP_L_TTF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_L_WOFF {
            get {
                object obj = ResourceManager.GetObject("SCP_L_WOFF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_L_WOFF2 {
            get {
                object obj = ResourceManager.GetObject("SCP_L_WOFF2", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_M_EOT {
            get {
                object obj = ResourceManager.GetObject("SCP_M_EOT", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_M_SVG {
            get {
                object obj = ResourceManager.GetObject("SCP_M_SVG", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_M_TTF {
            get {
                object obj = ResourceManager.GetObject("SCP_M_TTF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_M_WOFF {
            get {
                object obj = ResourceManager.GetObject("SCP_M_WOFF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SCP_M_WOFF2 {
            get {
                object obj = ResourceManager.GetObject("SCP_M_WOFF2", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_CSS {
            get {
                object obj = ResourceManager.GetObject("SFUI_CSS", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_L_EOT {
            get {
                object obj = ResourceManager.GetObject("SFUI_L_EOT", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_L_SVG {
            get {
                object obj = ResourceManager.GetObject("SFUI_L_SVG", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_L_TTF {
            get {
                object obj = ResourceManager.GetObject("SFUI_L_TTF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_L_WOFF {
            get {
                object obj = ResourceManager.GetObject("SFUI_L_WOFF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_L_WOFF2 {
            get {
                object obj = ResourceManager.GetObject("SFUI_L_WOFF2", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_LI_EOT {
            get {
                object obj = ResourceManager.GetObject("SFUI_LI_EOT", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_LI_SVG {
            get {
                object obj = ResourceManager.GetObject("SFUI_LI_SVG", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_LI_TTF {
            get {
                object obj = ResourceManager.GetObject("SFUI_LI_TTF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_LI_WOFF {
            get {
                object obj = ResourceManager.GetObject("SFUI_LI_WOFF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_LI_WOFF2 {
            get {
                object obj = ResourceManager.GetObject("SFUI_LI_WOFF2", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_M_EOT {
            get {
                object obj = ResourceManager.GetObject("SFUI_M_EOT", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_M_SVG {
            get {
                object obj = ResourceManager.GetObject("SFUI_M_SVG", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_M_TTF {
            get {
                object obj = ResourceManager.GetObject("SFUI_M_TTF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_M_WOFF {
            get {
                object obj = ResourceManager.GetObject("SFUI_M_WOFF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_M_WOFF2 {
            get {
                object obj = ResourceManager.GetObject("SFUI_M_WOFF2", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_MI_EOT {
            get {
                object obj = ResourceManager.GetObject("SFUI_MI_EOT", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_MI_SVG {
            get {
                object obj = ResourceManager.GetObject("SFUI_MI_SVG", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_MI_TTF {
            get {
                object obj = ResourceManager.GetObject("SFUI_MI_TTF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_MI_WOFF {
            get {
                object obj = ResourceManager.GetObject("SFUI_MI_WOFF", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SFUI_MI_WOFF2 {
            get {
                object obj = ResourceManager.GetObject("SFUI_MI_WOFF2", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] SYSTEM_CSS {
            get {
                object obj = ResourceManager.GetObject("SYSTEM_CSS", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap UI_ADD {
            get {
                object obj = ResourceManager.GetObject("UI_ADD", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap UI_CLOSE {
            get {
                object obj = ResourceManager.GetObject("UI_CLOSE", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 Error 的本地化字符串。
        /// </summary>
        internal static string UI_ERROR_TITLE {
            get {
                return ResourceManager.GetString("UI_ERROR_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap UI_OPEN_SETTINGS_IMG {
            get {
                object obj = ResourceManager.GetObject("UI_OPEN_SETTINGS_IMG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap UI_REMOVE {
            get {
                object obj = ResourceManager.GetObject("UI_REMOVE", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap UI_RESET {
            get {
                object obj = ResourceManager.GetObject("UI_RESET", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap UI_SERVER_START_IMG {
            get {
                object obj = ResourceManager.GetObject("UI_SERVER_START_IMG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap UI_SERVER_STOP_IMG {
            get {
                object obj = ResourceManager.GetObject("UI_SERVER_STOP_IMG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 FemtoHTTPServer 的本地化字符串。
        /// </summary>
        internal static string UI_TRAY_ICON_TITLE {
            get {
                return ResourceManager.GetString("UI_TRAY_ICON_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 FemtoHTTPServer: Running 的本地化字符串。
        /// </summary>
        internal static string UI_TRAY_ICON_TITLE_RUNNING {
            get {
                return ResourceManager.GetString("UI_TRAY_ICON_TITLE_RUNNING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 FemtoHTTPServer: Stopped 的本地化字符串。
        /// </summary>
        internal static string UI_TRAY_ICON_TITLE_STOPPED {
            get {
                return ResourceManager.GetString("UI_TRAY_ICON_TITLE_STOPPED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &amp;Settings... 的本地化字符串。
        /// </summary>
        internal static string UI_TRAY_MENU_OPEN_SETTINGS {
            get {
                return ResourceManager.GetString("UI_TRAY_MENU_OPEN_SETTINGS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 E&amp;xit 的本地化字符串。
        /// </summary>
        internal static string UI_TRAY_MENU_QUIT {
            get {
                return ResourceManager.GetString("UI_TRAY_MENU_QUIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 S&amp;tart Server 的本地化字符串。
        /// </summary>
        internal static string UI_TRAY_MENU_START_SERVER {
            get {
                return ResourceManager.GetString("UI_TRAY_MENU_START_SERVER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Sto&amp;p Server 的本地化字符串。
        /// </summary>
        internal static string UI_TRAY_MENU_STOP_SERVER {
            get {
                return ResourceManager.GetString("UI_TRAY_MENU_STOP_SERVER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似于 (Icon) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon UI_WEB_SERVER_ICON {
            get {
                object obj = ResourceManager.GetObject("UI_WEB_SERVER_ICON", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (Icon) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon UI_WEB_SERVER_RUNNING_ICON {
            get {
                object obj = ResourceManager.GetObject("UI_WEB_SERVER_RUNNING_ICON", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (Icon) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon UI_WEB_SERVER_STOPPED_ICON {
            get {
                object obj = ResourceManager.GetObject("UI_WEB_SERVER_STOPPED_ICON", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
