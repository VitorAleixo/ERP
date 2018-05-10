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
        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            new frmCadastroConta { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo: " + SessaoSistema.NomeUsuario + "!", "Confirmacão", MessageBoxButtons.OK);
            lblNomeUsuario.Text = "Usuário: " + SessaoSistema.NomeUsuario;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

       
    }
}
