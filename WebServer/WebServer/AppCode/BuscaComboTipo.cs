using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServer.AppCode
{
    public class BuscaComboTipo
    {
        [XmlRoot("BuscaComboTipo")]
        public class ListaTipoCombo
        {
            public ListaTipoCombo() { Items = new List<TipoCombo>(); }
            [XmlElement("TIPO")]
            public List<TipoCombo> Items { get; set; }

        }
        public class TipoCombo
        {
            [XmlElement("Status")]
            public String Status { get; set; }
        }
        public static class Program
        {

            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static string comando = null;
            private static SqlCommand command = null;
            public static ListaTipoCombo list { get; set; }


            public static ListaTipoCombo RetornaComboTipo()
            {
                try
                {
                    con = ConnectionFactory.getConnection();
                    con.Open();

                    comando = "SELECT DISTINCT Tipo FROM Produto ORDER BY Tipo;";

                    XmlSerializer ser = new XmlSerializer(typeof(ListaTipoCombo));
                    list = new ListaTipoCombo();

                    using (var cmd = con.CreateCommand())
                    {

                        cmd.CommandText = comando.ToString();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                list.Items.Add(new TipoCombo
                                {
                                    Status = rdr.GetString(0),

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