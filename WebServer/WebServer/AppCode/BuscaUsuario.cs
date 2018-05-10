using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServer.AppCode
{
    [Serializable]
    public class BuscaUsuario
    {
        [XmlRoot("BuscaUsuario")]
        public class ListaUsuario
        {
            public ListaUsuario() { Items = new List<Usuario>(); }
            [XmlElement("USUARIO")]
            public List<Usuario> Items { get; set; }



        }
        public class Usuario
        {
            [XmlElement("Nome")]
            public String Nome { get; set; }

            [XmlElement("Funcao")]
            public String Funcao { get; set; }

            [XmlElement("Departamento")]
            public String Departamento { get; set; }

            [XmlElement("User")]
            public String User { get; set; }

            [XmlElement("DataCriacao")]
            public String DataCriacao { get; set; }


        }

        public static class Program
        {

            private static string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";
            private static SqlConnection con = null;
            private static SqlDataReader rdr = null;
            private static string comando = null;
            private static SqlCommand command = null;
            public static ListaUsuario list { get; set; }


            public static ListaUsuario RetornarUsuario()
            {
                try
                {
                    con = new SqlConnection(connectionString);
                    con.Open();

                    comando = "SELECT Nome, Funcao, Departamento, Usuario, DataCriacao FROM Usuario ORDER BY Departamento;";

                    XmlSerializer ser = new XmlSerializer(typeof(ListaUsuario));
                    list = new ListaUsuario();

                    using (var cmd = con.CreateCommand())
                    {

                        cmd.CommandText = comando.ToString();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                list.Items.Add(new Usuario
                                {
                                    Nome = rdr.GetString(0),
                                    Funcao = rdr.GetString(1),
                                    Departamento = rdr.GetString(2),
                                    User = rdr.GetString(3),
                                    DataCriacao = rdr.GetDateTime(4).ToString("dd/MM/yyyy"),
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