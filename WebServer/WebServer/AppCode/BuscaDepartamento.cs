using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class BuscaDepartamento
    {

        private string comando = null;
        private SqlCommand command = null;
        private SqlDataReader rdr = null;
        private SqlConnection con = null;

        private string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";
        public string Setor { get; set; }

        public string BuscaSetor(string Usuario)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                comando = "SELECT Departamento FROM Cliente WHERE Usuario = '" + Usuario + "';";
                command = new SqlCommand(comando, con);
                rdr = command.ExecuteReader();

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