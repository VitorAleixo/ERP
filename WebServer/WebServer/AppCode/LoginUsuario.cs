using System;
using System.Collections.Generic;
using System.Linq;
using MySql;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebServer.AppCode
{
    public class LoginUsuario
    {
        public int valor { get; set; } = 0;

        public void Logar(string Usuario, string Senha)
        {
            MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;password=root;database=SistemaDeEstoque");
            connectionString.Open();
            MySqlCommand command = new MySqlCommand("SELECT Senha FROM Cliente WHERE Usuario = '" + Usuario + "'", connectionString);
            MySqlDataReader rdr = command.ExecuteReader();

            if (rdr.Read())
            {
                if (Senha == rdr.GetString("Senha"))
                {
                    valor = 1;
                    command.Dispose();
                }
                else
                {
                    valor = 0;
                    command.Dispose();
                }
            }
            else
            {
                valor = 0;
                command.Dispose();
            }
            connectionString.Close();
        }
    
    }
}