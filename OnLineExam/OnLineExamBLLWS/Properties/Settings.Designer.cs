﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3603
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnLineExamBLLWS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:2535/DALWS_User.asmx")]
        public string OnLineExamBLLWS_DALWS_User_DALWS_User {
            get {
                return ((string)(this["OnLineExamBLLWS_DALWS_User_DALWS_User"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:2535/DALWS_SingleSelected.asmx")]
        public string OnLineExamBLLWS_DALWS_SingleSelected_DALWS_SingleSelected {
            get {
                return ((string)(this["OnLineExamBLLWS_DALWS_SingleSelected_DALWS_SingleSelected"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:2535/DALWS_Role.asmx")]
        public string OnLineExamBLLWS_DALWS_Role_DALWS_Role {
            get {
                return ((string)(this["OnLineExamBLLWS_DALWS_Role_DALWS_Role"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:2535/DALWS_QuestionProblem.asmx")]
        public string OnLineExamBLLWS_DALWS_QuestionProblem_DALWS_QuestionProblem {
            get {
                return ((string)(this["OnLineExamBLLWS_DALWS_QuestionProblem_DALWS_QuestionProblem"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:2535/DALWS_Paper.asmx")]
        public string OnLineExamBLLWS_DALWS_Paper_DALWS_Paper {
            get {
                return ((string)(this["OnLineExamBLLWS_DALWS_Paper_DALWS_Paper"]));
            }
        }
    }
}
