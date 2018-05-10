using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.localhostCmp;

namespace WindowsFormsApp3
{
    public partial class frmGerarOrcamento : Form
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
        public frmGerarOrcamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLegendas_Click(object sender, EventArgs e)
        {
            new frmLegendaSolic { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        public void CarregarGrid()
        {
            localhostCmp.Compras buscaSolicitacao = new localhostCmp.Compras();

            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = buscaSolicitacao.RetornarSolicitacao();
            grdGerenciamento.Show();
        }

        private void frmGerarOrcamento_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void grdGerenciamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {
                    string RowType = row.Cells[1].Value.ToString();

                    if (RowType == "Nivel 1 - Normal")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "Nivel 2 - Mediana")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "Nivel 3 - Urgente")
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

        private void btnGerarOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (Solicitacao)grdGerenciamento.CurrentRow.DataBoundItem;
                frmPreencherOrcamento frmPreencher = new frmPreencherOrcamento();
                frmPreencher.txtIdPedido.Text = obj.IdPedido.ToString();
                frmPreencher.txtTipo.Text = obj.Tipo.ToString();
                frmPreencher.txtValor.Text = obj.Valor.ToString("N2");
                frmPreencher.ShowDialog();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Nenhum Item Selecionado!", "Confirmação", MessageBoxButtons.OK);
            }
        }
    }
}
