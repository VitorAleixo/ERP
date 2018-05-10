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
            rdr.Close();
            connectionString.Close();
        }

        public void SetStatus(string Usuario)
        {
            MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;password=root;database=SistemaDeEstoque");
            connectionString.Open();
            MySqlCommand command = new MySqlCommand("SELECT Id FROM Cliente WHERE Usuario = '" + Usuario + "'", connectionString);
            MySqlDataReader rdr = command.ExecuteReader();

            if (rdr.Read())
            {
                int idUsuario = rdr.GetInt32("Id");
                command.Dispose();

                command = new MySqlCommand(" UPDATE Cliente SET Status = '1' WHERE Id = '"+ idUsuario + "'", connectionString);
                command.ExecuteNonQuery();
                command.Dispose();               
            }
            rdr.Close();
            connectionString.Close();
        }

        public void SetStatusSair(string Usuario)
        {
            MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;password=root;database=SistemaDeEstoque");
            connectionString.Open();
            MySqlCommand command = new MySqlCommand("SELECT Id FROM Cliente WHERE Status = '1'", connectionString);
            MySqlDataReader rdr = command.ExecuteReader();

            if (rdr.Read())
            {
                int idUsuario = rdr.GetInt32("Id");
                command.Dispose();

                command = new MySqlCommand(" UPDATE Cliente SET Status = 0 WHERE Id '" + idUsuario + "'", connectionString);
                command.Dispose();
            }
            rdr.Close();
            connectionString.Close();
        }

        public void LimparStatus()
        {
            MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;password=root;database=SistemaDeEstoque");
            connectionString.Open();
            MySqlCommand command = new MySqlCommand("UPDATE Cliente SET Status = 0", connectionString);
            command.ExecuteNonQuery();
            command.Dispose();
            connectionString.Close();
        }
    }
}