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

namespace OnLineExamBLLWS.DALWS_MultiProblem {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="DALWS_MultiProblemSoap", Namespace="http://tempuri.org/")]
    public partial class DALWS_MultiProblem : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback MultiProblemInsertOperationCompleted;
        
        private System.Threading.SendOrPostCallback MultiProblemUpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMultiProblemListOperationCompleted;
        
        private System.Threading.SendOrPostCallback selectMutiQuestionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DALWS_MultiProblem() {
            this.Url = global::OnLineExamBLLWS.Properties.Settings.Default.OnLineExamBLLWS_DALWS_MultiProblem_DALWS_MultiProblem;
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
        public event MultiProblemInsertCompletedEventHandler MultiProblemInsertCompleted;
        
        /// <remarks/>
        public event MultiProblemUpdateCompletedEventHandler MultiProblemUpdateCompleted;
        
        /// <remarks/>
        public event GetMultiProblemListCompletedEventHandler GetMultiProblemListCompleted;
        
        /// <remarks/>
        public event selectMutiQuestionCompletedEventHandler selectMutiQuestionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MultiProblemInsert", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool MultiProblemInsert(MultiProblem mi) {
            object[] results = this.Invoke("MultiProblemInsert", new object[] {
                        mi});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void MultiProblemInsertAsync(MultiProblem mi) {
            this.MultiProblemInsertAsync(mi, null);
        }
        
        /// <remarks/>
        public void MultiProblemInsertAsync(MultiProblem mi, object userState) {
            if ((this.MultiProblemInsertOperationCompleted == null)) {
                this.MultiProblemInsertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMultiProblemInsertOperationCompleted);
            }
            this.InvokeAsync("MultiProblemInsert", new object[] {
                        mi}, this.MultiProblemInsertOperationCompleted, userState);
        }
        
        private void OnMultiProblemInsertOperationCompleted(object arg) {
            if ((this.MultiProblemInsertCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MultiProblemInsertCompleted(this, new MultiProblemInsertCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MultiProblemUpdate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool MultiProblemUpdate(MultiProblem mu) {
            object[] results = this.Invoke("MultiProblemUpdate", new object[] {
                        mu});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void MultiProblemUpdateAsync(MultiProblem mu) {
            this.MultiProblemUpdateAsync(mu, null);
        }
        
        /// <remarks/>
        public void MultiProblemUpdateAsync(MultiProblem mu, object userState) {
            if ((this.MultiProblemUpdateOperationCompleted == null)) {
                this.MultiProblemUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMultiProblemUpdateOperationCompleted);
            }
            this.InvokeAsync("MultiProblemUpdate", new object[] {
                        mu}, this.MultiProblemUpdateOperationCompleted, userState);
        }
        
        private void OnMultiProblemUpdateOperationCompleted(object arg) {
            if ((this.MultiProblemUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MultiProblemUpdateCompleted(this, new MultiProblemUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMultiProblemList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MultiProblem[] GetMultiProblemList(string selectvalue) {
            object[] results = this.Invoke("GetMultiProblemList", new object[] {
                        selectvalue});
            return ((MultiProblem[])(results[0]));
        }
        
        /// <remarks/>
        public void GetMultiProblemListAsync(string selectvalue) {
            this.GetMultiProblemListAsync(selectvalue, null);
        }
        
        /// <remarks/>
        public void GetMultiProblemListAsync(string selectvalue, object userState) {
            if ((this.GetMultiProblemListOperationCompleted == null)) {
                this.GetMultiProblemListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMultiProblemListOperationCompleted);
            }
            this.InvokeAsync("GetMultiProblemList", new object[] {
                        selectvalue}, this.GetMultiProblemListOperationCompleted, userState);
        }
        
        private void OnGetMultiProblemListOperationCompleted(object arg) {
            if ((this.GetMultiProblemListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMultiProblemListCompleted(this, new GetMultiProblemListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/selectMutiQuestion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MultiProblem[] selectMutiQuestion(string UserId, int PaperId) {
            object[] results = this.Invoke("selectMutiQuestion", new object[] {
                        UserId,
                        PaperId});
            return ((MultiProblem[])(results[0]));
        }
        
        /// <remarks/>
        public void selectMutiQuestionAsync(string UserId, int PaperId) {
            this.selectMutiQuestionAsync(UserId, PaperId, null);
        }
        
        /// <remarks/>
        public void selectMutiQuestionAsync(string UserId, int PaperId, object userState) {
            if ((this.selectMutiQuestionOperationCompleted == null)) {
                this.selectMutiQuestionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnselectMutiQuestionOperationCompleted);
            }
            this.InvokeAsync("selectMutiQuestion", new object[] {
                        UserId,
                        PaperId}, this.selectMutiQuestionOperationCompleted, userState);
        }
        
        private void OnselectMutiQuestionOperationCompleted(object arg) {
            if ((this.selectMutiQuestionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.selectMutiQuestionCompleted(this, new selectMutiQuestionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class MultiProblem {
        
        private string userAnswerField;
        
        private System.DateTime examTimeField;
        
        private int markField;
        
        private string paperNameField;
        
        private int idField;
        
        private int courseIDField;
        
        private string titleField;
        
        private string answerAField;
        
        private string answerBField;
        
        private string answerCField;
        
        private string answerDField;
        
        private string answerField;
        
        /// <remarks/>
        public string UserAnswer {
            get {
                return this.userAnswerField;
            }
            set {
                this.userAnswerField = value;
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
        public int Mark {
            get {
                return this.markField;
            }
            set {
                this.markField = value;
            }
        }
        
        /// <remarks/>
        public string PaperName {
            get {
                return this.paperNameField;
            }
            set {
                this.paperNameField = value;
            }
        }
        
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
        public int CourseID {
            get {
                return this.courseIDField;
            }
            set {
                this.courseIDField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string AnswerA {
            get {
                return this.answerAField;
            }
            set {
                this.answerAField = value;
            }
        }
        
        /// <remarks/>
        public string AnswerB {
            get {
                return this.answerBField;
            }
            set {
                this.answerBField = value;
            }
        }
        
        /// <remarks/>
        public string AnswerC {
            get {
                return this.answerCField;
            }
            set {
                this.answerCField = value;
            }
        }
        
        /// <remarks/>
        public string AnswerD {
            get {
                return this.answerDField;
            }
            set {
                this.answerDField = value;
            }
        }
        
        /// <remarks/>
        public string Answer {
            get {
                return this.answerField;
            }
            set {
                this.answerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void MultiProblemInsertCompletedEventHandler(object sender, MultiProblemInsertCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MultiProblemInsertCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MultiProblemInsertCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void MultiProblemUpdateCompletedEventHandler(object sender, MultiProblemUpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MultiProblemUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MultiProblemUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetMultiProblemListCompletedEventHandler(object sender, GetMultiProblemListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMultiProblemListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMultiProblemListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MultiProblem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MultiProblem[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void selectMutiQuestionCompletedEventHandler(object sender, selectMutiQuestionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class selectMutiQuestionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal selectMutiQuestionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MultiProblem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MultiProblem[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591