using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServerAmx.AppCode
{
    public class DataSetCompra
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;

        public DataSet RetornarDataSet(int IdPedido)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "dbo.RelatorioSolicitacao";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDPEDIDO", SqlDbType.Int).Value = IdPedido;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "Solicitacao");
                return (ds);
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