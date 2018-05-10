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
                  string Nome
                , string Funcao
                , string Departamento
                , string Usuario
                , string Senha
                , DateTime DataCriacao)

        {
            Criptografia c = new Criptografia();
            string senhaCriptografada = c.SHA256(Senha);

            MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;password=root;database=SistemaDeEstoque");
            connectionString.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO Cliente(Nome, Funcao, Departamento, Usuario, Senha, DataCriacao)" +
                "VALUES ('"+Nome+ "','" + Funcao + "','"+ Departamento+ "', '" + Nome + "', '" + senhaCriptografada + "', '" + DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss")+ ";", connectionString);
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