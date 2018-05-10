using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class CadastroFornecedor
    {
        public int valor { get; set; } = 0;
        private string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";
        private string comando = null;
        private SqlCommand command = null;
        private SqlConnection con = null;

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
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                comando = "INSERT INTO Fornecedor(Nome, CPF, CEP, Endereco, Bairro, Cidade, Complemento, Estado, Complemento2, Numero, Telefone, Telefone2, EMAIL)" +
                        "VALUES ('" + Nome + "', '" + CPF + "', '" + CEP + "', '" + Endereco + "', '" + Bairro + "', '" + Cidade + "', '" + Complemento + "', '" + Estado + "', '" + Complemento2 + "', '" + Numero + "', '" + Telefone + "', '" + Telefone2 + "', '" + EMAIL + "');";

                command = new SqlCommand(comando, con);

                if (command.ExecuteNonQuery() == 1)
                {
                    valor = 1;
                }
                else
                {
                    valor = 0;
                }
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