﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.5446
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Com.GainWinSoft.Common.Resources {
    using System;
    
    
    /// <summary>
    ///   强类型资源类，用于查找本地化字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Message {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Message() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Com.GainWinSoft.Common.Resources.Message", typeof(Message).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   为使用此强类型资源类的所有资源查找
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
        ///   查找类似 加载初始数据…… 的本地化字符串。
        /// </summary>
        internal static string I0001 {
            get {
                return ResourceManager.GetString("I0001", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 加载菜单项…… 的本地化字符串。
        /// </summary>
        internal static string I0002 {
            get {
                return ResourceManager.GetString("I0002", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 加载主画面…… 的本地化字符串。
        /// </summary>
        internal static string I0003 {
            get {
                return ResourceManager.GetString("I0003", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 %1 不能为空，请输入。 的本地化字符串。
        /// </summary>
        internal static string W0001 {
            get {
                return ResourceManager.GetString("W0001", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 %1 的格式不正确 %2。 的本地化字符串。
        /// </summary>
        internal static string W0002 {
            get {
                return ResourceManager.GetString("W0002", resourceCulture);
            }
        }
    }
}
