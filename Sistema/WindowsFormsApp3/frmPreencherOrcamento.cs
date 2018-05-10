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
    public partial class frmPreencherOrcamento : Form
    {
        public frmPreencherOrcamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void grdGerenciamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int i = 0;
                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {
                    i = i + 1;
                    var QtdEstoque = Convert.ToDouble(row.Cells[3].Value);
                    var QtdMaxima = Convert.ToDouble(row.Cells[4].Value);
                    var QtdMinima = Convert.ToDouble(row.Cells[5].Value);
                    var Solicitar = Convert.ToDouble(row.Cells[6].Value);

                    if (Solicitar == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Cyan;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (QtdEstoque + Solicitar < QtdMinima)
                    {
                        row.DefaultCellStyle.BackColor = Color.Salmon;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (QtdEstoque + Solicitar >= QtdMinima && QtdEstoque + Solicitar <= (QtdMaxima / 2))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (QtdEstoque + Solicitar > (QtdMaxima / 2))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                txtQuantidade.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGrid()
        {
            localhostCmp.Compras buscaSolicitacaoItem = new localhostCmp.Compras();

            int IdPedido = Convert.ToInt32(txtIdPedido.Text);

            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = buscaSolicitacaoItem.RetornaSolicitacaoItem(IdPedido);
            grdGerenciamento.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que quer excluir esta Solicitação de Compra?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                localhostCmp.Compras deletarSolicitacao = new localhostCmp.Compras();

                int IdPedido = Convert.ToInt32(txtIdPedido.Text);

                if (deletarSolicitacao.Arquivar(IdPedido) == true)
                {
                  MessageBox.Show("Solicitação Excluída com Sucesso!", "Confirmação", MessageBoxButtons.OK);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Solicitação não pode ser Excluída!", "Confirmação", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLegendas_Click(object sender, EventArgs e)
        {
            new frmLegendaGerenciamento { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void frmPreencherOrcamento_Load(object sender, EventArgs e)
        {
            txtDataEmissao.Text = DateTime.Now.ToString("dd/MM/yyyy");

            localhostCmp.Compras buscaFornecedor = new localhostCmp.Compras();

            cmbVendedor.DisplayMember = "Nome";
            cmbVendedor.ValueMember = "Id";
            cmbVendedor.DataSource = buscaFornecedor.RetornaComboFornecedor();
            CarregarGrid();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Gerar Orçamento deste Pedido?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int IdPedido = Convert.ToInt32(txtIdPedido.Text);
                    string Tipo = txtTipo.Text;
                    string DataEmissao = txtDataEmissao.Text;
                    string Observacoes = txtObservacoes.Text;
                    string Vendedor = cmbVendedor.SelectedValue.ToString();
                    string PrazoEntrega = txtPrazo.Text;
                    string CondicaoPag = txtCondicaoPag.Text;
                    double ValorAdicional = Convert.ToDouble(txtValorAdicional.Text.Replace(",", "").Replace(".", ","));
                    double Valor = Convert.ToDouble(txtValor.Text.Replace(",", "").Replace(".", ","));
                    int QtdItens = Convert.ToInt32(txtQuantidade.Text);

                    localhostCmp.Compras gravarOrcamento = new localhostCmp.Compras();

                    localhostCmp.Compras Atualiza = new localhostCmp.Compras();
                    if (gravarOrcamento.GravarOrcamento(IdPedido, Tipo, DataEmissao, Observacoes, Vendedor, PrazoEntrega, CondicaoPag, ValorAdicional, Valor, QtdItens) == true)
                    {
                        if (Atualiza.Atualizar(IdPedido) == true)
                        {
                            MessageBox.Show("Orçamento Gravado!!", "Confirmação", MessageBoxButtons.OK);

                            frmOrcamentoRelatorio relatorioOrcamento = new frmOrcamentoRelatorio();
                            relatorioOrcamento.Pedido = IdPedido;
                            relatorioOrcamento.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar Orçamento!!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível gravar Orçamento!!", "Confirmação", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Nenhum Item Selecionado!", "Confirmação", MessageBoxButtons.OK);
            }
        }
    }
}   

