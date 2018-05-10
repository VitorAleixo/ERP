using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class CadastroProduto
    {
            public int valor { get; set; } = 0;

            public void GravarProduto(
                      string CodigoProduto
                    , string Nome
                    , float Preco
                    , string UnidadeMedida
                    , float QtdMinima
                    , float QtdMaxima
                    , float QtdEstoque)
        {
                int IdUser = 0;
                MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;password=root;database=SistemaDeEstoque");
                connectionString.Open();
                MySqlCommand command = new MySqlCommand("SELECT Id FROM Cliente WHERE Status = 1", connectionString);
                MySqlDataReader rdr = command.ExecuteReader();
                if (rdr.Read())
                {
                    IdUser = rdr.GetInt32("Id");
                }
                rdr.Close();

                command = new MySqlCommand("INSERT INTO CadastroProduto(CodigoProduto, Nome, Preco, UnidadeMedida, QtdMinima, QtdMaxima, QtdEstoque, IdUser)" +
                    "VALUES ('" + CodigoProduto + "', '" + Nome + "', '" + Preco.ToString().Replace(",",".") + "', '" + UnidadeMedida + "', '" + QtdMinima + "', '" + QtdMaxima + "', '" + QtdEstoque + "', '" + IdUser + "');", connectionString);
                if (command.ExecuteNonQuery() == 1)
                {
                    valor = 1;
                }
                else
                {
                    valor = 0;
                }
                command.Dispose();

                connectionString.Close();
            }
        }
}