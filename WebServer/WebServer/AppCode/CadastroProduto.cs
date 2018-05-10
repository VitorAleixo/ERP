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
        private SqlCommand cmd = null;
        private SqlConnection con = null;
        private SqlDataReader rdr = null;


        public int GravarProduto(
                      string CodigoProduto
                    , string Nome
                    , string UnidadeMedida
                    , float QtdMinima
                    , float QtdMaxima
                    , float QtdEstoque
                    , string Tipo)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();
                int IdProduto = 0;
                cmd = new SqlCommand("SELECT CodigoProduto FROM Produto WHERE CodigoProduto = @Cod;", con);

                cmd.Parameters.AddWithValue("@Cod", CodigoProduto);

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    valor = 0;
                    rdr.Close();
                }
                else
                {
                    rdr.Close();

                    cmd = new SqlCommand("INSERT INTO Produto(CodigoProduto, Nome, UnidadeMedida, Tipo)" +
                        "VALUES (@Cod, @Nome,  @UnidadeMedida, @Tipo); SELECT @@IDENTITY", con);

                    cmd.Parameters.AddWithValue("@Cod", CodigoProduto);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@UnidadeMedida", UnidadeMedida);
                    cmd.Parameters.AddWithValue("@Tipo", Tipo);

                    IdProduto = Convert.ToInt32(cmd.ExecuteScalar());

                }
                return IdProduto;
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
                    if (cmd != null)
                    {
                        cmd.Dispose();
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
        public void GravarProdutoEstoque(
                   int IdProduto
                 , float QtdMinima
                 , float QtdMaxima
                 , float QtdEstoque)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO Estoque(IdProduto, QtdMinima, QtdMaxima, QtdEstoque) VALUES " +
                "(@IdProduto, @QtdMinima, @QtdMaxima, @QtdEstoque);", con);


                cmd.Parameters.AddWithValue("@IdProduto", IdProduto);
                cmd.Parameters.AddWithValue("@QtdEstoque", QtdEstoque);
                cmd.Parameters.AddWithValue("@QtdMaxima", QtdMaxima);
                cmd.Parameters.AddWithValue("@QtdMinima", QtdMinima);

                if (cmd.ExecuteNonQuery() == 1)
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
                    if (cmd != null)
                    {
                        cmd.Dispose();
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