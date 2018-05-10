using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class CadastrarOrcamento
    {
        public int valor { get; set; } = 0;
        private SqlCommand cmd = null;
        private SqlConnection con = null;

        public void GravarOrcamento(
                      int IdPedido
                    , string Tipo
                    , string DataEmissao
                    , string Observacoes
                    , string Vendedor
                    , string PrazoEntrega
                    , string CondicaoPag
                    , double ValorTotal
                    , int QtdItens)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();

                cmd = new SqlCommand("INSERT INTO Orcamento(IdPedido, Tipo, DataEmissao, Observacoes, Vendedor, PrazoEntrega, CondicaoPag, ValorTotal, QtdItens) VALUES " +
                    "(@IdPedido, @Tipo, GETDATE(), @Observacoes, @Vendedor, @PrazoEntrega, @CondicaoPag, @ValorTotal, @QtdItens);", con);

                cmd.Parameters.AddWithValue("@IdPedido", IdPedido);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@DataEmissao", DataEmissao);
                cmd.Parameters.AddWithValue("@Observacoes", Observacoes);
                cmd.Parameters.AddWithValue("@Vendedor", Vendedor);
                cmd.Parameters.AddWithValue("@PrazoEntrega", PrazoEntrega);
                cmd.Parameters.AddWithValue("@CondicaoPag", CondicaoPag);
                cmd.Parameters.AddWithValue("@ValorTotal", ValorTotal);
                cmd.Parameters.AddWithValue("@QtdItens", QtdItens);

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
            }
        }
    }
}