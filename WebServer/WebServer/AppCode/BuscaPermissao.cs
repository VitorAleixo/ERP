using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class BuscaPermissao
    {
        private SqlCommand cmd = null;
        private SqlDataReader rdr = null;
        private SqlConnection con = null;

        public string Permissao { get; set; }

        public string BuscaPerm(string Usuario, string Departamento)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();

                cmd = new SqlCommand("SELECT "+Departamento+" " +
                    "FROM Permissoes WHERE Usuario = @Usuario " +
                    "AND  " + Departamento + " = @STATUS ;", con);

                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@STATUS", "OK");

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Permissao = rdr[Departamento].ToString();
                }

                return Permissao;
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