using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class CadastroUsuario
    {
        private string senhaCriptografada = null;
        private string connectionString = "Data Source=SERVER05;Initial Catalog=Estoque;User ID=ENTERPRISING;Password=ENTERPRISING";
        private SqlConnection con = null;
        private string comando = null;
        private SqlCommand command = null;

        public int valor { get; set; } = 0;

        public void GravarUsuario(
                  string Nome
                , string Funcao
                , string Departamento
                , string Usuario
                , string Senha
                , DateTime DataCriacao)

        {
            try
            {
                Criptografia c = new Criptografia();
                senhaCriptografada = c.SHA256(Senha);

                con = new SqlConnection(connectionString);
                con.Open();
                comando = "INSERT INTO Cliente(Nome, Funcao, Departamento, Usuario, Senha, DataCriacao)" +
                    "VALUES ('" + Nome + "','" + Funcao + "','" + Departamento + "', '" + Nome + "', '" + senhaCriptografada + "', GETDATE());";

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