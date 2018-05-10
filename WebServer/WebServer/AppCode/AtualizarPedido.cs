using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class AtualizarPedido
    {

        public int valor { get; set; } = 0;
        private SqlCommand command = null;
        private SqlConnection con = null;

        public void Atualizar(int IdPedido)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Pedido SET Status = 'ORCAMENTO' WHERE IdPedido = @IdPedido ", con);

                cmd.Parameters.AddWithValue("@IdPedido", IdPedido);
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
            }
        }
    }
}