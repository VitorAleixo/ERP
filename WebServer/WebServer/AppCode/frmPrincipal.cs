using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class frmPrincipal
    {

        public string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";
        public string Setor{ get; set; }

        public string BuscaSetor(string Usuario)
        {
            //MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;password=root;database=SistemaDeEstoque");
            //connectionString.Open();
            //MySqlCommand command = new MySqlCommand("SELECT Senha FROM Cliente WHERE Usuario = '" + Usuario + "'", connectionString);
            //MySqlDataReader rdr = command.ExecuteReader();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string comando = "SELECT Departamento FROM Cliente WHERE Usuario = '" + Usuario + "';";
            SqlCommand command = new SqlCommand(comando, con);
            SqlDataReader rdr = command.ExecuteReader();
            if (rdr.Read())
            {
                Setor = rdr["Departamento"].ToString();
            }
                return Setor;

        }
    }
}