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
    public partial class frmCadastroConta : Form
    {
        public frmCadastroConta()
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmCadastroConta_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }


        void LimparCampos()
        {

            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtSenhaConfirmacao.Text = "";
            txtEmail.Text = "";
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "" || txtSenha.Text == "" || txtUsuario.Text == "" || txtSenhaConfirmacao.Text == "")
                {
                    MessageBox.Show("OOPS! Tem algum dado faltando!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    localhost.Login cadastroUsuario = new localhost.Login();

                    string Usuario = txtUsuario.Text;
                    string Senha = txtSenha.Text;
                    string SenhaConfirmacao = txtSenhaConfirmacao.Text;
                    string Email = txtEmail.Text;
                    DateTime DataCriacao = DateTime.Now;
                    string TipoConta = "Usuario";
                    int Status = 0;

                    if (Senha == SenhaConfirmacao)
                    {
                        if (cadastroUsuario.CadastroUsuario(Usuario, Senha, Email, DataCriacao, TipoConta, Status))
                        {
                            DialogResult dialogResult = MessageBox.Show("Cadastrado com Sucesso!", "Usuário", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao gravar Usuario!!!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("As senhas não coincidem!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
