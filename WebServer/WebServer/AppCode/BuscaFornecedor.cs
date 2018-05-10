using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServer.AppCode
{
    [Serializable]
    public class BuscaFornecedor
    {
        [XmlRoot("BuscaFornecedor")]
        public class ListaFornecedor
        {
            public ListaFornecedor() { Items = new List<Fornecedor>(); }
            [XmlElement("FORNECEDOR")]
            public List<Fornecedor> Items { get; set; }



        }
        public class Fornecedor
        {
            [XmlElement("Nome")]
            public String Nome { get; set; }

            [XmlElement("CPF")]
            public String CPF { get; set; }

            [XmlElement("Estado")]
            public String Estado { get; set; }

            [XmlElement("CEP")]
            public String CEP { get; set; }

            [XmlElement("Telefone")]
            public String Telefone { get; set; }

            [XmlElement("Email")]
            public String Email { get; set; }

        }

        public static class Program
        {

            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static string comando = null;
            private static SqlCommand command = null;
            public static ListaFornecedor list { get; set; }


            public static ListaFornecedor RetornarFornecedor()
            {
                try
                {
                    con = ConnectionFactory.getConnection();
                    con.Open();

                    comando = "SELECT Nome, CPF, CEP, Estado, Telefone, EMAIL FROM Fornecedor ORDER BY Nome;";

                    XmlSerializer ser = new XmlSerializer(typeof(ListaFornecedor));
                    list = new ListaFornecedor();

                    using (var cmd = con.CreateCommand())
                    {

                        cmd.CommandText = comando.ToString();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                list.Items.Add(new Fornecedor
                                {

                                   Nome = rdr.GetString(0),
                                   CPF = rdr.GetString(1),
                                   CEP = rdr.GetString(2),                         
                                   Estado = rdr.GetString(3),                                                      
                                   Telefone = rdr.GetString(4),
                                   Email = rdr.GetString(5)
                                });
                            }
                        }
                        cmd.Dispose();

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