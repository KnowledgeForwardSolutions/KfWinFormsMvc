﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KfWinFormsMvc {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KfWinFormsMvc.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to MethodName may not be null, String.Empty or all whitespace characters.
        /// </summary>
        internal static string EmptyMethodNameMessage {
            get {
                return ResourceManager.GetString("EmptyMethodNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PropertyName may not be null, String.Empty or all whitespace characters.
        /// </summary>
        internal static string EmptyPropertyNameMessage {
            get {
                return ResourceManager.GetString("EmptyPropertyNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bound method return type must be either void or Task.
        /// </summary>
        internal static string InvalidBoundMethodReturnType {
            get {
                return ResourceManager.GetString("InvalidBoundMethodReturnType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &quot;{0}&quot; was not found.
        /// </summary>
        internal static string MethodNotFoundMessage {
            get {
                return ResourceManager.GetString("MethodNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Control may not be null.
        /// </summary>
        internal static string NullControlMessage {
            get {
                return ResourceManager.GetString("NullControlMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Model may not be null.
        /// </summary>
        internal static string NullModelMessage {
            get {
                return ResourceManager.GetString("NullModelMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &quot;{0}&quot; was not found.
        /// </summary>
        internal static string PropertyNotFoundMessage {
            get {
                return ResourceManager.GetString("PropertyNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RadioButtonViewController selected value parameter may not be default.
        /// </summary>
        internal static string SelectedValueOutOfRangeMessage {
            get {
                return ResourceManager.GetString("SelectedValueOutOfRangeMessage", resourceCulture);
            }
        }
    }
}
