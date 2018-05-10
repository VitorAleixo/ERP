using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServer.AppCode;

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

        [WebMethod]
        public bool LoginSistema(string usuario, string senha)
        {
            Criptografia c = new Criptografia();
            string senhaCriptografada = c.SHA256(senha);

            if (usuario == "vitor" && senhaCriptografada == "8f7957e71c2b39d1ee8d93cf9eaf44b09f7cd207711f5c0273951b358713efda")
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
