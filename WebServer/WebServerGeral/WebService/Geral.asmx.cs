using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServer.AppCode;
using WebServerGeral.AppCode;

namespace WebServerGeral.WebService
{
    /// <summary>
    /// Summary description for Geral
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Geral : System.Web.Services.WebService
    {

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
    }
}
