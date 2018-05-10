using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServer.AppCode
{
    [Serializable]
    public class BuscaOrcamentoDados
    {
        [XmlRoot("BuscaOrcamentoDados")]
        public class ListaOrcamentoDados
        {
            public ListaOrcamentoDados() { Items = new List<OrcamentoDados>(); }
            [XmlElement("ORCAMENTODADOS")]
            public List<OrcamentoDados> Items { get; set; }



        }
        public class OrcamentoDados
        {
            [XmlElement("Cod")]
            public String Cod { get; set; }

            [XmlElement("Nome")]
            public String Nome { get; set; }

            [XmlElement("UnidadeMedida")]
            public String UnidadeMedida { get; set; }

            [XmlElement("Solicitar")]
            public Double Solicitar { get; set; }


        }

        public static class Program
        {


            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static string comando = null;
            private static SqlCommand command = null;
            public static ListaOrcamentoDados list { get; set; }


            public static ListaOrcamentoDados RetornaOrcamentoDados(int IdPedido)
            {
                try
                {
                    con = ConnectionFactory.getConnection();
                    con.Open();

                    SqlCommand comando = new SqlCommand("SELECT Cod, Nome, UnidadeMedida, Solicitar FROM PedidoItem WHERE IdPedido = @IdPedido;", con);
                    comando.Parameters.AddWithValue("@IdPedido", IdPedido);

                    XmlSerializer ser = new XmlSerializer(typeof(ListaOrcamentoDados));
                    list = new ListaOrcamentoDados();

                  
                        using (var rdr = comando.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                list.Items.Add(new OrcamentoDados
                                {
                                    Cod = rdr.GetString(0),
                                    Nome = rdr.GetString(1),
                                    UnidadeMedida = rdr.GetString(2),
                                    Solicitar = rdr.GetDouble(3),           
                                });
                            }
                        }
                        comando.Dispose();

                    return list;

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
}