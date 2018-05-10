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
    public partial class frmPrincipalCompras : Form
    {
        public frmPrincipalCompras()
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

        private void btnCadastroForn_Click(object sender, EventArgs e)
        {
            new frmCadastroFornecedor { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void btnVisForn_Click(object sender, EventArgs e)
        {
            new frmVisFornecedores { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void frmPrincipalCompras_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo: " + SessaoSistema.NomeUsuario + "!", "Confirmacão", MessageBoxButtons.OK);
            lblNomeUsuario.Text = "Usuário: " + SessaoSistema.NomeUsuario;

            localhost.Login login = new localhost.Login();
            string usuario = SessaoSistema.NomeUsuario;
            string setor = login.RetornaSetor(usuario);

            lblSetor.Text = "Setor: " + login.RetornaSetor(usuario);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarOrc_Click(object sender, EventArgs e)
        {
            new frmGerarOrcamento { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }
    }
}
