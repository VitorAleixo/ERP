using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServerCmp.AppCode;

namespace WebServerCmp.WebService
{
    /// <summary>
    /// Summary description for Compras
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Compras : System.Web.Services.WebService
    {

        [WebMethod]
        public bool GravarOrcamento(
                     int IdPedido
                   , string Tipo
                   , string DataEmissao
                   , string Observacoes
                   , string Vendedor
                   , string PrazoEntrega
                   , string CondicaoPag
                    , double ValorAdicional
                    , double Valor
                   , int QtdItens)
        {
            CadastrarOrcamento gravarOrcamento = new CadastrarOrcamento();
            gravarOrcamento.GravarOrcamento(IdPedido, Tipo, DataEmissao, Observacoes, Vendedor, PrazoEntrega, CondicaoPag, ValorAdicional, Valor, QtdItens);
            if (gravarOrcamento.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool CadastroFornecedor(
               string Nome
             , string CPF
             , string CEP
             , string Endereco
             , string Bairro
             , string Cidade
             , string Complemento
             , string Estado
             , string Complemento2
             , string Numero
             , string Telefone
             , string Telefone2
             , string EMAIL)
        {
            CadastroFornecedor cadastroForn = new CadastroFornecedor();
            cadastroForn.GravarFornecedor(Nome, CPF, CEP, Endereco, Bairro, Cidade, Complemento, Estado, Complemento2, Numero, Telefone, Telefone2, EMAIL);

            if (cadastroForn.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool Arquivar(
                   int IdPedido
                   )
        {
            ArquivarPedido arquivar = new ArquivarPedido();
            arquivar.Arquivar(IdPedido);
            if (arquivar.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool Atualizar(
          int IdPedido
          )
        {
            AtualizarPedido atualizar = new AtualizarPedido();
            atualizar.Atualizar(IdPedido);
            if (atualizar.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool AtualizarGerar(
               int IdPedido
               )
        {
            AtualizarPedido atualizar = new AtualizarPedido();
            atualizar.AtualizarGerar(IdPedido);
            if (atualizar.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public DataSet OrcamentoDataSet(int IdPedido)
        {
            DataSetOrcamento dsOrcamento = new DataSetOrcamento();
            return dsOrcamento.RetornarDataSet(IdPedido);
        }

        [WebMethod]
        public DataSet CompraCompletaDataSet(int IdPedido)
        {
            DataSetCompraCompleta dsCompraCompleta = new DataSetCompraCompleta();
            return dsCompraCompleta.RetornarDataSet(IdPedido);
        }

        [WebMethod]
        public BuscaSolicitacao.ListaSolicitacao RetornarSolicitacao()
        {
            BuscaSolicitacao.Program.RetornaSolicitacao();

            return BuscaSolicitacao.Program.list;
        }

        [WebMethod]
        public BuscaSolicitacaoItem.ListaSolicitacaoItem RetornaSolicitacaoItem(int IdPedido)
        {
            BuscaSolicitacaoItem.Program.RetornaSolicitacaoItem(IdPedido);


            return BuscaSolicitacaoItem.Program.list;
        }

        [WebMethod]
        public BuscaSolicitacaoDeCompra.ListaSolicitacoes RetornaSolicitacaoDeCompra()
        {
            BuscaSolicitacaoDeCompra.Program.RetornaSolicitacoes();

            return BuscaSolicitacaoDeCompra.Program.list;

        }

        [WebMethod]
        public BuscaFornecedor.ListaFornecedor RetornaFornecedor()
        {
            BuscaFornecedor.Program.RetornarFornecedor();

            return BuscaFornecedor.Program.list;
        }

        [WebMethod]
        public BuscaCombos.ListaFornecedorCombo RetornaComboFornecedor()
        {
            BuscaCombos.Program.RetornarComboFornecedor();


            return BuscaCombos.Program.list;
        }
    }
}
