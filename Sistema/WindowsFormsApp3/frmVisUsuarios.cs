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
    public partial class frmVisUsuarios : Form
    {
        public frmVisUsuarios()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVisUsuarios_Load(object sender, EventArgs e)
        {
            localhost.Login buscaUsuario = new localhost.Login();

            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = buscaUsuario.RetornaUsuario();
            grdGerenciamento.Show();
        }

        private void grdGerenciamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {
                    string RowType = row.Cells[2].Value.ToString();

                    if (RowType == "ADMINISTRATIVO")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "ADMIN")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "ALMOXARIFADO")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "COMPRAS")
                    {
                        row.DefaultCellStyle.BackColor = Color.Cyan;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "COMERCIAL")
                    {
                        row.DefaultCellStyle.BackColor = Color.NavajoWhite;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "COMEX")
                    {
                        row.DefaultCellStyle.BackColor = Color.Orange;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "CUSTO")
                    {
                        row.DefaultCellStyle.BackColor = Color.Fuchsia;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "DIRETORIA")
                    {
                        row.DefaultCellStyle.BackColor = Color.Crimson;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "ENGENHARIA")
                    {
                        row.DefaultCellStyle.BackColor = Color.Gainsboro;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "MARKETING")
                    {
                        row.DefaultCellStyle.BackColor = Color.Chocolate;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "FINANCEIRO")
                    {
                        row.DefaultCellStyle.BackColor = Color.Gold;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "PCP")
                    {
                        row.DefaultCellStyle.BackColor = Color.Lavender;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "PRODUÇÃO")
                    {
                        row.DefaultCellStyle.BackColor = Color.Khaki;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "QUALIDADE")
                    {
                        row.DefaultCellStyle.BackColor = Color.HotPink;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "R.H.")
                    {
                        row.DefaultCellStyle.BackColor = Color.Turquoise ;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "SEG. DO TRABALHO")
                    {
                        row.DefaultCellStyle.BackColor = Color.PapayaWhip;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "T.I.")
                    {
                        row.DefaultCellStyle.BackColor = Color.Plum;
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
            new frmLegendaUsuarios { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }
    }
}
