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

        private void CarregarGrid()
        {
            localhost.Login buscaEstoque = new localhost.Login();


            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = buscaEstoque.RetornaEstoque();
            grdGerenciamento.Show();

            txtNumeroProdutos.Text = grdGerenciamento.RowCount.ToString();
        }

        private void frmGerenciamentoEstoque_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void grdGerenciamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {
                    var QtdEstoque = Convert.ToInt32(row.Cells[3].Value);
                    var QtdMaxima = Convert.ToInt32(row.Cells[4].Value);
                    var QtdMinima = Convert.ToInt32(row.Cells[5].Value);


                    if (QtdEstoque < QtdMinima)
                    {
                        row.DefaultCellStyle.BackColor = Color.Salmon;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (QtdEstoque >= QtdMinima && QtdEstoque <= (QtdMaxima / 2))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (QtdEstoque > (QtdMaxima/2))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
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

        private void btnSolicCompra_Click(object sender, EventArgs e)
        {
            grdGerenciamento.CurrentCell = null;
            int i = 0;
            foreach (DataGridViewRow dr in grdGerenciamento.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if ((bool)(dr.Cells[0].Value) == true)
                    {
                        this.grdGerenciamento.Rows[dr.Index].Selected = true;
                        i = i + 1;
                    }
                    else
                    {
                        this.grdGerenciamento.Rows[dr.Index].Selected = false;
                    }
                }
            }
            if (i == 0)
            {
                MessageBox.Show("Nenhum item selecionado! \nNão foi possível criar Solicitação de Compra!", "ERRO!", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Confirma os itens selecionados?\n" + i + " Itens selecionados.", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new frmSolicitacaoCompra { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
                }
            }
        }
    }
}

