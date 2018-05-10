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
    public partial class frmPrincipalAdmin : Form
    {
        public frmPrincipalAdmin()
        {
            InitializeComponent();
        }

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

        private void frmPrincipalAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new frmAdminRights { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            new frmPrincipalCompras { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void btnAlmoxarifado_Click(object sender, EventArgs e)
        {
            new frmPrincipalAlmoxarife { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void btnGerencia_Click(object sender, EventArgs e)
        {
            new frmPrincipalGerencia { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void btnComercial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnComex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnCusto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnContabilidade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnDiretoria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnEngenharia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnPCP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnQualidade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnRH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnSegTrabalho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }

        private void btnTI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo ainda não desenvolvido!!", "Confirmação", MessageBoxButtons.OK);
        }
    }
}
