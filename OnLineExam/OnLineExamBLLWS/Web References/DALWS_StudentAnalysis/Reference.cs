﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3603
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 2.0.50727.3603 版自动生成。
// 
#pragma warning disable 1591

namespace OnLineExamBLLWS.DALWS_StudentAnalysis {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Users[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SelectUserNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback SelectUserScoresOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPaperTypeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::OnLineExamBLLWS.Properties.Settings.Default.OnLineExamBLLWS_DALWS_StudentAnalysis_WebService1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SelectUserNameCompletedEventHandler SelectUserNameCompleted;
        
        /// <remarks/>
        public event SelectUserScoresCompletedEventHandler SelectUserScoresCompleted;
        
        /// <remarks/>
        public event GetPaperTypeCompletedEventHandler GetPaperTypeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SelectUserName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Users[] SelectUserName() {
            object[] results = this.Invoke("SelectUserName", new object[0]);
            return ((Users[])(results[0]));
        }
        
        /// <remarks/>
        public void SelectUserNameAsync() {
            this.SelectUserNameAsync(null);
        }
        
        /// <remarks/>
        public void SelectUserNameAsync(object userState) {
            if ((this.SelectUserNameOperationCompleted == null)) {
                this.SelectUserNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSelectUserNameOperationCompleted);
            }
            this.InvokeAsync("SelectUserName", new object[0], this.SelectUserNameOperationCompleted, userState);
        }
        
