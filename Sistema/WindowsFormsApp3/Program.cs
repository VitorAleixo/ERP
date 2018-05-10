using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.AppCode;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin f = new frmLogin();

            while (f.variavel != 0)
            {
                f.ShowDialog();

                if (f.validar)
                {
                    localhost.Login login = new localhost.Login();
                    string usuario = SessaoSistema.NomeUsuario;
                    string setor = login.RetornaSetor(usuario);

                    login.RetornaSetor(usuario);

                    if (login.RetornaSetor(usuario) == "ADMIN")
                    {
                        Application.Run(new frmPrincipalAdmin());
                    }
                    else
                    {
                        Application.Run(new frmPrincipalSelecionar());
                    }

                }

                f.LimparCampos();
            }
        }
    }
}
