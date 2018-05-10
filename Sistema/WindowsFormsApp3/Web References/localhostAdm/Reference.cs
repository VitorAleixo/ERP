﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WindowsFormsApp3.localhostAdm {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AdminSoap", Namespace="http://tempuri.org/")]
    public partial class Admin : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CadastroUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback CadastroPermissoesUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback RetornaUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback RetornaComboNomeOperationCompleted;
        
        private System.Threading.SendOrPostCallback VerificarPermissaoOperationCompleted;
        
        private System.Threading.SendOrPostCallback AtualizaPermissoesAdicionaOperationCompleted;
        
        private System.Threading.SendOrPostCallback AtualizaPermissoesRemoveOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Admin() {
            this.Url = global::WindowsFormsApp3.Properties.Settings.Default.WindowsFormsApp3_localhostAdm_Admin;
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
        public event CadastroUsuarioCompletedEventHandler CadastroUsuarioCompleted;
        
        /// <remarks/>
        public event CadastroPermissoesUsuarioCompletedEventHandler CadastroPermissoesUsuarioCompleted;
        
        /// <remarks/>
        public event RetornaUsuarioCompletedEventHandler RetornaUsuarioCompleted;
        
        /// <remarks/>
        public event RetornaComboNomeCompletedEventHandler RetornaComboNomeCompleted;
        
        /// <remarks/>
        public event VerificarPermissaoCompletedEventHandler VerificarPermissaoCompleted;
        
        /// <remarks/>
        public event AtualizaPermissoesAdicionaCompletedEventHandler AtualizaPermissoesAdicionaCompleted;
        
        /// <remarks/>
        public event AtualizaPermissoesRemoveCompletedEventHandler AtualizaPermissoesRemoveCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CadastroUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int CadastroUsuario(string Nome, string Funcao, string Departamento, string Usuario, string Senha, System.DateTime DataCriacao) {
            object[] results = this.Invoke("CadastroUsuario", new object[] {
                        Nome,
                        Funcao,
                        Departamento,
                        Usuario,
                        Senha,
                        DataCriacao});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void CadastroUsuarioAsync(string Nome, string Funcao, string Departamento, string Usuario, string Senha, System.DateTime DataCriacao) {
            this.CadastroUsuarioAsync(Nome, Funcao, Departamento, Usuario, Senha, DataCriacao, null);
        }
        
        /// <remarks/>
        public void CadastroUsuarioAsync(string Nome, string Funcao, string Departamento, string Usuario, string Senha, System.DateTime DataCriacao, object userState) {
            if ((this.CadastroUsuarioOperationCompleted == null)) {
                this.CadastroUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCadastroUsuarioOperationCompleted);
            }
            this.InvokeAsync("CadastroUsuario", new object[] {
                        Nome,
                        Funcao,
                        Departamento,
                        Usuario,
                        Senha,
                        DataCriacao}, this.CadastroUsuarioOperationCompleted, userState);
        }
        
        private void OnCadastroUsuarioOperationCompleted(object arg) {
            if ((this.CadastroUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CadastroUsuarioCompleted(this, new CadastroUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CadastroPermissoesUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CadastroPermissoesUsuario(string Departamento, int IdUsuario, string Usuario) {
            object[] results = this.Invoke("CadastroPermissoesUsuario", new object[] {
                        Departamento,
                        IdUsuario,
                        Usuario});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CadastroPermissoesUsuarioAsync(string Departamento, int IdUsuario, string Usuario) {
            this.CadastroPermissoesUsuarioAsync(Departamento, IdUsuario, Usuario, null);
        }
        
        /// <remarks/>
        public void CadastroPermissoesUsuarioAsync(string Departamento, int IdUsuario, string Usuario, object userState) {
            if ((this.CadastroPermissoesUsuarioOperationCompleted == null)) {
                this.CadastroPermissoesUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCadastroPermissoesUsuarioOperationCompleted);
            }
            this.InvokeAsync("CadastroPermissoesUsuario", new object[] {
                        Departamento,
                        IdUsuario,
                        Usuario}, this.CadastroPermissoesUsuarioOperationCompleted, userState);
        }
        
        private void OnCadastroPermissoesUsuarioOperationCompleted(object arg) {
            if ((this.CadastroPermissoesUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CadastroPermissoesUsuarioCompleted(this, new CadastroPermissoesUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RetornaUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("BuscaUsuario", IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("USUARIO", IsNullable=false)]
        public Usuario[] RetornaUsuario() {
            object[] results = this.Invoke("RetornaUsuario", new object[0]);
            return ((Usuario[])(results[0]));
        }
        
        /// <remarks/>
        public void RetornaUsuarioAsync() {
            this.RetornaUsuarioAsync(null);
        }
        
        /// <remarks/>
        public void RetornaUsuarioAsync(object userState) {
            if ((this.RetornaUsuarioOperationCompleted == null)) {
                this.RetornaUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRetornaUsuarioOperationCompleted);
            }
            this.InvokeAsync("RetornaUsuario", new object[0], this.RetornaUsuarioOperationCompleted, userState);
        }
        
        private void OnRetornaUsuarioOperationCompleted(object arg) {
            if ((this.RetornaUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RetornaUsuarioCompleted(this, new RetornaUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RetornaComboNome", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("BuscaComboNome", IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("NOME", IsNullable=false)]
        public NomeCombo[] RetornaComboNome() {
            object[] results = this.Invoke("RetornaComboNome", new object[0]);
            return ((NomeCombo[])(results[0]));
        }
        
        /// <remarks/>
        public void RetornaComboNomeAsync() {
            this.RetornaComboNomeAsync(null);
        }
        
        /// <remarks/>
        public void RetornaComboNomeAsync(object userState) {
            if ((this.RetornaComboNomeOperationCompleted == null)) {
                this.RetornaComboNomeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRetornaComboNomeOperationCompleted);
            }
            this.InvokeAsync("RetornaComboNome", new object[0], this.RetornaComboNomeOperationCompleted, userState);
        }
        
        private void OnRetornaComboNomeOperationCompleted(object arg) {
            if ((this.RetornaComboNomeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RetornaComboNomeCompleted(this, new RetornaComboNomeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/VerificarPermissao", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool VerificarPermissao(string Departamento, string Usuario) {
            object[] results = this.Invoke("VerificarPermissao", new object[] {
                        Departamento,
                        Usuario});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void VerificarPermissaoAsync(string Departamento, string Usuario) {
            this.VerificarPermissaoAsync(Departamento, Usuario, null);
        }
        
        /// <remarks/>
        public void VerificarPermissaoAsync(string Departamento, string Usuario, object userState) {
            if ((this.VerificarPermissaoOperationCompleted == null)) {
                this.VerificarPermissaoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerificarPermissaoOperationCompleted);
            }
            this.InvokeAsync("VerificarPermissao", new object[] {
                        Departamento,
                        Usuario}, this.VerificarPermissaoOperationCompleted, userState);
        }
        
        private void OnVerificarPermissaoOperationCompleted(object arg) {
            if ((this.VerificarPermissaoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerificarPermissaoCompleted(this, new VerificarPermissaoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AtualizaPermissoesAdiciona", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AtualizaPermissoesAdiciona(string Departamento, string Usuario) {
            object[] results = this.Invoke("AtualizaPermissoesAdiciona", new object[] {
                        Departamento,
                        Usuario});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AtualizaPermissoesAdicionaAsync(string Departamento, string Usuario) {
            this.AtualizaPermissoesAdicionaAsync(Departamento, Usuario, null);
        }
        
        /// <remarks/>
        public void AtualizaPermissoesAdicionaAsync(string Departamento, string Usuario, object userState) {
            if ((this.AtualizaPermissoesAdicionaOperationCompleted == null)) {
                this.AtualizaPermissoesAdicionaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAtualizaPermissoesAdicionaOperationCompleted);
            }
            this.InvokeAsync("AtualizaPermissoesAdiciona", new object[] {
                        Departamento,
                        Usuario}, this.AtualizaPermissoesAdicionaOperationCompleted, userState);
        }
        
        private void OnAtualizaPermissoesAdicionaOperationCompleted(object arg) {
            if ((this.AtualizaPermissoesAdicionaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AtualizaPermissoesAdicionaCompleted(this, new AtualizaPermissoesAdicionaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AtualizaPermissoesRemove", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AtualizaPermissoesRemove(string Departamento, string Usuario) {
            object[] results = this.Invoke("AtualizaPermissoesRemove", new object[] {
                        Departamento,
                        Usuario});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AtualizaPermissoesRemoveAsync(string Departamento, string Usuario) {
            this.AtualizaPermissoesRemoveAsync(Departamento, Usuario, null);
        }
        
        /// <remarks/>
        public void AtualizaPermissoesRemoveAsync(string Departamento, string Usuario, object userState) {
            if ((this.AtualizaPermissoesRemoveOperationCompleted == null)) {
                this.AtualizaPermissoesRemoveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAtualizaPermissoesRemoveOperationCompleted);
            }
            this.InvokeAsync("AtualizaPermissoesRemove", new object[] {
                        Departamento,
                        Usuario}, this.AtualizaPermissoesRemoveOperationCompleted, userState);
        }
        
        private void OnAtualizaPermissoesRemoveOperationCompleted(object arg) {
            if ((this.AtualizaPermissoesRemoveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AtualizaPermissoesRemoveCompleted(this, new AtualizaPermissoesRemoveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Usuario {
        
        private string nomeField;
        
        private string funcaoField;
        
        private string departamentoField;
        
        private string userField;
        
        private string dataCriacaoField;
        
        /// <remarks/>
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        public string Funcao {
            get {
                return this.funcaoField;
            }
            set {
                this.funcaoField = value;
            }
        }
        
        /// <remarks/>
        public string Departamento {
            get {
                return this.departamentoField;
            }
            set {
                this.departamentoField = value;
            }
        }
        
        /// <remarks/>
        public string User {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        
        /// <remarks/>
        public string DataCriacao {
            get {
                return this.dataCriacaoField;
            }
            set {
                this.dataCriacaoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class NomeCombo {
        
        private string nomeField;
        
        /// <remarks/>
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void CadastroUsuarioCompletedEventHandler(object sender, CadastroUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CadastroUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CadastroUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void CadastroPermissoesUsuarioCompletedEventHandler(object sender, CadastroPermissoesUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CadastroPermissoesUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CadastroPermissoesUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void RetornaUsuarioCompletedEventHandler(object sender, RetornaUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RetornaUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RetornaUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Usuario[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Usuario[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void RetornaComboNomeCompletedEventHandler(object sender, RetornaComboNomeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RetornaComboNomeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RetornaComboNomeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public NomeCombo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((NomeCombo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void VerificarPermissaoCompletedEventHandler(object sender, VerificarPermissaoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerificarPermissaoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerificarPermissaoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void AtualizaPermissoesAdicionaCompletedEventHandler(object sender, AtualizaPermissoesAdicionaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AtualizaPermissoesAdicionaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AtualizaPermissoesAdicionaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void AtualizaPermissoesRemoveCompletedEventHandler(object sender, AtualizaPermissoesRemoveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AtualizaPermissoesRemoveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AtualizaPermissoesRemoveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591