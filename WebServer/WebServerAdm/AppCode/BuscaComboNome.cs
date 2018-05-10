using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServerAdm.AppCode
{
    public class BuscaComboNome
    {
        [XmlRoot("BuscaComboNome")]
        public class ListaNomeCombo
        {
            public ListaNomeCombo() { Items = new List<NomeCombo>(); }
            [XmlElement("NOME")]
            public List<NomeCombo> Items { get; set; }

        }
        public class NomeCombo
        {
            [XmlElement("Nome")]
            public String Nome { get; set; }
        }
        public static class Program
        {

            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static string comando = null;
            private static SqlCommand cmd = null;
            public static ListaNomeCombo list { get; set; }


            public static ListaNomeCombo RetornaComboNome()
            {
                try
                {
                    con = ConnectionFactory.getConnection();
                    con.Open();

                    comando = "SELECT Usuario FROM Usuario ORDER BY Usuario;";

                    XmlSerializer ser = new XmlSerializer(typeof(ListaNomeCombo));
                    list = new ListaNomeCombo();

                    using (var cmd = con.CreateCommand())
                    {

                        cmd.CommandText = comando.ToString();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                list.Items.Add(new NomeCombo
                                {
                                    Nome = rdr.GetString(0),

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