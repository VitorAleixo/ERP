using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServerAdm.AppCode
{
    public class CadastroUsuario
    {
        private string senhaCriptografada = null;
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader rdr = null;
        public int valor { get; set; } = 0;

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

                cmd = new SqlCommand("SELECT Usuario FROM Usuario WHERE Usuario = @Usuario ;", con);

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
                    cmd = new SqlCommand("INSERT INTO Usuario(Nome, Funcao, Departamento, Usuario, Senha, DataCriacao)" +
                    "VALUES (@Nome,@Funcao,@Departamento,@Usuario,@Senha, GETDATE()); SELECT @@IDENTITY", con);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Funcao", Funcao);
                    cmd.Parameters.AddWithValue("@Departamento", Departamento);
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Senha", senhaCriptografada);

                    IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());

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
                    if (cmd != null)
                    {
                        cmd.Dispose();
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
        public void GravarPermissoes(string Departamento, int IdUsuario, string Usuario)
        {
            try
            {
                con = ConnectionFactory.getConnection();
                con.Open();
                valor = 0;
                if (Departamento == "ADMIN")
                {
                    cmd = new SqlCommand("INSERT INTO Permissoes(IdUsuario, Usuario, ADMIN,CONTABILIDADE,ALMOXARIFADO,COMPRAS,COMERCIAL,COMEX,CUSTO,DIRETORIA,ENGENHARIA,MARKETING,FINANCEIRO,GERENCIA,PCP,PRODUÇÃO,QUALIDADE,RH,SEG_DO_TRABALHO,TI)" +
                     "VALUES (@IdUsuario,@Nome, 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK', 'OK'); ", con);

                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);

                    if (cmd.ExecuteNonQuery() == 1)
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
                    cmd = new SqlCommand("INSERT INTO Permissoes(IdUsuario, Usuario, " + Departamento + ")" +
                     "VALUES (@IdUsuario,@Nome, 'OK');", con);

                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                    if (cmd.ExecuteNonQuery() == 1)
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
                    if (cmd != null)
                    {
                        cmd.Dispose();
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
