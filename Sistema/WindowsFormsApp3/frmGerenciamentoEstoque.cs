using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.AppCode;
using WindowsFormsApp3.localhost;

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
                    var QtdEstoque = Convert.ToDouble(row.Cells[3].Value);
                    var QtdMaxima = Convert.ToDouble(row.Cells[4].Value);
                    var QtdMinima = Convert.ToDouble(row.Cells[5].Value);


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

        public ArrayList lista { get; set; }
        private void btnSolicCompra_Click(object sender, EventArgs e)
        {
            grdGerenciamento.CurrentCell = null;
            int i = 0;
            lista = new ArrayList();
            foreach (DataGridViewRow row in grdGerenciamento.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    this.grdGerenciamento.Rows[row.Index].Selected = true;

                    var OBJ = (Estoque) row.DataBoundItem;

                    lista.Add(OBJ);
                    i = i + 1;
                }

                else
                {
                    this.grdGerenciamento.Rows[row.Index].Selected = false;
                }
                
            }
            PreencherLista.Preencher = lista;

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

