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

namespace WindowsFormsApp3.localhostAmx {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AlmoxarifadoSoap", Namespace="http://tempuri.org/")]
    public partial class Almoxarifado : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CadastroProdutoOperationCompleted;
        
        private System.Threading.SendOrPostCallback CadastroProdutoEstoqueOperationCompleted;
        
        private System.Threading.SendOrPostCallback GerarPedidoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GerarPedidoItemOperationCompleted;
        
        private System.Threading.SendOrPostCallback CompraDataSetOperationCompleted;
        
        private System.Threading.SendOrPostCallback RetornaProdutoOperationCompleted;
        
        private System.Threading.SendOrPostCallback RetornaComboTipoOperationCompleted;
        
        private System.Threading.SendOrPostCallback RetornaEstoqueOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Almoxarifado() {
            this.Url = global::WindowsFormsApp3.Properties.Settings.Default.WindowsFormsApp3_localhostAmx_Almoxarifado;
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
        public event CadastroProdutoCompletedEventHandler CadastroProdutoCompleted;
        
        /// <remarks/>
        public event CadastroProdutoEstoqueCompletedEventHandler CadastroProdutoEstoqueCompleted;
        
        /// <remarks/>
        public event GerarPedidoCompletedEventHandler GerarPedidoCompleted;
        
        /// <remarks/>
        public event GerarPedidoItemCompletedEventHandler GerarPedidoItemCompleted;
        
        /// <remarks/>
        public event CompraDataSetCompletedEventHandler CompraDataSetCompleted;
        
        /// <remarks/>
        public event RetornaProdutoCompletedEventHandler RetornaProdutoCompleted;
        
        /// <remarks/>
        public event RetornaComboTipoCompletedEventHandler RetornaComboTipoCompleted;
        
        /// <remarks/>
        public event RetornaEstoqueCompletedEventHandler RetornaEstoqueCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CadastroProduto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int CadastroProduto(string CodigoProduto, string Nome, double Preco, string UnidadeMedida, float QtdMinima, float QtdMaxima, float QtdEstoque, string Tipo) {
            object[] results = this.Invoke("CadastroProduto", new object[] {
                        CodigoProduto,
                        Nome,
                        Preco,
                        UnidadeMedida,
                        QtdMinima,
                        QtdMaxima,
                        QtdEstoque,
                        Tipo});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void CadastroProdutoAsync(string CodigoProduto, string Nome, double Preco, string UnidadeMedida, float QtdMinima, float QtdMaxima, float QtdEstoque, string Tipo) {
            this.CadastroProdutoAsync(CodigoProduto, Nome, Preco, UnidadeMedida, QtdMinima, QtdMaxima, QtdEstoque, Tipo, null);
        }
        
        /// <remarks/>
        public void CadastroProdutoAsync(string CodigoProduto, string Nome, double Preco, string UnidadeMedida, float QtdMinima, float QtdMaxima, float QtdEstoque, string Tipo, object userState) {
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
                        QtdEstoque,
                        Tipo}, this.CadastroProdutoOperationCompleted, userState);
        }
        
