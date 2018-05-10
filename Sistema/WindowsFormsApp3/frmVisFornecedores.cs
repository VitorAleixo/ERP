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
    public partial class frmVisFornecedores : Form
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

        public frmVisFornecedores()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            localhostCmp.Compras buscaFornecedor = new localhostCmp.Compras();

            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = buscaFornecedor.RetornaFornecedor();
            grdGerenciamento.Show();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Editar
        private void grdGerenciamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Delete
        private void grdGerenciamento_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        //Cores na Grid
        private void grdGerenciamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {
                    string RowType = row.Cells[1].Value.ToString();

                    if (RowType.Length == 14)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType.Length == 18)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType.Length == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Salmon;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVisFornecedores_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnLegendas_Click(object sender, EventArgs e)
        {
            new frmLegendaFornecedores { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }
    }
}
