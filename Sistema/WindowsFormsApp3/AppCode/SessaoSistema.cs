using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.AppCode
{
    class SessaoSistema
    {
        private static String _nomeUsuario;

        public static String NomeUsuario
        {
            get { return SessaoSistema._nomeUsuario; }
            set { SessaoSistema._nomeUsuario = value; }
        }
    }
}
