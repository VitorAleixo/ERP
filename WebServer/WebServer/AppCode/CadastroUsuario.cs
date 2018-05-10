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
        private string comando2 = null;
        private SqlCommand command2 = null;
        private SqlDataReader rdr = null;
        private string cmd = null;
        private SqlCommand cmdo = null;

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

                cmd = "SELECT * FROM Usuario WHERE Usuario = '" + Usuario + "';";
                cmdo = new SqlCommand(cmd, con);

                rdr = cmdo.ExecuteReader();

                if (rdr.Read())
                {
                    valor = 0;
                    rdr.Close();
                }
                else
                {
                    rdr.Close();
                    comando = "INSERT INTO Usuario(Nome, Funcao, Departamento, Usuario, Senha, DataCriacao)" +
                    "VALUES ('" + Nome + "','" + Funcao + "','" + Departamento + "', '" + Usuario + "', '" + senhaCriptografada + "', GETDATE());";

                    command = new SqlCommand(comando, con);

                    if (Departamento == "ADMIN")
                    {
                        comando2 = "INSERT INTO Permissoes(IdUsuario, Nome, ADMIN,CONTABILIDADE,ALMOXARIFADO,COMPRAS,COMERCIAL,COMEX,CUSTO,DIRETORIA,ENGENHARIA,MARKETING,FINANCEIRO,GERENCIA,PCP,PRODUÇÃO,QUALIDADE,RH,SEG_DO_TRABALHO,TI)" +
                         "VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'" + Nome + "', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK');";
                    }
                    else
                    { 
                          comando2 = "INSERT INTO Permissoes(IdUsuario, Nome, " + Departamento + ")" +
                         "VALUES ((SELECT MAX(IdUsuario) FROM Usuario),'" + Nome+ "', 'OK');";
                    }
                    command2 = new SqlCommand(comando2, con);
                    if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                    {
                        valor = 1;
                    }
                    else
                    {
                        valor = 0;
                    }
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
                try
                {
                    if (cmdo != null)
                    {
                        cmdo.Dispose();
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
            }
        }
    }
}