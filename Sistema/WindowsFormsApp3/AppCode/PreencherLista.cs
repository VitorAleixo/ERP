using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.AppCode
{
    class PreencherLista
    {
        private static ArrayList listaPreenchida;

        public static ArrayList Preencher
        {
            get { return PreencherLista.listaPreenchida; }
            set { PreencherLista.listaPreenchida = value; }
        }
    }
}
