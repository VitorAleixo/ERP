using System;
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

        private string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";
        private SqlConnection con = null;
        private SqlDataReader rdr = null;
        private string comando = null;
        private SqlCommand command = null;

        public void Logar(string Usuario, string Senha)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                comando = "SELECT Senha FROM Usuario WHERE Usuario = '" + Usuario + "';";
                command = new SqlCommand(comando, con);
                rdr = command.ExecuteReader();

                if (rdr.Read())
                {
                    if (Senha == rdr["Senha"].ToString())
                    {
                        valor = 1;
                    }
                    else
                    {
                        valor = 0;
                    }
                }
                else
                {
                    valor = 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                try
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                try
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                try
                {
                    if (command != null)
                    {
                        command.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        }
    }
}