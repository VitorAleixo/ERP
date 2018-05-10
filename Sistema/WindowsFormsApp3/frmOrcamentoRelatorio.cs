using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
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
    public partial class frmOrcamentoRelatorio : Form
    {
        public frmOrcamentoRelatorio()
        {
            InitializeComponent();
        }

        ReportDocument report = new ReportDocument();

        void CarregarRelatorio()
        {
            report.Load("relOrcamento.rpt");

            report.SetDataSource(Relatorio.Orcamento(Pedido));

            crvReport3.ReportSource = report;
            crvReport3.Show();
        }
        public int Pedido { get; set; }

        private void frmOrcamentoRelatorio_Load(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }
    }
}
