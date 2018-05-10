using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServerAmx.AppCode;

namespace WebServerAmx.WebService
{
    /// <summary>
    /// Summary description for Almoxarifado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Almoxarifado : System.Web.Services.WebService
    {

        [WebMethod]
        public int CadastroProduto(
                  string CodigoProduto
                , string Nome
                , double Preco
                , string UnidadeMedida
                , float QtdMinima
                , float QtdMaxima
                , float QtdEstoque
                , string Tipo)

        {
            CadastroProduto cadastroProd = new CadastroProduto();
            return cadastroProd.GravarProduto(CodigoProduto, Nome, Preco, UnidadeMedida, QtdMinima, QtdMaxima, QtdEstoque, Tipo);

        }

        [WebMethod]
        public bool CadastroProdutoEstoque(
                int IdProduto
              , float QtdMinima
              , float QtdMaxima
              , float QtdEstoque)

        {
            CadastroProduto cadastroProd = new CadastroProduto();
            cadastroProd.GravarProdutoEstoque(IdProduto, QtdMinima, QtdMaxima, QtdEstoque);

            if (cadastroProd.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [WebMethod]
        public int GerarPedido(
                  string Solicitante
                , string Urgencia
                , string Motivo
                , string Tipo
                , double Valor)
        {
            CadastroGerarPedido gerarpedido = new CadastroGerarPedido();
            return gerarpedido.GravarPedido(Solicitante, Urgencia, Motivo, Tipo, Valor);
        }

        [WebMethod]
        public bool GerarPedidoItem(
                  string Cod
                , string Nome
                , double QtdEstoque
                , double QtdMaxima
                , double QtdMinima
                , string UnidadeMedida
                , double Solicitar
                , int IdPedido)
        {
            CadastroGerarPedido gerarpedido = new CadastroGerarPedido();
            gerarpedido.GravarPedidoItens(Cod, Nome, QtdEstoque, QtdMaxima, QtdMinima, UnidadeMedida, Solicitar, IdPedido);
            if (gerarpedido.valorItem == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public DataSet CompraDataSet(int IdPedido)
        {
            DataSetCompra dsCompra = new DataSetCompra();
            return dsCompra.RetornarDataSet(IdPedido);
        }

        [WebMethod]
        public BuscaProduto.ListaProduto RetornaProduto()
        {
            BuscaProduto.Program.RetornarProduto();

            return BuscaProduto.Program.list;

        }

        [WebMethod]
        public BuscaComboTipo.ListaTipoCombo RetornaComboTipo()
        {
            BuscaComboTipo.Program.RetornaComboTipo();
            return BuscaComboTipo.Program.list;
        }

        [WebMethod]
        public BuscaEstoque.ListaEstoque RetornaEstoque(string Tipo)
        {
            BuscaEstoque.Program.RetornarEstoque(Tipo);

            return BuscaEstoque.Program.list;
        }
    }
}
