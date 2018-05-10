using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServerAdm.AppCode
{
    public class AtualizarPermissoes
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;

        public bool AtualizaPermissoesAdiciona(string Usuario, string Departamento)
        {
            try
            {
                bool valor = false;
                if (Departamento != "ADMIN")
                {
                    con = ConnectionFactory.getConnection();
                    con.Open();

                    cmd = new SqlCommand("UPDATE Permissoes SET " + Departamento + " = @Status WHERE Usuario = @Usuario", con);

                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Status", "OK");

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        valor = true;
                    }
                    else
                    {
                        valor = false;
                    }
                }
                else
                {
                    con = ConnectionFactory.getConnection();
                    con.Open();

                    cmd = new SqlCommand("UPDATE Permissoes SET ADMIN = @Status " +
                        ", ALMOXARIFADO = @Status " +
                        ", COMPRAS = @Status " +
                        ", CONTABILIDADE = @Status " +
                        ", COMERCIAL = @Status " +
                        ", COMEX = @Status "+
                        ", CUSTO = @Status "+
                        ", DIRETORIA = @Status "+
                        ", ENGENHARIA = @Status "+
                        ", MARKETING = @Status "+
                        ", FINANCEIRO = @Status "+
                        ", GERENCIA = @Status "+
                        ", PCP = @Status "+
                        ", PRODUÇÃO = @Status "+
                        ", QUALIDADE = @Status "+
                        ", RH = @Status "+
                        ", SEG_DO_TRABALHO = @Status "+
                        ", TI = @Status "+
                        " WHERE Usuario = @Usuario", con);

                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Status", "OK");

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        valor = true;
                    }
                    else
                    {
                        valor = false;
                    }
                }
                return valor;


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

        public bool AtualizaPermissoesRemove(string Usuario, string Departamento)
        {
            try
            {
                bool valor = false;
                if (Departamento != "ADMIN")
                {

                    con = ConnectionFactory.getConnection();
                    con.Open();

                    cmd = new SqlCommand("UPDATE Permissoes SET " + Departamento + " = NULL WHERE Usuario = @Usuario", con);

                    cmd.Parameters.AddWithValue("@Usuario", Usuario);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        valor = true;
                    }
                    else
                    {
                        valor = false;
                    }
                }
                else
                {

                    con = ConnectionFactory.getConnection();
                    con.Open();

                    cmd = new SqlCommand("UPDATE Permissoes SET ADMIN = NULL " +
                        ", ALMOXARIFADO = NULL " +
                        ", COMPRAS = NULL " +
                        ", CONTABILIDADE = NULL " +
                        ", COMERCIAL = NULL " +
                        ", COMEX = NULL " +
                        ", CUSTO = NULL " +
                        ", DIRETORIA = NULL " +
                        ", ENGENHARIA = NULL " +
                        ", MARKETING = NULL " +
                        ", FINANCEIRO = NULL " +
                        ", GERENCIA = NULL " +
                        ", PCP = NULL " +
                        ", PRODUÇÃO = NULL " +
                        ", QUALIDADE = NULL " +
                        ", RH = NULL " +
                        ", SEG_DO_TRABALHO = NULL " +
                        ", TI = NULL " +
                        " WHERE Usuario = @Usuario", con);

                    cmd.Parameters.AddWithValue("@Usuario", Usuario);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        valor = true;
                    }
                    else
                    {
                        valor = false;
                    }
                }
                return valor;
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