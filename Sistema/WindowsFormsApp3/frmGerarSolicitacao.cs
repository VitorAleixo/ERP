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
    public partial class frmGerarSolicitacao : Form
    {
        public frmGerarSolicitacao()
        {
            InitializeComponent();
        }
        
        void CarregarGrid()
        {
            localhost.Login buscaSolicitacaoCompras = new localhost.Login();

            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = buscaSolicitacaoCompras.RetornaSolicitacaoDeCompra();
            grdGerenciamento.Show();
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

        private void frmGerarSolicitacao_Load(object sender, EventArgs e)
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

        private void btnLegendas_Click(object sender, EventArgs e)
        {
            new frmLegendaSolic { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void btnSolicCompra_Click(object sender, EventArgs e)
        {
            //GERA RELATORIO
            //IF RELATORIO GERADO
            //UPDATE PARA PEDIDO GERADO
            //MENSAGEM
            //CARREGAGRID
        }
    }
}
