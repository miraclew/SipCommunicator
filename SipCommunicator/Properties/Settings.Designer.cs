﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3053
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SipCommunicator.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SipPort {
            get {
                return ((int)(this["SipPort"]));
            }
            set {
                this["SipPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int RingMode {
            get {
                return ((int)(this["RingMode"]));
            }
            set {
                this["RingMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SipAccountPorts {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountPorts"]));
            }
            set {
                this["SipAccountPorts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SipAccountDefault {
            get {
                return ((int)(this["SipAccountDefault"]));
            }
            set {
                this["SipAccountDefault"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>*</string>
  <string>*</string>
  <string>*</string>
  <string>*</string>
  <string>*</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SipAccountDomains {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountDomains"]));
            }
            set {
                this["SipAccountDomains"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CFUFlag {
            get {
                return ((bool)(this["CFUFlag"]));
            }
            set {
                this["CFUFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CFUNumber {
            get {
                return ((string)(this["CFUNumber"]));
            }
            set {
                this["CFUNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CFNRNumber {
            get {
                return ((string)(this["CFNRNumber"]));
            }
            set {
                this["CFNRNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CFNRFlag {
            get {
                return ((bool)(this["CFNRFlag"]));
            }
            set {
                this["CFNRFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DNDFlag {
            get {
                return ((bool)(this["DNDFlag"]));
            }
            set {
                this["DNDFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CFBFlag {
            get {
                return ((bool)(this["CFBFlag"]));
            }
            set {
                this["CFBFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CFBNumber {
            get {
                return ((string)(this["CFBNumber"]));
            }
            set {
                this["CFBNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AAFlag {
            get {
                return ((bool)(this["AAFlag"]));
            }
            set {
                this["AAFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AATimeout {
            get {
                return ((bool)(this["AATimeout"]));
            }
            set {
                this["AATimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SipAccountDisplayName {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountDisplayName"]));
            }
            set {
                this["SipAccountDisplayName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SipAccountAddresses {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountAddresses"]));
            }
            set {
                this["SipAccountAddresses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SipAccountPassword {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountPassword"]));
            }
            set {
                this["SipAccountPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SipAccountIds {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountIds"]));
            }
            set {
                this["SipAccountIds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SipAccountUsername {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountUsername"]));
            }
            set {
                this["SipAccountUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SipAccountState {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountState"]));
            }
            set {
                this["SipAccountState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SipAccountNames {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountNames"]));
            }
            set {
                this["SipAccountNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>PCMU/8000/1</string>\r\n  <string>PCMA/8000/1</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection CodecList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["CodecList"]));
            }
            set {
                this["CodecList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SipAccountProxyAddresses {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountProxyAddresses"]));
            }
            set {
                this["SipAccountProxyAddresses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DtmfMode {
            get {
                return ((int)(this["DtmfMode"]));
            }
            set {
                this["DtmfMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>0</string>
  <string>0</string>
  <string>0</string>
  <string>0</string>
  <string>0</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SipAccountTransport {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountTransport"]));
            }
            set {
                this["SipAccountTransport"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SipPublishEnabled {
            get {
                return ((bool)(this["SipPublishEnabled"]));
            }
            set {
                this["SipPublishEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SipAccountIndex {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountIndex"]));
            }
            set {
                this["SipAccountIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3600")]
        public int RegistrationTimeout {
            get {
                return ((int)(this["RegistrationTimeout"]));
            }
            set {
                this["RegistrationTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool VAD {
            get {
                return ((bool)(this["VAD"]));
            }
            set {
                this["VAD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int ECTail {
            get {
                return ((int)(this["ECTail"]));
            }
            set {
                this["ECTail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string NameServer {
            get {
                return ((string)(this["NameServer"]));
            }
            set {
                this["NameServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpdgradeSettings {
            get {
                return ((bool)(this["UpdgradeSettings"]));
            }
            set {
                this["UpdgradeSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>3600</string>
  <string>3600</string>
  <string>3600</string>
  <string>3600</string>
  <string>3600</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SipAccountRegPeriod {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SipAccountRegPeriod"]));
            }
            set {
                this["SipAccountRegPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string StunServerAddress {
            get {
                return ((string)(this["StunServerAddress"]));
            }
            set {
                this["StunServerAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MonitorSipLink {
            get {
                return ((bool)(this["MonitorSipLink"]));
            }
            set {
                this["MonitorSipLink"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool StartWithWindows {
            get {
                return ((bool)(this["StartWithWindows"]));
            }
            set {
                this["StartWithWindows"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HideWhenMinimized {
            get {
                return ((bool)(this["HideWhenMinimized"]));
            }
            set {
                this["HideWhenMinimized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckForUpdates {
            get {
                return ((bool)(this["CheckForUpdates"]));
            }
            set {
                this["CheckForUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ftp://ftp.telnv.com/visualasterisk/updates")]
        public string UpdatesURL {
            get {
                return ((string)(this["UpdatesURL"]));
            }
            set {
                this["UpdatesURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayShutdownDialog {
            get {
                return ((bool)(this["DisplayShutdownDialog"]));
            }
            set {
                this["DisplayShutdownDialog"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ftp://ftp.telnv.com/visualasterisk/bugreports")]
        public string ErrorReportURL {
            get {
                return ((string)(this["ErrorReportURL"]));
            }
            set {
                this["ErrorReportURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UICulture {
            get {
                return ((string)(this["UICulture"]));
            }
            set {
                this["UICulture"] = value;
            }
        }
    }
}
