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

namespace OnLineExamBLLWS.DALWS_QuestionProblem {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="DALWS_QuestionProblemSoap", Namespace="http://tempuri.org/")]
    public partial class DALWS_QuestionProblem : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback QuestionProblemInsertOperationCompleted;
        
        private System.Threading.SendOrPostCallback QuestionProblemUpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetQuestionProblemListOperationCompleted;
        
        private System.Threading.SendOrPostCallback selectQuesQuestionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DALWS_QuestionProblem() {
            this.Url = global::OnLineExamBLLWS.Properties.Settings.Default.OnLineExamBLLWS_DALWS_QuestionProblem_DALWS_QuestionProblem;
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
        public event QuestionProblemInsertCompletedEventHandler QuestionProblemInsertCompleted;
        
        /// <remarks/>
        public event QuestionProblemUpdateCompletedEventHandler QuestionProblemUpdateCompleted;
        
        /// <remarks/>
        public event GetQuestionProblemListCompletedEventHandler GetQuestionProblemListCompleted;
        
        /// <remarks/>
        public event selectQuesQuestionCompletedEventHandler selectQuesQuestionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/QuestionProblemInsert", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool QuestionProblemInsert(QuestionProblem qi) {
            object[] results = this.Invoke("QuestionProblemInsert", new object[] {
                        qi});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void QuestionProblemInsertAsync(QuestionProblem qi) {
            this.QuestionProblemInsertAsync(qi, null);
        }
        
        /// <remarks/>
        public void QuestionProblemInsertAsync(QuestionProblem qi, object userState) {
            if ((this.QuestionProblemInsertOperationCompleted == null)) {
                this.QuestionProblemInsertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQuestionProblemInsertOperationCompleted);
            }
            this.InvokeAsync("QuestionProblemInsert", new object[] {
                        qi}, this.QuestionProblemInsertOperationCompleted, userState);
        }
        
        private void OnQuestionProblemInsertOperationCompleted(object arg) {
            if ((this.QuestionProblemInsertCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QuestionProblemInsertCompleted(this, new QuestionProblemInsertCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/QuestionProblemUpdate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool QuestionProblemUpdate(QuestionProblem qu) {
            object[] results = this.Invoke("QuestionProblemUpdate", new object[] {
                        qu});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void QuestionProblemUpdateAsync(QuestionProblem qu) {
            this.QuestionProblemUpdateAsync(qu, null);
        }
        
        /// <remarks/>
        public void QuestionProblemUpdateAsync(QuestionProblem qu, object userState) {
            if ((this.QuestionProblemUpdateOperationCompleted == null)) {
                this.QuestionProblemUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQuestionProblemUpdateOperationCompleted);
            }
            this.InvokeAsync("QuestionProblemUpdate", new object[] {
                        qu}, this.QuestionProblemUpdateOperationCompleted, userState);
        }
        
        private void OnQuestionProblemUpdateOperationCompleted(object arg) {
            if ((this.QuestionProblemUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QuestionProblemUpdateCompleted(this, new QuestionProblemUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetQuestionProblemList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public QuestionProblem[] GetQuestionProblemList(string selectvalue) {
            object[] results = this.Invoke("GetQuestionProblemList", new object[] {
                        selectvalue});
            return ((QuestionProblem[])(results[0]));
        }
        
        /// <remarks/>
        public void GetQuestionProblemListAsync(string selectvalue) {
            this.GetQuestionProblemListAsync(selectvalue, null);
        }
        
        /// <remarks/>
        public void GetQuestionProblemListAsync(string selectvalue, object userState) {
            if ((this.GetQuestionProblemListOperationCompleted == null)) {
                this.GetQuestionProblemListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetQuestionProblemListOperationCompleted);
            }
            this.InvokeAsync("GetQuestionProblemList", new object[] {
                        selectvalue}, this.GetQuestionProblemListOperationCompleted, userState);
        }
        
        private void OnGetQuestionProblemListOperationCompleted(object arg) {
            if ((this.GetQuestionProblemListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetQuestionProblemListCompleted(this, new GetQuestionProblemListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/selectQuesQuestion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public QuestionProblem[] selectQuesQuestion(string UserId, int PaperId) {
            object[] results = this.Invoke("selectQuesQuestion", new object[] {
                        UserId,
                        PaperId});
            return ((QuestionProblem[])(results[0]));
        }
        
        /// <remarks/>
        public void selectQuesQuestionAsync(string UserId, int PaperId) {
            this.selectQuesQuestionAsync(UserId, PaperId, null);
        }
        
        /// <remarks/>
        public void selectQuesQuestionAsync(string UserId, int PaperId, object userState) {
            if ((this.selectQuesQuestionOperationCompleted == null)) {
                this.selectQuesQuestionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnselectQuesQuestionOperationCompleted);
            }
            this.InvokeAsync("selectQuesQuestion", new object[] {
                        UserId,
                        PaperId}, this.selectQuesQuestionOperationCompleted, userState);
        }
        
        private void OnselectQuesQuestionOperationCompleted(object arg) {
            if ((this.selectQuesQuestionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.selectQuesQuestionCompleted(this, new selectQuesQuestionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class QuestionProblem {
        
        private string userAnswerField;
        
        private System.DateTime examTimeField;
        
        private int markField;
        
        private string paperNameField;
        
        private int idField;
        
        private int courseIDField;
        
        private string titleField;
        
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
    public delegate void QuestionProblemInsertCompletedEventHandler(object sender, QuestionProblemInsertCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QuestionProblemInsertCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal QuestionProblemInsertCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void QuestionProblemUpdateCompletedEventHandler(object sender, QuestionProblemUpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QuestionProblemUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal QuestionProblemUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetQuestionProblemListCompletedEventHandler(object sender, GetQuestionProblemListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetQuestionProblemListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetQuestionProblemListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public QuestionProblem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((QuestionProblem[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void selectQuesQuestionCompletedEventHandler(object sender, selectQuesQuestionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class selectQuesQuestionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal selectQuesQuestionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public QuestionProblem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((QuestionProblem[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591