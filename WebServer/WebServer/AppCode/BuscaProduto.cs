using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServer.AppCode
{

    [Serializable]

    public class BuscaProduto
    {
        private static string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";
        private static SqlConnection con = null;
        private static SqlDataReader rdr = null;
        private static string comando = null;
        private static SqlCommand command = null;

        private string Codigo;
        private string NomeProduto;
        private double Preco;
        private string UM;

        [XmlArray()]
        public static List<BuscaProduto> lista { get; set; }
          
        public static  List<BuscaProduto> RetornarProduto()
        {
            try
            {
               

                con = new SqlConnection(connectionString);
                con.Open();

                comando = "SELECT CodigoProduto, Nome, UnidadeMedida, Preco FROM Produto;";

                
                using (var cmd = con.CreateCommand())
                {
                    lista = new List<BuscaProduto>();
                    cmd.CommandText = comando.ToString();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(new BuscaProduto
                            {
                                Codigo = rdr.GetString(0),
                                NomeProduto = rdr.GetString(1),
                                UM = rdr.GetString(2),
                                Preco = rdr.GetDouble(3),
                            });
                        }
                    }
                    cmd.Dispose();
                    

                }

                return lista;
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