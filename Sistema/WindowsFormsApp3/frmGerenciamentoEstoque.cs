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
    public partial class frmGerenciamentoEstoque : Form
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

        public frmGerenciamentoEstoque()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGerenciamentoEstoque_Load(object sender, EventArgs e)
        {
            localhost.Login buscaEstoque = new localhost.Login();

            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = buscaEstoque.RetornaEstoque();
            grdGerenciamento.Show();
        }

        private void grdGerenciamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {
                    var QtdEstoque = Convert.ToInt32(row.Cells[2].Value);
                    var QTdMaxima = Convert.ToInt32(row.Cells[3].Value);
                    var QtdMinima = Convert.ToInt32(row.Cells[4].Value);


                    if (QtdEstoque < QtdMinima)
                    {
                        row.DefaultCellStyle.BackColor = Color.Salmon;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (QtdEstoque > QtdMinima)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (QtdEstoque == QtdMinima)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLegendas_Click(object sender, EventArgs e)
        {
            new frmLegendaEstoque { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }
    }
}

