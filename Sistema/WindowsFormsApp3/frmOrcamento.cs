using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.localhost;

namespace WindowsFormsApp3
{
    public partial class frmOrcamento : Form
    {
        public frmOrcamento()
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

        private void CarregarGrid()
        {
            localhostGrc.Gerencia buscaDadosOrcamento = new localhostGrc.Gerencia();

            int IdPedido = Convert.ToInt32(txtIdPedido.Text);
            int IdVendedor = Convert.ToInt32(txtVendedor.Text);

            txtVendedor.Text = buscaDadosOrcamento.RetornaVendedor(IdVendedor);

            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = buscaDadosOrcamento.RetornaDadosOrcamento(IdPedido);
            grdGerenciamento.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrcamento_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            try
            {
                localhostGrc.Gerencia aprovacao = new localhostGrc.Gerencia();

                if (aprovacao.Aprovar(Convert.ToInt32(txtIdPedido.Text)) == true)
                {
                    MessageBox.Show("O Orçamento foi Aprovado com Sucesso!", "Confirmação", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("O Orçamento não pode ser Aprovado", "Confirmação", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReprovar_Click(object sender, EventArgs e)
        {
            try
            {
                localhostGrc.Gerencia aprovacao = new localhostGrc.Gerencia();

                if (aprovacao.Reprovar(Convert.ToInt32(txtIdPedido.Text)) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Tem certeza que quer reprovar esse orçamento?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("O Orçamento foi Reprovado!", "Confirmação", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("O Orçamento não pode ser Reprovado", "Confirmação", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
    }
}
