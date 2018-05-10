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

namespace WindowsFormsApp3
{
    public partial class frmPedidoCompra : Form
    {
        public frmPedidoCompra()
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

        private void frmSolicitacaoCompra_Load(object sender, EventArgs e)
        {
            frmGerenciamentoEstoque gerencia = new frmGerenciamentoEstoque();
            
            txtSolicitante.Text = SessaoSistema.NomeUsuario;

            cmbUrgencia.SelectedIndex = 0;
            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = PreencherLista.Preencher ;
            grdGerenciamento.Show();
        }

        private void btnGrSolic_Click(object sender, EventArgs e)
        {
            try
            {
                localhostAmx.Almoxarifado solicitacao = new localhostAmx.Almoxarifado();
                double Valor = 0;
                double ValorTotal = 0;
                double valor1 = 0;
                double valor2 = 0;

                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {
                        valor1 = Double.Parse(row.Cells[3].Value.ToString());
                        valor2 = Double.Parse(row.Cells[7].Value.ToString());
                        Valor = valor1 * valor2;
                        ValorTotal = ValorTotal + Valor;
                }
                txtValor.Text = ValorTotal.ToString("N2");
                DialogResult dialogResult = MessageBox.Show("Gerar uma Solicitação de Compra?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string Solicitante = txtSolicitante.Text;
                    string Urgencia = cmbUrgencia.SelectedItem.ToString();
                    string Motivo = txtMotivo.Text;
                    string Tipo = BuscarTipo.BuscaTipo;
                    ValorTotal = Double.Parse(txtValor.Text.Replace(",","").Replace(".",","));
                    bool Gravar = false;
                    bool GravarItem = false;

                    if (Urgencia == "" || Urgencia == null || Motivo == "" || Motivo == null || Solicitante == "" || Solicitante == null)
                    {
                        MessageBox.Show("Algum dado está faltando!", "Confirmação", MessageBoxButtons.OK);
                    }
                    else
                    {

                        int IdPedido = solicitacao.GerarPedido(Solicitante, Urgencia, Motivo, Tipo, ValorTotal);

                        if (IdPedido > 0)
                        {
                            Gravar = true;

                            foreach (DataGridViewRow row in grdGerenciamento.Rows)
                            {
                                var obj = (localhostAmx.Estoque)grdGerenciamento.CurrentRow.DataBoundItem;
                                string Cod = row.Cells[0].Value.ToString();
                                string Nome = row.Cells[1].Value.ToString();
                                string UnidadeMedida = row.Cells[2].Value.ToString();
                                double Preco = Convert.ToDouble(row.Cells[3].Value);
                                double QtdEstoque = Convert.ToDouble(row.Cells[4].Value);
                                double QtdMinima = Convert.ToDouble(row.Cells[5].Value);
                                double QtdMaxima = Convert.ToDouble(row.Cells[6].Value);
                                double Solicitar = Convert.ToDouble(row.Cells[7].Value);

                                if (solicitacao.GerarPedidoItem(Cod, Nome, QtdEstoque, QtdMaxima, QtdMinima, UnidadeMedida, Solicitar, IdPedido))
                                {
                                    GravarItem = true;
                                }
                            }
                        }

                        if (Gravar == true && GravarItem == true)
                        {

                            MessageBox.Show("Pedido de Compra realizado com Sucesso!", "Confirmação", MessageBoxButtons.OK);
                            frmSolicitacaoCompraRelatorio relatorioCompra = new frmSolicitacaoCompraRelatorio();
                            relatorioCompra.Pedido = IdPedido;
                            relatorioCompra.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um Erro ao gravar o Pedido de Compra!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro! \nDados do Erro:\n   " + ex.ToString(), "Confirmação", MessageBoxButtons.OK);
            }
            }

        private void grdGerenciamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {
           
                    var QtdEstoque = Convert.ToDouble(row.Cells[4].Value);
                    var QtdMinima = Convert.ToDouble(row.Cells[5].Value);
                    var QtdMaxima = Convert.ToDouble(row.Cells[6].Value);
                    var Solicitar = Convert.ToDouble(row.Cells[7].Value);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLegendas_Click(object sender, EventArgs e)
        {
            new frmLegendaSolicitacao { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }
    }
}
