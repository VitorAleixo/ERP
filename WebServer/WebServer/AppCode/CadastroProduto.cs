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
        private string comando2 = null;
        private SqlCommand command2 = null;
        private string cmd = null;
        private SqlCommand cmdo = null;
        private SqlConnection con = null;
        private SqlDataReader rdr = null;

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

                cmd = "SELECT * FROM Produto WHERE CodigoProduto = '" + CodigoProduto + "';";
                cmdo = new SqlCommand(cmd, con);

                rdr = cmdo.ExecuteReader();

                if (rdr.Read())
                {
                    valor = 0;
                    rdr.Close();
                }
                else
                {
                    rdr.Close();
                    comando = "INSERT INTO Produto(CodigoProduto, Nome, Preco, UnidadeMedida)" +
                        "VALUES ('" + CodigoProduto + "', '" + Nome + "', '" + Preco.ToString().Replace(",", ".") + "', '" + UnidadeMedida + "');";

                    command = new SqlCommand(comando, con);

                    comando2 = "INSERT INTO Estoque(IdProduto, QtdMinima, QtdMaxima, QtdEstoque)" +
                            "VALUES ((SELECT MAX(IdProduto) FROM Produto), '" + QtdMinima + "', '" + QtdMaxima + "', '" + QtdEstoque + "');";

                    command2 = new SqlCommand(comando2, con);

                    if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                    {
                        valor = 1;
                    }
                    else
                    {
                        valor = 0;
                    }
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
                try
                {
                    if (command2 != null)
                    {
                        command2.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                try
                {
                    if (cmdo != null)
                    {
                        cmdo.Dispose();
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
            }
        }
    }
}