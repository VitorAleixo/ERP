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

namespace WindowsFormsApp3.localhost {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="LoginSoap", Namespace="http://tempuri.org/")]
    public partial class Login : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LoginSistemaOperationCompleted;
        
        private System.Threading.SendOrPostCallback CadastroFornecedorOperationCompleted;
        
        private System.Threading.SendOrPostCallback CadastroUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback CadastroProdutoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Login() {
            this.Url = global::WindowsFormsApp3.Properties.Settings.Default.WindowsFormsApp3_localhost_Login;
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
        public event LoginSistemaCompletedEventHandler LoginSistemaCompleted;
        
        /// <remarks/>
        public event CadastroFornecedorCompletedEventHandler CadastroFornecedorCompleted;
        
        /// <remarks/>
        public event CadastroUsuarioCompletedEventHandler CadastroUsuarioCompleted;
        
        /// <remarks/>
        public event CadastroProdutoCompletedEventHandler CadastroProdutoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LoginSistema", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool LoginSistema(string Usuario, string Senha) {
            object[] results = this.Invoke("LoginSistema", new object[] {
                        Usuario,
                        Senha});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void LoginSistemaAsync(string Usuario, string Senha) {
            this.LoginSistemaAsync(Usuario, Senha, null);
        }
        
        /// <remarks/>
        public void LoginSistemaAsync(string Usuario, string Senha, object userState) {
            if ((this.LoginSistemaOperationCompleted == null)) {
                this.LoginSistemaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginSistemaOperationCompleted);
            }
            this.InvokeAsync("LoginSistema", new object[] {
                        Usuario,
                        Senha}, this.LoginSistemaOperationCompleted, userState);
        }
        
        private void OnLoginSistemaOperationCompleted(object arg) {
            if ((this.LoginSistemaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginSistemaCompleted(this, new LoginSistemaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CadastroFornecedor", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CadastroFornecedor(string Nome, string CPF, string CEP, string Endereco, string Bairro, string Cidade, string Complemento, string Estado, string Complemento2, string Numero, string Telefone, string Telefone2, string EMAIL) {
            object[] results = this.Invoke("CadastroFornecedor", new object[] {
                        Nome,
                        CPF,
                        CEP,
                        Endereco,
                        Bairro,
                        Cidade,
                        Complemento,
                        Estado,
                        Complemento2,
                        Numero,
                        Telefone,
                        Telefone2,
                        EMAIL});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CadastroFornecedorAsync(string Nome, string CPF, string CEP, string Endereco, string Bairro, string Cidade, string Complemento, string Estado, string Complemento2, string Numero, string Telefone, string Telefone2, string EMAIL) {
            this.CadastroFornecedorAsync(Nome, CPF, CEP, Endereco, Bairro, Cidade, Complemento, Estado, Complemento2, Numero, Telefone, Telefone2, EMAIL, null);
        }
        
        /// <remarks/>
        public void CadastroFornecedorAsync(string Nome, string CPF, string CEP, string Endereco, string Bairro, string Cidade, string Complemento, string Estado, string Complemento2, string Numero, string Telefone, string Telefone2, string EMAIL, object userState) {
            if ((this.CadastroFornecedorOperationCompleted == null)) {
                this.CadastroFornecedorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCadastroFornecedorOperationCompleted);
            }
            this.InvokeAsync("CadastroFornecedor", new object[] {
                        Nome,
                        CPF,
                        CEP,
                        Endereco,
                        Bairro,
                        Cidade,
                        Complemento,
                        Estado,
                        Complemento2,
                        Numero,
                        Telefone,
                        Telefone2,
                        EMAIL}, this.CadastroFornecedorOperationCompleted, userState);
        }
        
        private void OnCadastroFornecedorOperationCompleted(object arg) {
            if ((this.CadastroFornecedorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CadastroFornecedorCompleted(this, new CadastroFornecedorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CadastroUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CadastroUsuario(string Nome, string Funcao, string Departamento, string Usuario, string Senha, System.DateTime DataCriacao) {
            object[] results = this.Invoke("CadastroUsuario", new object[] {
                        Nome,
                        Funcao,
                        Departamento,
                        Usuario,
                        Senha,
                        DataCriacao});
            return ((bool)(results[0]));
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CadastroProduto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CadastroProduto(string CodigoProduto, string Nome, float Preco, string UnidadeMedida, float QtdMinima, float QtdMaxima, float QtdEstoque) {
            object[] results = this.Invoke("CadastroProduto", new object[] {
                        CodigoProduto,
                        Nome,
                        Preco,
                        UnidadeMedida,
                        QtdMinima,
                        QtdMaxima,
                        QtdEstoque});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CadastroProdutoAsync(string CodigoProduto, string Nome, float Preco, string UnidadeMedida, float QtdMinima, float QtdMaxima, float QtdEstoque) {
            this.CadastroProdutoAsync(CodigoProduto, Nome, Preco, UnidadeMedida, QtdMinima, QtdMaxima, QtdEstoque, null);
        }
        
        /// <remarks/>
        public void CadastroProdutoAsync(string CodigoProduto, string Nome, float Preco, string UnidadeMedida, float QtdMinima, float QtdMaxima, float QtdEstoque, object userState) {
            if ((this.CadastroProdutoOperationCompleted == null)) {
                this.CadastroProdutoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCadastroProdutoOperationCompleted);
            }
            this.InvokeAsync("CadastroProduto", new object[] {
                        CodigoProduto,
                        Nome,
                        Preco,
                        UnidadeMedida,
                        QtdMinima,
                        QtdMaxima,
                        QtdEstoque}, this.CadastroProdutoOperationCompleted, userState);
        }
        
        private void OnCadastroProdutoOperationCompleted(object arg) {
            if ((this.CadastroProdutoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CadastroProdutoCompleted(this, new CadastroProdutoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void LoginSistemaCompletedEventHandler(object sender, LoginSistemaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginSistemaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginSistemaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void CadastroFornecedorCompletedEventHandler(object sender, CadastroFornecedorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CadastroFornecedorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CadastroFornecedorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void CadastroProdutoCompletedEventHandler(object sender, CadastroProdutoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CadastroProdutoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CadastroProdutoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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