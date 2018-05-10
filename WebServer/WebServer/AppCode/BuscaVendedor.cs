using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class BuscaVendedor
    {
        private SqlCommand command = null;
        private SqlDataReader rdr = null;
        private SqlConnection con = null;

        public string VendedorStr { get; set; }

        public string Vendedor(int IdVendedor)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT Nome FROM Fornecedor WHERE IdFornecedor = @IdVendedor;", con);

                cmd.Parameters.AddWithValue("@IdVendedor", IdVendedor);


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    VendedorStr = rdr["Nome"].ToString();
                }

                return VendedorStr;
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
