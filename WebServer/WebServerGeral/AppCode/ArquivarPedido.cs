﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebServerGeral.AppCode;

namespace WebServer.AppCode
{
    public class ArquivarPedido
    {
        public int valor { get; set; } = 0;
        private SqlCommand cmd = null;
        private SqlConnection con = null;

        public void Arquivar(int IdPedido)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();

                cmd = new SqlCommand("UPDATE Pedido SET Status = 'ARQUIVADO' WHERE IdPedido = @IdPedido ", con);

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