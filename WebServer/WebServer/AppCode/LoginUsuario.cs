﻿using System;
using System.Collections.Generic;
using System.Linq;
using MySql;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace WebServer.AppCode
{
    public class LoginUsuario
    {
        public int valor { get; set; } = 0;

        public string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";

        public void Logar(string Usuario, string Senha)
        {
           
            //MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;password=root;database=SistemaDeEstoque");
            //connectionString.Open();
            //MySqlCommand command = new MySqlCommand("SELECT Senha FROM Cliente WHERE Usuario = '" + Usuario + "'", connectionString);
            //MySqlDataReader rdr = command.ExecuteReader();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string comando = "SELECT Senha FROM Cliente WHERE Usuario = '" + Usuario + "';";
            SqlCommand command = new SqlCommand(comando, con);
            SqlDataReader rdr = command.ExecuteReader();

            if (rdr.Read())
            {
                //rdr.GetString("Senha").ToString()
                if (Senha == rdr["Senha"].ToString())
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
            //connectionString.Close();
            con.Close();
        }


    }
}