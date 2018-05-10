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
    public partial class frmSolicitacaoCompraRelatorio : Form
    {
        public frmSolicitacaoCompraRelatorio()
        {
            InitializeComponent();
        }
        ReportDocument report = new ReportDocument();

        void CarregarRelatorio()
        {
             report.Load("relSolicitacaoCompra.rpt");

            report.SetDataSource(Relatorio.Compra(Pedido));

            crvReport2.ReportSource = report;
            crvReport2.Show();
        }
        public int Pedido { get; set; }

        private void frmSolicitacaoCompraRelatorio_Load(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }
    }
}
