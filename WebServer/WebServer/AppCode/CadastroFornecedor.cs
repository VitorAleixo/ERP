using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class CadastroFornecedor
    {
        public int valor { get; set; } = 0;

        public void GravarFornecedor(
                  string Nome
                , string CPF
                , string CEP
                , string Endereco
                , string Bairro
                , string Cidade
                , string Complemento
                , string Estado
                , string Complemento2
                , string Numero
                , string Telefone
                , string Telefone2
                , string EMAIL)
        {
            MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;password=root;database=SistemaDeEstoque");
            connectionString.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO CadastroFornecedor(Nome, CPF, CEP, Endereco, Bairro, Cidade, Complemento, Estado, Complemento2, Numero, Telefone, Telefone2, Email)" +
                "VALUES ('"+Nome+ "', '" + CPF+ "', '" + CEP + "', '" + Endereco + "', '" + Bairro + "', '" + Cidade + "', '" + Complemento + "', '" + Estado + "', '" + Complemento2 + "', '" + Numero + "', '" + Telefone + "', '" + Telefone2 + "', '" + EMAIL + "');", connectionString);
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