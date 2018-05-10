using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class BuscaEstoque
    {
        private string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";
        private SqlConnection con = null;
        private SqlDataReader rdr = null;
        private string comando = null;
        private SqlCommand command = null;

        public static List<BuscaEstoque> lista { get; set; }

        public static List<BuscaEstoque> RetornarEstoque()
        {
            return lista;
        }
    }
}