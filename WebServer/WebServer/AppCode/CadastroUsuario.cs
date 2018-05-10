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
        private SqlConnection con = null;
        private SqlCommand command = null;
        private SqlDataReader rdr = null;
        private SqlCommand cmdo = null;
        public int valor { get; set; } = 0;
        SqlCommand comando2 = null;
        SqlCommand comando3 = null;

        public int GravarUsuario(
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
                int IdUsuario = 0;
                con = ConnectionFactory.getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT Usuario FROM Usuario WHERE Usuario = @Usuario ;", con);

                cmd.Parameters.AddWithValue("@Usuario", Usuario);

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    valor = 0;
                    rdr.Close();
                }
                else
                {
                    rdr.Close();
                    SqlCommand comando = new SqlCommand("INSERT INTO Usuario(Nome, Funcao, Departamento, Usuario, Senha, DataCriacao)" +
                    "VALUES (@Nome,@Funcao,@Departamento,@Usuario,@Senha, GETDATE()); SELECT @@IDENTITY", con);
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Funcao", Funcao);
                    comando.Parameters.AddWithValue("@Departamento", Departamento);
                    comando.Parameters.AddWithValue("@Usuario", Usuario);
                    comando.Parameters.AddWithValue("@Senha", senhaCriptografada);

                    IdUsuario = Convert.ToInt32(comando.ExecuteScalar());

                }
                return IdUsuario;
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
        public void GravarPermissoes(string Departamento, int IdUsuario, string Nome)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();
                valor = 0;
                if (Departamento == "ADMIN")
                {
                    SqlCommand comando2 = new SqlCommand("INSERT INTO Permissoes(IdUsuario, Nome, ADMIN,CONTABILIDADE,ALMOXARIFADO,COMPRAS,COMERCIAL,COMEX,CUSTO,DIRETORIA,ENGENHARIA,MARKETING,FINANCEIRO,GERENCIA,PCP,PRODUÇÃO,QUALIDADE,RH,SEG_DO_TRABALHO,TI)" +
                     "VALUES (@IdUsuario,@Nome, 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK'); ", con);

                    comando2.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    comando2.Parameters.AddWithValue("@Nome", Nome);

                    if (comando2.ExecuteNonQuery() == 1)
                    {
                        valor = 1;
                    }
                    else
                    {
                        valor = 0;
                    }


                }
                else
                {
                    SqlCommand comando3 = new SqlCommand("INSERT INTO Permissoes(IdUsuario, Nome, " + Departamento + ")" +
                     "VALUES (@IdUsuario,@Nome, 'OK');", con);

                    comando3.Parameters.AddWithValue("@Nome", Nome);
                    comando3.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                    if (comando3.ExecuteNonQuery() == 1)
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
                    if (comando2 != null)
                    {
                        comando2.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                try
                {
                    if (comando3 != null)
                    {
                        cmdo.Dispose();
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
