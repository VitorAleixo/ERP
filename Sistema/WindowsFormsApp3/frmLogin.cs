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
    public partial class frmLogin : Form
    {
        public int variavel { get; set; } = 1;
        public bool validar { get; set; } = false;

        public frmLogin()
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

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            variavel = 0;
            validar = false;
            this.Close();
        }

        public void LimparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha.Text == "" || txtUsuario.Text == "")
                {
                    MessageBox.Show("OOPS! Tem algum dado faltando!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    localhost.Login login = new localhost.Login();
                    string usuario = txtUsuario.Text;
                    string senha = txtSenha.Text;


                    if (login.LoginSistema(usuario, senha))
                    {
                        validar = true;
                        MessageBox.Show("Autenticado no Sistema!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        validar = false;
                        MessageBox.Show("Usuario ou Senha Incorretos!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSenha.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
