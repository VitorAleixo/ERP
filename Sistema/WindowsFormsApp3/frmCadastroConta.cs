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

        private void btnPesquisaCEP_Click(object sender, EventArgs e)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(txtCEP.Text);
                txtCidade.Text = resposta.cidade;
                txtComplemento.Text = resposta.complemento;
                txtComplemento2.Text = resposta.complemento2;
                txtEstado.Text = resposta.uf;
                txtEndereco.Text = resposta.end;
                txtBairro.Text = resposta.bairro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK);
            }
        }

        private void frmCadastroConta_Load(object sender, EventArgs e)
        {
            cmbCPF.SelectedIndex = 0;
        }

        private void cmbCPF_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCPF.SelectedItem.ToString() == "CPF")
            {
                txtCPF.Text = "";
                txtCPF.Enabled = true;
                txtCPF.Mask = "000.000.000-00";
            }
            else if (cmbCPF.SelectedItem.ToString() == "CNPJ")
            {
                txtCPF.Text = "";
                txtCPF.Enabled = true;
                txtCPF.Mask = "00.000.000/0000-00";
            }
            else if (cmbCPF.SelectedItem.ToString() == "NÃO POSSUI")
            {
                txtCPF.Text = "";
                txtCPF.Enabled = false;
                txtCPF.Mask = "";
            }

        }

        void LimparCampos()
        {
            txtNome.Text = "";
            cmbCPF.SelectedIndex = 0;
            txtCEP.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtEstado.Text = "";
            txtComplemento2.Text = "";
            txtNumero.Text = "";
            txtTelefone1.Text = "";
            txtTelefone2.Text = "";
            txtEmail.Text = "";
        }

        private void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisaCEP.PerformClick();
            }
        }
    }
}
