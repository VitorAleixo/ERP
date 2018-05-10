using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.AppCode;

namespace WindowsFormsApp3
{
    public partial class frmPrincipalSelecionar : Form
    {
        localhost.Login permissao = new localhost.Login();

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public frmPrincipalSelecionar()
        {
            InitializeComponent();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipalSelecionar_Load(object sender, EventArgs e)
        {
        }

        private void btnAlmoxarifado_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "ALMOXARIFADO") == "OK")
            {
                new frmPrincipalAlmoxarife { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "COMPRAS") == "OK")
            {
                new frmPrincipalCompras { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnComercial_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "COMERCIAL") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnComex_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "COMEX") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnCusto_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "CUSTO") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnContabilidade_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "CONTABILIDADE") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnDiretoria_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "DIRETORIA") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnEngenharia_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "ENGENHARIA") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "MARKETING") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "FINANCEIRO") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnGerencia_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "GERENCIA") == "OK")
            {
                new frmPrincipalGerencia { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnPCP_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "PCP") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "PRODUÇÃO") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnQualidade_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "Qualidade") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnRH_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "RH") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnSegTrabalho_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "SEG_DO_TRABALHO") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnTI_Click(object sender, EventArgs e)
        {
            if (permissao.VerificaPermissao(SessaoSistema.NomeUsuario, "TI") == "OK")
            {
                MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Você não tem Permissão para acessar este módulo!", "Confirmação", MessageBoxButtons.OK);
            }
        }
    }
}
