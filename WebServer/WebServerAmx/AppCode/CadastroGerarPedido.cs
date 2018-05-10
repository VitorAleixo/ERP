using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServerAmx.AppCode
{
    public class CadastroGerarPedido
    {
        public int valorItem { get; set; }
        public int valor { get; set; }
        private SqlConnection con = null;
        SqlCommand cmd = null;

        public int GravarPedido(
                    string Solicitante
                  , string Urgencia
                  , string Motivo
                  , string Tipo
                  , double Valor)
        {
            try
            {

                int IdPedido = 0;
                con = ConnectionFactory.getConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO Pedido(Solicitante, Urgencia, Motivo, DataCriacao, Status, Tipo, Valor) VALUES " +
                "(@Solicitante, @Urgencia, @Motivo, GETDATE(), @Status, @Tipo, @Valor ); SELECT @@IDENTITY;", con);

                cmd.Parameters.AddWithValue("@Solicitante", Solicitante);
                cmd.Parameters.AddWithValue("@Urgencia", Urgencia);
                cmd.Parameters.AddWithValue("@Motivo", Motivo);
                cmd.Parameters.AddWithValue("@Status", "PENDENTE");
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@Valor", Valor);
                IdPedido = Convert.ToInt32(cmd.ExecuteScalar());

                return IdPedido;
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
            }
        }

        public void GravarPedidoItens(
                 string Cod
               , string Nome
               , double QtdEstoque
               , double QtdMaxima
               , double QtdMinima
               , string UnidadeMedida
               , double Solicitar
               , int IdPedido)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();
                cmd = new SqlCommand("INSERT INTO PedidoItem(Cod, Nome, QtdEstoque, QtdMaxima, QtdMinima, UnidadeMedida , Solicitar, IdPedido) VALUES " +
                "(@Cod, @Nome, @QtdEstoque, @QtdMinima, @QtdMaxima, @UnidadeMedida, @Solicitar, @IdPedido );", con);

                cmd.Parameters.AddWithValue("@Cod", Cod);
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@QtdEstoque", QtdEstoque);
                cmd.Parameters.AddWithValue("@QtdMaxima", QtdMaxima);
                cmd.Parameters.AddWithValue("@QtdMinima", QtdMinima);
                cmd.Parameters.AddWithValue("@UnidadeMedida", UnidadeMedida);
                cmd.Parameters.AddWithValue("@Solicitar", Solicitar);
                cmd.Parameters.AddWithValue("@IdPedido", IdPedido);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    valorItem = 1;

                }
                else
                {
                    valorItem = 0;
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
            }
        }
    }
}