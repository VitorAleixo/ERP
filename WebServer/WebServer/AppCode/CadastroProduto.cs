using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class CadastroProduto
    {
        public int valor { get; set; } = 0;
        private string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";
        private string comando = null;
        private SqlCommand command = null;
        private SqlConnection con = null;

        public void GravarProduto(
                      string CodigoProduto
                    , string Nome
                    , float Preco
                    , string UnidadeMedida
                    , float QtdMinima
                    , float QtdMaxima
                    , float QtdEstoque)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                comando = "INSERT INTO Produto(CodigoProduto, Nome, Preco, UnidadeMedida, QtdMinima, QtdMaxima, QtdEstoque)" +
                        "VALUES ('" + CodigoProduto + "', '" + Nome + "', '" + Preco.ToString().Replace(",", ".") + "', '" + UnidadeMedida + "', '" + QtdMinima + "', '" + QtdMaxima + "', '" + QtdEstoque + "');";

                command = new SqlCommand(comando, con);

                if (command.ExecuteNonQuery() == 1)
                {
                    valor = 1;
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