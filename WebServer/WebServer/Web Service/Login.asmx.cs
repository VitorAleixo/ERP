using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServer.Web_Service
{
    /// <summary>
    /// Summary description for Login
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Login : System.Web.Services.WebService
    {
        //CONEXAO E REQUISIÇÂO AQUI NO WEBSERVICE
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
            
        }

        [WebMethod]
        public int Calcular(int i , int j)
        {
             return i + j;

        }
        [WebMethod]
        public bool LoginSistema(string usuario, string senha)
        {
            bool resultado;
            if (usuario == "vitor" && senha == "123")
            {
                return resultado = true;
            }
            else
            {
                return resultado =  false;
            }


        }
    }
}
