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
            txtNome.Text = "";
            txtFuncao.Text = "";
            txtDepartamento.Text = "";
            cmbDepartamento.SelectedIndex = -1;
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtSenhaConfirmacao.Text = "";

        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "" || txtSenha.Text == "" || txtUsuario.Text == "" || txtSenhaConfirmacao.Text == "" || txtFuncao.Text == "" || cmbDepartamento.SelectedIndex == -1)
                {
                    MessageBox.Show("OOPS! Tem algum dado faltando!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    localhost.Login cadastroUsuario = new localhost.Login();


                    string Nome = txtNome.Text;
                    string Funcao = txtFuncao.Text;
                    string Departamento = cmbDepartamento.SelectedItem.ToString();
                    string Usuario = txtUsuario.Text;
                    string Senha = txtSenha.Text;
                    string SenhaConfirmacao = txtSenhaConfirmacao.Text;

                    if (cmbDepartamento.SelectedItem.ToString() == "OUTROS")
                    {
                        Departamento = txtDepartamento.Text;
                    }
                    DateTime DataCriacao = DateTime.Now;

                    if (Senha == SenhaConfirmacao)
                    {
                        if (cadastroUsuario.CadastroUsuario(Nome, Funcao, Departamento, Usuario, Senha, DataCriacao))
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

        private void cmbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbDepartamento.SelectedItem.ToString() == "OUTROS")
            {
                txtDepartamento.Text = "";
                txtDepartamento.Enabled = true;
            }
            else
            {
                txtDepartamento.Text = "";
                txtDepartamento.Enabled = false;
            }
        }
    }
}
