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
                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {

                    var QtdEstoque = Convert.ToDouble(row.Cells[3].Value);
                    var QtdMinima = Convert.ToDouble(row.Cells[4].Value);
                    var QtdMaxima = Convert.ToDouble(row.Cells[5].Value);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que quer excluir esta Solicitação de Compra?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
        }

        private void btnLegendas_Click(object sender, EventArgs e)
        {
            new frmLegendaEstoque { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }
    }   
}