        private void OnCadastroProdutoOperationCompleted(object arg) {
            if ((this.CadastroProdutoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CadastroProdutoCompleted(this, new CadastroProdutoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CadastroProdutoEstoque", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CadastroProdutoEstoque(int IdProduto, float QtdMinima, float QtdMaxima, float QtdEstoque) {
            object[] results = this.Invoke("CadastroProdutoEstoque", new object[] {
                        IdProduto,
                        QtdMinima,
                        QtdMaxima,
                        QtdEstoque});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CadastroProdutoEstoqueAsync(int IdProduto, float QtdMinima, float QtdMaxima, float QtdEstoque) {
            this.CadastroProdutoEstoqueAsync(IdProduto, QtdMinima, QtdMaxima, QtdEstoque, null);
        }
        
        /// <remarks/>
        public void CadastroProdutoEstoqueAsync(int IdProduto, float QtdMinima, float QtdMaxima, float QtdEstoque, object userState) {
            if ((this.CadastroProdutoEstoqueOperationCompleted == null)) {
                this.CadastroProdutoEstoqueOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCadastroProdutoEstoqueOperationCompleted);
            }
            this.InvokeAsync("CadastroProdutoEstoque", new object[] {
                        IdProduto,
                        QtdMinima,
                        QtdMaxima,
                        QtdEstoque}, this.CadastroProdutoEstoqueOperationCompleted, userState);
        }
        
        private void OnCadastroProdutoEstoqueOperationCompleted(object arg) {
            if ((this.CadastroProdutoEstoqueCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CadastroProdutoEstoqueCompleted(this, new CadastroProdutoEstoqueCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GerarPedido", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GerarPedido(string Solicitante, string Urgencia, string Motivo, string Tipo, double Valor) {
            object[] results = this.Invoke("GerarPedido", new object[] {
                        Solicitante,
                        Urgencia,
                        Motivo,
                        Tipo,
                        Valor});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void GerarPedidoAsync(string Solicitante, string Urgencia, string Motivo, string Tipo, double Valor) {
            this.GerarPedidoAsync(Solicitante, Urgencia, Motivo, Tipo, Valor, null);
        }
        
        /// <remarks/>
        public void GerarPedidoAsync(string Solicitante, string Urgencia, string Motivo, string Tipo, double Valor, object userState) {
            if ((this.GerarPedidoOperationCompleted == null)) {
                this.GerarPedidoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGerarPedidoOperationCompleted);
            }
            this.InvokeAsync("GerarPedido", new object[] {
                        Solicitante,
                        Urgencia,
                        Motivo,
                        Tipo,
                        Valor}, this.GerarPedidoOperationCompleted, userState);
        }
        
        private void OnGerarPedidoOperationCompleted(object arg) {
            if ((this.GerarPedidoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GerarPedidoCompleted(this, new GerarPedidoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GerarPedidoItem", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool GerarPedidoItem(string Cod, string Nome, double QtdEstoque, double QtdMaxima, double QtdMinima, string UnidadeMedida, double Solicitar, int IdPedido) {
            object[] results = this.Invoke("GerarPedidoItem", new object[] {
                        Cod,
                        Nome,
                        QtdEstoque,
                        QtdMaxima,
                        QtdMinima,
                        UnidadeMedida,
                        Solicitar,
                        IdPedido});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void GerarPedidoItemAsync(string Cod, string Nome, double QtdEstoque, double QtdMaxima, double QtdMinima, string UnidadeMedida, double Solicitar, int IdPedido) {
            this.GerarPedidoItemAsync(Cod, Nome, QtdEstoque, QtdMaxima, QtdMinima, UnidadeMedida, Solicitar, IdPedido, null);
        }
        
        /// <remarks/>
        public void GerarPedidoItemAsync(string Cod, string Nome, double QtdEstoque, double QtdMaxima, double QtdMinima, string UnidadeMedida, double Solicitar, int IdPedido, object userState) {
            if ((this.GerarPedidoItemOperationCompleted == null)) {
                this.GerarPedidoItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGerarPedidoItemOperationCompleted);
            }
            this.InvokeAsync("GerarPedidoItem", new object[] {
                        Cod,
                        Nome,
                        QtdEstoque,
                        QtdMaxima,
                        QtdMinima,
                        UnidadeMedida,
                        Solicitar,
                        IdPedido}, this.GerarPedidoItemOperationCompleted, userState);
        }
        
        private void OnGerarPedidoItemOperationCompleted(object arg) {
            if ((this.GerarPedidoItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GerarPedidoItemCompleted(this, new GerarPedidoItemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CompraDataSet", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet CompraDataSet(int IdPedido) {
            object[] results = this.Invoke("CompraDataSet", new object[] {
                        IdPedido});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void CompraDataSetAsync(int IdPedido) {
            this.CompraDataSetAsync(IdPedido, null);
        }
        
        /// <remarks/>
        public void CompraDataSetAsync(int IdPedido, object userState) {
            if ((this.CompraDataSetOperationCompleted == null)) {
                this.CompraDataSetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCompraDataSetOperationCompleted);
            }
            this.InvokeAsync("CompraDataSet", new object[] {
                        IdPedido}, this.CompraDataSetOperationCompleted, userState);
        }
        
        private void OnCompraDataSetOperationCompleted(object arg) {
            if ((this.CompraDataSetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CompraDataSetCompleted(this, new CompraDataSetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RetornaProduto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("BuscaProduto", IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("PRODUTO", IsNullable=false)]
        public Produto[] RetornaProduto() {
            object[] results = this.Invoke("RetornaProduto", new object[0]);
            return ((Produto[])(results[0]));
        }
        
        /// <remarks/>
        public void RetornaProdutoAsync() {
            this.RetornaProdutoAsync(null);
        }
        
        /// <remarks/>
        public void RetornaProdutoAsync(object userState) {
            if ((this.RetornaProdutoOperationCompleted == null)) {
                this.RetornaProdutoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRetornaProdutoOperationCompleted);
            }
            this.InvokeAsync("RetornaProduto", new object[0], this.RetornaProdutoOperationCompleted, userState);
        }
        
        private void OnRetornaProdutoOperationCompleted(object arg) {
            if ((this.RetornaProdutoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RetornaProdutoCompleted(this, new RetornaProdutoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RetornaComboTipo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("BuscaComboTipo", IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("TIPO", IsNullable=false)]
        public TipoCombo[] RetornaComboTipo() {
            object[] results = this.Invoke("RetornaComboTipo", new object[0]);
            return ((TipoCombo[])(results[0]));
        }
        
        /// <remarks/>
        public void RetornaComboTipoAsync() {
            this.RetornaComboTipoAsync(null);
        }
        
        /// <remarks/>
        public void RetornaComboTipoAsync(object userState) {
            if ((this.RetornaComboTipoOperationCompleted == null)) {
                this.RetornaComboTipoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRetornaComboTipoOperationCompleted);
            }
            this.InvokeAsync("RetornaComboTipo", new object[0], this.RetornaComboTipoOperationCompleted, userState);
        }
        
        private void OnRetornaComboTipoOperationCompleted(object arg) {
            if ((this.RetornaComboTipoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RetornaComboTipoCompleted(this, new RetornaComboTipoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RetornaEstoque", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("BuscaEstoque", IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("ESTOQUE", IsNullable=false)]
        public Estoque[] RetornaEstoque(string Tipo) {
            object[] results = this.Invoke("RetornaEstoque", new object[] {
                        Tipo});
            return ((Estoque[])(results[0]));
        }
        
        /// <remarks/>
        public void RetornaEstoqueAsync(string Tipo) {
            this.RetornaEstoqueAsync(Tipo, null);
        }
        
        /// <remarks/>
        public void RetornaEstoqueAsync(string Tipo, object userState) {
            if ((this.RetornaEstoqueOperationCompleted == null)) {
                this.RetornaEstoqueOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRetornaEstoqueOperationCompleted);
            }
            this.InvokeAsync("RetornaEstoque", new object[] {
                        Tipo}, this.RetornaEstoqueOperationCompleted, userState);
        }
        
        private void OnRetornaEstoqueOperationCompleted(object arg) {
            if ((this.RetornaEstoqueCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RetornaEstoqueCompleted(this, new RetornaEstoqueCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class Produto {
        
        private string codigo_ProdutoField;
        
        private string nome_ProdutoField;
        
        private string uM_ProdutoField;
        
        private double preco_ProdutoField;
        
        /// <remarks/>
        public string Codigo_Produto {
            get {
                return this.codigo_ProdutoField;
            }
            set {
                this.codigo_ProdutoField = value;
            }
        }
        
        /// <remarks/>
        public string Nome_Produto {
            get {
                return this.nome_ProdutoField;
            }
            set {
                this.nome_ProdutoField = value;
            }
        }
        
        /// <remarks/>
        public string UM_Produto {
            get {
                return this.uM_ProdutoField;
            }
            set {
                this.uM_ProdutoField = value;
            }
        }
        
        /// <remarks/>
        public double Preco_Produto {
            get {
                return this.preco_ProdutoField;
            }
            set {
                this.preco_ProdutoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Estoque {
        
        private string codigoProdutoField;
        
        private string nomeField;
        
        private double precoField;
        
        private double qtdEstoqueField;
        
        private double qtdMaximaField;
        
        private double qtdMinimaField;
        
        private string umField;
        
        /// <remarks/>
        public string CodigoProduto {
            get {
                return this.codigoProdutoField;
            }
            set {
                this.codigoProdutoField = value;
            }
        }
        
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
        public double Preco {
            get {
                return this.precoField;
            }
            set {
                this.precoField = value;
            }
        }
        
        /// <remarks/>
        public double QtdEstoque {
            get {
                return this.qtdEstoqueField;
            }
            set {
                this.qtdEstoqueField = value;
            }
        }
        
        /// <remarks/>
        public double QtdMaxima {
            get {
                return this.qtdMaximaField;
            }
            set {
                this.qtdMaximaField = value;
            }
        }
        
        /// <remarks/>
        public double QtdMinima {
            get {
                return this.qtdMinimaField;
            }
            set {
                this.qtdMinimaField = value;
            }
        }
        
        /// <remarks/>
        public string UM {
            get {
                return this.umField;
            }
            set {
                this.umField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TipoCombo {
        
        private string statusField;
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void CadastroProdutoEstoqueCompletedEventHandler(object sender, CadastroProdutoEstoqueCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CadastroProdutoEstoqueCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CadastroProdutoEstoqueCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GerarPedidoCompletedEventHandler(object sender, GerarPedidoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GerarPedidoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GerarPedidoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GerarPedidoItemCompletedEventHandler(object sender, GerarPedidoItemCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GerarPedidoItemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GerarPedidoItemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void CompraDataSetCompletedEventHandler(object sender, CompraDataSetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CompraDataSetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CompraDataSetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void RetornaProdutoCompletedEventHandler(object sender, RetornaProdutoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RetornaProdutoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RetornaProdutoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Produto[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Produto[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void RetornaComboTipoCompletedEventHandler(object sender, RetornaComboTipoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RetornaComboTipoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RetornaComboTipoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoCombo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoCombo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void RetornaEstoqueCompletedEventHandler(object sender, RetornaEstoqueCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RetornaEstoqueCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RetornaEstoqueCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Estoque[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Estoque[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591