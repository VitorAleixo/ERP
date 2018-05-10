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
    public partial class frmPrincipal : Form
    {
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

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastroProd_Click(object sender, EventArgs e)
        {
            new frmCadastroProduto { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void btnCadastroForn_Click(object sender, EventArgs e)
        {
            new frmCadastroFornecedor { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void btnGerenciamento_Click(object sender, EventArgs e)
        {
            new frmGerenciamentoEstoque { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void btnVisProduto_Click(object sender, EventArgs e)
        {
            new frmVisProdutos { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void btnVisForn_Click(object sender, EventArgs e)
        {
            new frmVisFornecedores { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }
    }
}
