using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class BuscaCliente
    {
        private static string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";
        private static SqlConnection con = null;
        private static SqlDataReader rdr = null;
        private static string comando = null;
        private static SqlCommand command = null;

        private string Nome;
        private string Funcao;
        private string Departamento;
        private string Usuario;
        private string DataCriacao;

        public static List<BuscaCliente> lista { get; set; }

        public static List<BuscaCliente> RetornarCliente()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                comando = "SELECT Nome, Funcao, Departamento, Usuario, DataCriacao FROM Cliente;";

                command = new SqlCommand(comando, con);
                rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    lista.Add(new BuscaCliente
                    {
                        Nome = rdr.GetString(0),
                        Funcao = rdr.GetString(1),
                        Departamento = rdr.GetString(2),
                        Usuario = rdr.GetString(3),
                        DataCriacao = rdr.GetDateTime(4).ToString("dd/MM/yyyy")

                    });
                }
                return lista;
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