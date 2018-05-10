﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebServer.AppCode
{
        [Serializable]
        public class BuscaSolicitacao
        {
            [XmlRoot("BuscaSolicitacao")]
            public class ListaSolicitacao
        {
                public ListaSolicitacao() { Items = new List<Solicitacao>(); }
                [XmlElement("SOLICITACAO")]
                public List<Solicitacao> Items { get; set; }



            }
            public class Solicitacao
            {
                [XmlElement("Solicitante")]
                public String Solicitante { get; set; }

                [XmlElement("Urgencia")]
                public String Urgencia { get; set; }

                [XmlElement("Motivo")]
                public String Motivo { get; set; }

                [XmlElement("DataCriacao")]
                public String DataCriacao { get; set; }

            }

            public static class Program
            {

                private static SqlConnection con = null;
                private static SqlDataReader rdr = null;
                private static string comando = null;
                private static SqlCommand command = null;
                public static ListaSolicitacao list { get; set; }


                public static ListaSolicitacao RetornaSolicitacao()
                {
                    try
                    {
                        con = ConnectionFactory.getConnection();
                        con.Open();

                        comando = "SELECT Solicitante, Urgencia, Motivo, DataCriacao FROM Pedido WHERE Status = 'PENDENTE' ORDER BY Urgencia DESC;";

                        XmlSerializer ser = new XmlSerializer(typeof(ListaSolicitacao));
                        list = new ListaSolicitacao();

                        using (var cmd = con.CreateCommand())
                        {

                            cmd.CommandText = comando.ToString();
                            using (var rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    list.Items.Add(new Solicitacao
                                    {

                                        Solicitante = rdr.GetString(0),
                                        Urgencia = rdr.GetString(1),
                                        Motivo = rdr.GetString(2),
                                        DataCriacao = rdr.GetDateTime(3).ToString("dd/MM/yyyy"),
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