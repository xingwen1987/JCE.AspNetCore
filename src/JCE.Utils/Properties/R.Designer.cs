﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JCE.Utils.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class R {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal R() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JCE.Utils.Properties.R", typeof(R).Assembly);
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
        ///   查找类似 参数“{0}”的值必须在“{1}”与“{2}”之间。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_Between {
            get {
                return ResourceManager.GetString("ParameterCheck_Between", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须在“{1}”与“{2}”之间，且不能等于“{3}”。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_BetweenNotEqual {
            get {
                return ResourceManager.GetString("ParameterCheck_BetweenNotEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 指定的目录路径“{0}”不存在。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_DirectoryNotExists {
            get {
                return ResourceManager.GetString("ParameterCheck_DirectoryNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 指定的文件路径“{0}”不存在。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_FileNotExists {
            get {
                return ResourceManager.GetString("ParameterCheck_FileNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值不能为Guid.Empty 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotEmpty_Guid {
            get {
                return ResourceManager.GetString("ParameterCheck_NotEmpty_Guid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须大于“{1}”。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotGreaterThan {
            get {
                return ResourceManager.GetString("ParameterCheck_NotGreaterThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须大于或等于“{1}”。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotGreaterThanOrEqual {
            get {
                return ResourceManager.GetString("ParameterCheck_NotGreaterThanOrEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须小于“{1}”。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotLessThan {
            get {
                return ResourceManager.GetString("ParameterCheck_NotLessThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”的值必须小于或等于“{1}”。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotLessThanOrEqual {
            get {
                return ResourceManager.GetString("ParameterCheck_NotLessThanOrEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”不能为空引用。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotNull {
            get {
                return ResourceManager.GetString("ParameterCheck_NotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”不能为空引用或空集合。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotNullOrEmpty_Collection {
            get {
                return ResourceManager.GetString("ParameterCheck_NotNullOrEmpty_Collection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数“{0}”不能为空引用或空字符串。 的本地化字符串。
        /// </summary>
        internal static string ParameterCheck_NotNullOrEmpty_String {
            get {
                return ResourceManager.GetString("ParameterCheck_NotNullOrEmpty_String", resourceCulture);
            }
        }
    }
}
