using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp3
{
    public partial class frmVisProdutos : Form
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

        public frmVisProdutos()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            localhost.Login buscaProduto = new localhost.Login();

            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = buscaProduto.RetornaProduto();
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
        //Cores na grid
        private void grdGerenciamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {
                    string RowType = row.Cells[2].Value.ToString();

                    if (RowType == "KG")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "MG")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "G")
                    {
                        row.DefaultCellStyle.BackColor = Color.Cyan;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "L")
                    {
                        row.DefaultCellStyle.BackColor = Color.NavajoWhite;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "ML")
                    {
                        row.DefaultCellStyle.BackColor = Color.Orange;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "UNIDADE")
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

        private void frmVisProdutos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnLegendas_Click(object sender, EventArgs e)
        {
            new frmLegendaProdutos { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }
    }
}
