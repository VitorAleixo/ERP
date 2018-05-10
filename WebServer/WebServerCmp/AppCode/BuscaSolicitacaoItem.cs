using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServerCmp.AppCode
{
    [Serializable]
    public class BuscaSolicitacaoItem
    {
        [XmlRoot("BuscaSolicitacaoItem")]
        public class ListaSolicitacaoItem
        {
            public ListaSolicitacaoItem() { Items = new List<SolicitacaoItem>(); }
            [XmlElement("ITEMSOLICITACAO")]
            public List<SolicitacaoItem> Items { get; set; }



        }
        public class SolicitacaoItem
        {
            [XmlElement("Cod")]
            public String Cod { get; set; }

            [XmlElement("Nome")]
            public String Nome { get; set; }

            [XmlElement("UnidadeMedida")]
            public String UnidadeMedida { get; set; }

            [XmlElement("QtdEstoque")]
            public Double QtdEstoque { get; set; }

            [XmlElement("QtdMinima")]
            public Double QtdMinima { get; set; }

            [XmlElement("QtdMaxima")]
            public Double QtdMaxima { get; set; }

            [XmlElement("Solicitar")]
            public Double Solicitar { get; set; }

        }

        public static class Program
        {

            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static SqlCommand cmd = null;
            public static ListaSolicitacaoItem list { get; set; }


            public static ListaSolicitacaoItem RetornaSolicitacaoItem(int IdPedido)
            {
                con = ConnectionFactory.getConnection();
                con.Open();
                try
                {

                    cmd = new SqlCommand("SELECT Cod, Nome, UnidadeMedida, QtdEstoque, QtdMinima, QtdMaxima, Solicitar FROM PedidoItem WHERE IdPedido = @IdPedido;", con);
                    cmd.Parameters.AddWithValue("@IdPedido", IdPedido);

                    XmlSerializer ser = new XmlSerializer(typeof(ListaSolicitacaoItem));
                    list = new ListaSolicitacaoItem();

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            list.Items.Add(new SolicitacaoItem
                            {

                                Cod = rdr.GetString(0),
                                Nome = rdr.GetString(1),
                                UnidadeMedida = rdr.GetString(2),
                                QtdEstoque = rdr.GetDouble(3),
                                QtdMinima = rdr.GetDouble(4),
                                QtdMaxima = rdr.GetDouble(5),
                                Solicitar = rdr.GetDouble(6),
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