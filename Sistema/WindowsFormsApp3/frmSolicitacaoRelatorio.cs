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
    public partial class frmSolicitacaoRelatorio : Form
    {
        public frmSolicitacaoRelatorio()
        {
            InitializeComponent();
        }

        ReportDocument report = new ReportDocument();

        void CarregarRelatorio()
        {
            report.Load("relPedidorpt.rpt");
            report.SetDataSource(Relatorio.CompraCompleta(Pedido));

            crvReport.ReportSource = report;
            crvReport.Show();
        }
        public int Pedido { get; set; }

        private void frmSolicitacaoRelatorio_Load(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }
    }
}
