﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsAppTest.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("d:")]
        public string SaveLogFilePlace {
            get {
                return ((string)(this["SaveLogFilePlace"]));
            }
            set {
                this["SaveLogFilePlace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00000000-0000-0000-0000-000000000000")]
        public global::System.Guid KlantKeuze {
            get {
                return ((global::System.Guid)(this["KlantKeuze"]));
            }
            set {
                this["KlantKeuze"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15000")]
        public string Tijd {
            get {
                return ((string)(this["Tijd"]));
            }
            set {
                this["Tijd"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("uit")]
        public string TestAanOfUit {
            get {
                return ((string)(this["TestAanOfUit"]));
            }
            set {
                this["TestAanOfUit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://wsdev.kraan.com/")]
        public string Http {
            get {
                return ((string)(this["Http"]));
            }
            set {
                this["Http"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/@/")]
        public string Email {
            get {
                return ((string)(this["Email"]));
            }
            set {
                this["Email"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("900000")]
        public string TijdService {
            get {
                return ((string)(this["TijdService"]));
            }
            set {
                this["TijdService"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("uit")]
        public string ServiceAanOfUit {
            get {
                return ((string)(this["ServiceAanOfUit"]));
            }
            set {
                this["ServiceAanOfUit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("///")]
        public string SaveDbPlace {
            get {
                return ((string)(this["SaveDbPlace"]));
            }
            set {
                this["SaveDbPlace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("///")]
        public string ServerNaam {
            get {
                return ((string)(this["ServerNaam"]));
            }
            set {
                this["ServerNaam"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("///")]
        public string PlaceDb {
            get {
                return ((string)(this["PlaceDb"]));
            }
            set {
                this["PlaceDb"] = value;
            }
        }
    }
}
