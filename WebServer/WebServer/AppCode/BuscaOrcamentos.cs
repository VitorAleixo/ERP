using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServer.AppCode
{
    [Serializable]
    public class BuscaOrcamentos
    {
        [XmlRoot("BuscaOrcamentos")]
        public class ListaOrcamento
        {
            public ListaOrcamento() { Items = new List<Orcamento>(); }
            [XmlElement("ORCAMENTO")]
            public List<Orcamento> Items { get; set; }



        }
        public class Orcamento
        {
            [XmlElement("Pedido")]
            public int Pedido { get; set; }

            [XmlElement("Tipo")]
            public String Tipo { get; set; }

            [XmlElement("DataEmissao")]
            public String DataEmissao { get; set; }

            [XmlElement("CondicaoPag")]
            public String CondicaoPag { get; set; }

            [XmlElement("ValorTotal")]
            public Double ValorTotal { get; set; }

            [XmlElement("QtdItens")]
            public int QtdItens { get; set; }


        }

        public static class Program
        {


            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static string comando = null;
            private static SqlCommand command = null;
            public static ListaOrcamento list { get; set; }


            public static ListaOrcamento RetornaOrcamento()
            {
                try
                {
                    con = ConnectionFactory.getConnection();
                    con.Open();

                    comando = "SELECT IdPedido, Tipo, DataEmissao, CondicaoPag, ValorTotal, QtdItens FROM Orcamento ORDER BY DataEmissao;";

                    XmlSerializer ser = new XmlSerializer(typeof(ListaOrcamento));
                    list = new ListaOrcamento();

                    using (var cmd = con.CreateCommand())
                    {

                        cmd.CommandText = comando.ToString();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                list.Items.Add(new Orcamento
                                {
                                    Pedido = rdr.GetInt32(0),
                                    Tipo = rdr.GetString(1),
                                    DataEmissao = rdr.GetDateTime(2).ToString("dd/MM/yyyy"),
                                    CondicaoPag = rdr.GetString(3),
                                    ValorTotal = rdr.GetDouble(4),
                                    QtdItens = rdr.GetInt32(5)

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