using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmPermissaoUsuarios : Form
    {
        string usuario = "";

        public frmPermissaoUsuarios()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "ADMIN";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }

        private void btnAlmoxarifado_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "ALMOXARIFADO";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            try
            {

                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "COMPRAS";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnContabilidade_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "CONTABILIDADE";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnComercial_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "COMERCIAL";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnComex_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "COMEX";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnCusto_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "CUSTO";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnDiretoria_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "DIRETORIA";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnEngenharia_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "ENGENHARIA";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "MARKETING";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "FINANCEIRO";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnGerencia_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "GERENCIA";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnPCP_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "PCP";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "PRODUÇÃO";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnQualidade_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "QUALIDADE";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnRH_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "RH";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnSegTrabalho_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "SEG_DO_TRABALHO";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnTI_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Login buscaDepartamento = new localhost.Login();
                localhostAdm.Admin permissoes = new localhostAdm.Admin();
                usuario = "";
                usuario = cmbUsuario.SelectedValue.ToString();
                string setor = "TI";

                if (permissoes.VerificarPermissao(setor, usuario) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Este usuário ja possui esta permissão, deseja remove-la?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesRemove(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão removida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja atribuir esta permissão para este usuario?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (permissoes.AtualizaPermissoesAdiciona(setor, usuario) == true)
                        {
                            MessageBox.Show("Permissão atribuida com sucesso!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void frmPermissaoUsuarios_Load(object sender, EventArgs e)
        {
            localhostAdm.Admin buscaTipo = new localhostAdm.Admin();

            cmbUsuario.DisplayMember = "Nome";
            cmbUsuario.ValueMember = "Nome";
            cmbUsuario.DataSource = buscaTipo.RetornaComboNome();
        }
    }
}
