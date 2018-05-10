using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServerCmp.AppCode
{
    [Serializable]
    public class BuscaSolicitacaoDeCompra
    {
        [XmlRoot("BuscaSolicitacoes")]
        public class ListaSolicitacoes
        {
            public ListaSolicitacoes() { Items = new List<Solicitacoes>(); }
            [XmlElement("SOLICITACOES")]
            public List<Solicitacoes> Items { get; set; }



        }
        public class Solicitacoes
        {
            [XmlElement("IdPedido")]
            public int IdPedido { get; set; }

            [XmlElement("Solicitante")]
            public String Solicitante { get; set; }

            [XmlElement("Urgencia")]
            public String Urgencia { get; set; }

            [XmlElement("DataCriacao")]
            public String DataCriacao { get; set; }

            [XmlElement("Tipo")]
            public String Tipo { get; set; }

            [XmlElement("Status")]
            public String Status { get; set; }

        }

        public static class Program
        {

            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static string comando = null;
            private static SqlCommand cmd = null;
            public static ListaSolicitacoes list { get; set; }


            public static ListaSolicitacoes RetornaSolicitacoes()
            {
                try
                {
                    con = ConnectionFactory.getConnection();
                    con.Open();

                    comando = "SELECT IdPedido, Solicitante, Urgencia, DataCriacao, Tipo, Status FROM Pedido WHERE Status = 'APROVADO' OR Status = 'GERADO' ORDER BY Status;";

                    XmlSerializer ser = new XmlSerializer(typeof(ListaSolicitacoes));
                    list = new ListaSolicitacoes();

                    using (var cmd = con.CreateCommand())
                    {

                        cmd.CommandText = comando.ToString();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                list.Items.Add(new Solicitacoes
                                {
                                    IdPedido = rdr.GetInt32(0),
                                    Solicitante = rdr.GetString(1),
                                    Urgencia = rdr.GetString(2),
                                    DataCriacao = rdr.GetDateTime(3).ToString("dd/MM/yyyy"),
                                    Tipo = rdr.GetString(4),
                                    Status = rdr.GetString(5)
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