        private void OnSelectUserNameOperationCompleted(object arg) {
            if ((this.SelectUserNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SelectUserNameCompleted(this, new SelectUserNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SelectUserScores", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Scores[] SelectUserScores(string userID) {
            object[] results = this.Invoke("SelectUserScores", new object[] {
                        userID});
            return ((Scores[])(results[0]));
        }
        
        /// <remarks/>
        public void SelectUserScoresAsync(string userID) {
            this.SelectUserScoresAsync(userID, null);
        }
        
        /// <remarks/>
        public void SelectUserScoresAsync(string userID, object userState) {
            if ((this.SelectUserScoresOperationCompleted == null)) {
                this.SelectUserScoresOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSelectUserScoresOperationCompleted);
            }
            this.InvokeAsync("SelectUserScores", new object[] {
                        userID}, this.SelectUserScoresOperationCompleted, userState);
        }
        
        private void OnSelectUserScoresOperationCompleted(object arg) {
            if ((this.SelectUserScoresCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SelectUserScoresCompleted(this, new SelectUserScoresCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPaperType", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetPaperType(int id) {
            object[] results = this.Invoke("GetPaperType", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetPaperTypeAsync(int id) {
            this.GetPaperTypeAsync(id, null);
        }
        
        /// <remarks/>
        public void GetPaperTypeAsync(int id, object userState) {
            if ((this.GetPaperTypeOperationCompleted == null)) {
                this.GetPaperTypeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPaperTypeOperationCompleted);
            }
            this.InvokeAsync("GetPaperType", new object[] {
                        id}, this.GetPaperTypeOperationCompleted, userState);
        }
        
        private void OnGetPaperTypeOperationCompleted(object arg) {
            if ((this.GetPaperTypeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPaperTypeCompleted(this, new GetPaperTypeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Users {
        
        private Role roleField;
        
        private string userIDField;
        
        private string userPwdField;
        
        private string userNameField;
        
        private int roleIdField;
        
        private string roleNameField;
        
        private object[] dutiesField;
        
        private string phoneField;
        
        private string addressField;
        
        /// <remarks/>
        public Role Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        public string UserID {
            get {
                return this.userIDField;
            }
            set {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        public string UserPwd {
            get {
                return this.userPwdField;
            }
            set {
                this.userPwdField = value;
            }
        }
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public int RoleId {
            get {
                return this.roleIdField;
            }
            set {
                this.roleIdField = value;
            }
        }
        
        /// <remarks/>
        public string RoleName {
            get {
                return this.roleNameField;
            }
            set {
                this.roleNameField = value;
            }
        }
        
        /// <remarks/>
        public object[] Duties {
            get {
                return this.dutiesField;
            }
            set {
                this.dutiesField = value;
            }
        }
        
        /// <remarks/>
        public string Phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Role {
        
        private int roleIdField;
        
        private string roleNameField;
        
        private int hasDuty_UserManageField;
        
        private int hasDuty_RoleManageField;
        
        private int hasDuty_RoleField;
        
        private int hasDuty_UserScoreField;
        
        private int hasDuty_CourseManageField;
        
        private int hasDuty_PaperSetupField;
        
        private int hasDuty_PaperListsField;
        
        private int hasDuty_UserPaperListField;
        
        private int hasDuty_SingleSelectManageField;
        
        private int hasDuty_MultiSelectManageField;
        
        private int hasDuty_FillBlankManageField;
        
        private int hasDuty_JudgeManageField;
        
        private int hasDuty_QuestionManageField;
        
        /// <remarks/>
        public int RoleId {
            get {
                return this.roleIdField;
            }
            set {
                this.roleIdField = value;
            }
        }
        
        /// <remarks/>
        public string RoleName {
            get {
                return this.roleNameField;
            }
            set {
                this.roleNameField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_UserManage {
            get {
                return this.hasDuty_UserManageField;
            }
            set {
                this.hasDuty_UserManageField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_RoleManage {
            get {
                return this.hasDuty_RoleManageField;
            }
            set {
                this.hasDuty_RoleManageField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_Role {
            get {
                return this.hasDuty_RoleField;
            }
            set {
                this.hasDuty_RoleField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_UserScore {
            get {
                return this.hasDuty_UserScoreField;
            }
            set {
                this.hasDuty_UserScoreField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_CourseManage {
            get {
                return this.hasDuty_CourseManageField;
            }
            set {
                this.hasDuty_CourseManageField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_PaperSetup {
            get {
                return this.hasDuty_PaperSetupField;
            }
            set {
                this.hasDuty_PaperSetupField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_PaperLists {
            get {
                return this.hasDuty_PaperListsField;
            }
            set {
                this.hasDuty_PaperListsField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_UserPaperList {
            get {
                return this.hasDuty_UserPaperListField;
            }
            set {
                this.hasDuty_UserPaperListField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_SingleSelectManage {
            get {
                return this.hasDuty_SingleSelectManageField;
            }
            set {
                this.hasDuty_SingleSelectManageField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_MultiSelectManage {
            get {
                return this.hasDuty_MultiSelectManageField;
            }
            set {
                this.hasDuty_MultiSelectManageField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_FillBlankManage {
            get {
                return this.hasDuty_FillBlankManageField;
            }
            set {
                this.hasDuty_FillBlankManageField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_JudgeManage {
            get {
                return this.hasDuty_JudgeManageField;
            }
            set {
                this.hasDuty_JudgeManageField = value;
            }
        }
        
        /// <remarks/>
        public int HasDuty_QuestionManage {
            get {
                return this.hasDuty_QuestionManageField;
            }
            set {
                this.hasDuty_QuestionManageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Scores {
        
        private int idField;
        
        private string userIDField;
        
        private string userNameField;
        
        private int paperIDField;
        
        private int scoreField;
        
        private System.DateTime examTimeField;
        
        private System.DateTime judgeTimeField;
        
        private string pingYuField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string UserID {
            get {
                return this.userIDField;
            }
            set {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public int PaperID {
            get {
                return this.paperIDField;
            }
            set {
                this.paperIDField = value;
            }
        }
        
        /// <remarks/>
        public int Score {
            get {
                return this.scoreField;
            }
            set {
                this.scoreField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime ExamTime {
            get {
                return this.examTimeField;
            }
            set {
                this.examTimeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime JudgeTime {
            get {
                return this.judgeTimeField;
            }
            set {
                this.judgeTimeField = value;
            }
        }
        
        /// <remarks/>
        public string PingYu {
            get {
                return this.pingYuField;
            }
            set {
                this.pingYuField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void SelectUserNameCompletedEventHandler(object sender, SelectUserNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectUserNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SelectUserNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Users[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Users[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void SelectUserScoresCompletedEventHandler(object sender, SelectUserScoresCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectUserScoresCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SelectUserScoresCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Scores[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Scores[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetPaperTypeCompletedEventHandler(object sender, GetPaperTypeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPaperTypeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPaperTypeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591