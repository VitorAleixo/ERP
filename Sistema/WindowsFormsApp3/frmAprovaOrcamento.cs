﻿using System;
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
    public partial class frmAprovaOrcamento : Form
    {
        public frmAprovaOrcamento()
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

        void CarregarGrid()
        {
            localhost.Login buscarOrcamentos = new localhost.Login();

            grdGerenciamento.AutoGenerateColumns = false;
            grdGerenciamento.DataSource = null;
            grdGerenciamento.DataSource = buscarOrcamentos.RetornaOrcamento();
            grdGerenciamento.Show();
        }

        private void btnLegendas_Click(object sender, EventArgs e)
        {
            new frmLegendaGerencia { StartPosition = FormStartPosition.CenterScreen }.ShowDialog();
        }

        private void frmAprovaOrcamento_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void grdGerenciamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int i = 0;
                foreach (DataGridViewRow row in grdGerenciamento.Rows)
                {
                    i = i + 1;
                    double RowType = Convert.ToDouble(row.Cells[4].Value);
                    double verde = 1500;
                    double amarelo = 5000;
                    double laranja = 10000;
                    double vermelho = 10001;

                    if (RowType <= verde)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType > verde && RowType <= amarelo)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType > amarelo && RowType <= laranja)
                    {
                        row.DefaultCellStyle.BackColor = Color.Orange;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType >= vermelho)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                txtNumeroOrcamentos.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
