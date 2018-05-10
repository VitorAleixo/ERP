using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class BuscaDepartamento
    {

        private SqlCommand command = null;
        private SqlDataReader rdr = null;
        private SqlConnection con = null;

        public string Setor { get; set; }

        public string BuscaSetor(string Usuario)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT Departamento FROM Usuario WHERE Usuario = @Usuario;", con);

                cmd.Parameters.AddWithValue("@Usuario", Usuario);


                rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        Setor = rdr["Departamento"].ToString();
                    }

                    return Setor;
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