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
        private SqlCommand command = null;
        private SqlCommand command2 = null;
        private SqlCommand cmdo = null;
        private SqlConnection con = null;
        private SqlDataReader rdr = null;
 

        public int GravarProduto(
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
                con = ConnectionFactory.getConnection();
                con.Open();
                int IdProduto = 0;
                SqlCommand cmd = new SqlCommand("SELECT CodigoProduto FROM Produto WHERE CodigoProduto = @Cod;",con);

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
                  
                    SqlCommand comando = new SqlCommand( "INSERT INTO Produto(CodigoProduto, Nome, Preco, UnidadeMedida)" +
                        "VALUES (@Cod, @Nome, @Preco , @UnidadeMedida); SELECT @@IDENTITY",con);

                    comando.Parameters.AddWithValue("@Cod", CodigoProduto);
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Preco", Preco.ToString().Replace(",", "."));
                    comando.Parameters.AddWithValue("@UnidadeMedida", UnidadeMedida);


                    IdProduto = Convert.ToInt32(comando.ExecuteScalar());      
                  
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Estoque(IdProduto, QtdMinima, QtdMaxima, QtdEstoque) VALUES " +
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