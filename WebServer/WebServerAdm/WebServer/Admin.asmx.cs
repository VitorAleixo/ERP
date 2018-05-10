using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServerAdm.AppCode;

namespace WebServerAdm.WebServer
{
    /// <summary>
    /// Summary description for Admin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Admin : System.Web.Services.WebService
    {

        [WebMethod]
        public int CadastroUsuario(
                            string Nome
                       , string Funcao
                       , string Departamento
                       , string Usuario
                       , string Senha
                       , DateTime DataCriacao)
        {
            CadastroUsuario cadastroUser = new CadastroUsuario();
            return cadastroUser.GravarUsuario(Nome, Funcao, Departamento, Usuario, Senha, DataCriacao);

        }

        [WebMethod]
        public bool CadastroPermissoesUsuario(
                    string Departamento
                  , int IdUsuario
                  , string Nome)
        {
            CadastroUsuario cadastrouser = new CadastroUsuario();
            cadastrouser.GravarPermissoes(Departamento, IdUsuario, Nome);
            if (cadastrouser.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public BuscaUsuario.ListaUsuario RetornaUsuario()
        {
            BuscaUsuario.Program.RetornarUsuario();

            return BuscaUsuario.Program.list;
        }
    }
}
