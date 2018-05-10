using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServer.AppCode
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
            private static string comando = null;
            private static SqlCommand command = null;
            public static ListaEstoque list { get; set; }


            public static ListaEstoque RetornarEstoque(string Tipo)
            {
                con = ConnectionFactory.getConnection();
                con.Open();
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT CodigoProduto, Nome, QtdEstoque, QtdMaxima, QtdMinima, UnidadeMedida,Tipo " +
                        "FROM Produto INNER JOIN Estoque " +
                        "on Produto.IdProduto = Estoque.IdProduto WHERE Tipo = @Tipo;", con);
                    comando.Parameters.AddWithValue("@Tipo", Tipo);


                    XmlSerializer ser = new XmlSerializer(typeof(ListaEstoque));
                    list = new ListaEstoque();

                    using (var rdr = comando.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            list.Items.Add(new Estoque
                            {

                                Codigo = rdr.GetString(0),
                                Nome = rdr.GetString(1),
                                QtdEstoque = rdr.GetDouble(2),
                                QtdMaxima = rdr.GetDouble(3),
                                QtdMinima = rdr.GetDouble(4),
                                UM = rdr.GetString(5)
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