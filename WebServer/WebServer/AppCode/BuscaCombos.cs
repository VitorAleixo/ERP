using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServer.AppCode
{
    public class BuscaCombos
    {
        [XmlRoot("BuscaComboFornecedor")]
        public class ListaFornecedorCombo
        {
            public ListaFornecedorCombo() { Items = new List<FornecedorCombo>(); }
            [XmlElement("FORNECEDOR")]
            public List<FornecedorCombo> Items { get; set; }

        }
        public class FornecedorCombo
        {
            [XmlElement("Id")]
            public int Id { get; set; }

            [XmlElement("Nome")]
            public String Nome { get; set; }
        }
        public static class Program
        {

            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static string comando = null;
            private static SqlCommand cmd = null;
            public static ListaFornecedorCombo list { get; set; }


            public static ListaFornecedorCombo RetornarComboFornecedor()
            {
                try
                {
                    con = ConnectionFactory.getConnection();
                    con.Open();

                    comando = "SELECT IdFornecedor , Nome FROM Fornecedor ORDER BY Nome;";

                    XmlSerializer ser = new XmlSerializer(typeof(ListaFornecedorCombo));
                    list = new ListaFornecedorCombo();

                    using (var cmd = con.CreateCommand())
                    {

                        cmd.CommandText = comando.ToString();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                list.Items.Add(new FornecedorCombo
                                {
                                    Id = rdr.GetInt32(0),
                                    Nome = rdr.GetString(1),

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
