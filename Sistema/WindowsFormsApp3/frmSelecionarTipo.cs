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
    public partial class frmSelecionarTipo : Form
    {
        public frmSelecionarTipo()
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

        private void frmSelecionarTipo_Load(object sender, EventArgs e)
        {
            localhost.Login buscaTipo = new localhost.Login();

            cmbTipo.DisplayMember = "Status";
            cmbTipo.ValueMember = "Status";
            cmbTipo.DataSource = buscaTipo.RetornaComboTipo();
        }

        private void txtVisProduto_Click(object sender, EventArgs e)
        {
            BuscarTipo.BuscaTipo = cmbTipo.SelectedValue.ToString();
            new frmGerenciamentoEstoque { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }
    }
}
