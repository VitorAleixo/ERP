using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.AppCode
{
    public class CadastroUsuario
    {
        public int valor { get; set; } = 0;

        public void GravarUsuario(
                  string Usuario
                , string Senha
                , string Email
                , DateTime DataCriacao
                , string TipoConta
                , int Status)
        {
            Criptografia c = new Criptografia();
            string senhaCriptografada = c.SHA256(Senha);

            MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;password=root;database=SistemaDeEstoque");
            connectionString.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO Cliente(Usuario, Senha, Email, DataCriacao, TipoConta, Status)" +
                "VALUES ('" + Usuario + "', '" + senhaCriptografada + "', '" + Email + "', '" + DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss")+ "', '" + TipoConta + "', '" + Status +"');", connectionString);
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