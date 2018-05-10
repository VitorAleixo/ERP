using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServerGrc.AppCode;

namespace WebServerGrc.WebService
{
    /// <summary>
    /// Summary description for Gerencia
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Gerencia : System.Web.Services.WebService
    {

        [WebMethod]
        public bool Aprovar(
                int IdPedido
                )
        {
            GerenciaPedido atualizar = new GerenciaPedido();
            atualizar.Aprovar(IdPedido);
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
        public bool Reprovar(
                  int IdPedido
                  )
        {
            GerenciaPedido atualizar = new GerenciaPedido();
            atualizar.Reprovar(IdPedido);
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
        public BuscaOrcamentos.ListaOrcamento RetornaOrcamento()
        {
            BuscaOrcamentos.Program.RetornaOrcamento();

            return BuscaOrcamentos.Program.list;

        }

        [WebMethod]
        public string RetornaVendedor(
         int IdVendedor)
        {
            BuscaVendedor vendedor = new BuscaVendedor();
            vendedor.Vendedor(IdVendedor);

            return vendedor.VendedorStr;
        }

        [WebMethod]
        public BuscaOrcamentoDados.ListaOrcamentoDados RetornaDadosOrcamento(int IdPedido)
        {
            BuscaOrcamentoDados.Program.RetornaOrcamentoDados(IdPedido);

            return BuscaOrcamentoDados.Program.list;
        }

    }
}
