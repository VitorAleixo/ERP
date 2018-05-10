using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServerAmx.AppCode
{
    [Serializable]
    public class BuscaEstoque
    {
        [XmlRoot("BuscaEstoque")]
        public class ListaEstoque
        {
            public ListaEstoque() { Items = new List<Estoque>(); }
            [XmlElement("ESTOQUE")]
            public List<Estoque> Items { get; set; }



        }
        public class Estoque
        {
            [XmlElement("CodigoProduto")]
            public String Codigo { get; set; }

            [XmlElement("Nome")]
            public String Nome { get; set; }

            [XmlElement("Preco")]
            public Double Preco { get; set; }

            [XmlElement("QtdEstoque")]
            public Double QtdEstoque { get; set; }

            [XmlElement("QtdMaxima")]
            public Double QtdMaxima { get; set; }

            [XmlElement("QtdMinima")]
            public Double QtdMinima { get; set; }

            [XmlElement("UM")]
            public String UM { get; set; }


        }

        public static class Program
        {
            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static SqlCommand cmd = null;
            public static ListaEstoque list { get; set; }


            public static ListaEstoque RetornarEstoque(string Tipo)
            {
                con = ConnectionFactory.getConnection();
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT CodigoProduto, Nome, Preco, QtdEstoque, QtdMaxima, QtdMinima, UnidadeMedida,Tipo " +
                        "FROM Produto INNER JOIN Estoque " +
                        "on Produto.IdProduto = Estoque.IdProduto WHERE Tipo = @Tipo;", con);
                    cmd.Parameters.AddWithValue("@Tipo", Tipo);


                    XmlSerializer ser = new XmlSerializer(typeof(ListaEstoque));
                    list = new ListaEstoque();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            list.Items.Add(new Estoque
                            {

                                Codigo = rdr.GetString(0),
                                Nome = rdr.GetString(1),
                                Preco = rdr.GetDouble(2),
                                QtdEstoque = rdr.GetDouble(3),
                                QtdMaxima = rdr.GetDouble(4),
                                QtdMinima = rdr.GetDouble(5),
                                UM = rdr.GetString(6)
                            });
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