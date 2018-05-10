using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServerAmx.AppCode
{

    [Serializable]
    public class BuscaProduto
    {
        [XmlRoot("BuscaProduto")]
        public class ListaProduto
        {
            public ListaProduto() { Items = new List<Produto>(); }
            [XmlElement("PRODUTO")]
            public List<Produto> Items { get; set; }



        }
        public class Produto
        {
            [XmlElement("Codigo_Produto")]
            public String Codigo { get; set; }

            [XmlElement("Nome_Produto")]
            public String Nome { get; set; }

            [XmlElement("UM_Produto")]
            public String UnidadeMedida { get; set; }

            [XmlElement("Preco_Produto")]
            public Double Preco { get; set; }


        }

        public static class Program
        {
            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static string comando = null;
            private static SqlCommand cmd = null;
            public static ListaProduto list { get; set; }


            public static ListaProduto RetornarProduto()
            {
                try
                {
                    con = ConnectionFactory.getConnection();
                    con.Open();

                    comando = "SELECT CodigoProduto, Nome, UnidadeMedida, Preco FROM Produto ORDER BY UnidadeMedida;";

                    XmlSerializer ser = new XmlSerializer(typeof(ListaProduto));
                    list = new ListaProduto();

                    using (var cmd = con.CreateCommand())
                    {

                        cmd.CommandText = comando.ToString();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                list.Items.Add(new Produto
                                {
                                    Codigo = rdr.GetString(0),
                                    Nome = rdr.GetString(1),
                                    UnidadeMedida = rdr.GetString(2),
                                    Preco = rdr.GetDouble(3),
                                });
                            }
                        }
                    }

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
}