using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.AppCode
{
    class BuscarTipo
    {
        private static String _buscaTipo;

        public static String BuscaTipo
        {
            get { return BuscarTipo._buscaTipo; }
            set { BuscarTipo._buscaTipo = value; }
        }
    }
}

