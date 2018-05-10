using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServerAdm.AppCode
{
    public class VerificarPermissoes
    {

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader rdr = null;
  

        public bool PermissoesAdm(string Usuario, string Departamento)
        {
            string Permissao = "";
            try
            {
                Departamento.ToUpper();
                con = ConnectionFactory.getConnection();
                con.Open();

                cmd = new SqlCommand("SELECT "+Departamento+" FROM Permissoes WHERE Usuario = @Usuario ;", con);

                cmd.Parameters.AddWithValue("@Usuario", Usuario);

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Permissao = rdr[Departamento].ToString();
                }

                if (Permissao == "OK")
                {
                    return true;
                }
                else
                {
                    return false;
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