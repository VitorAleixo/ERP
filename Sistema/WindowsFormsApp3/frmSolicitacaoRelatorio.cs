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
            ConfiguraParametros();
            ConfiguraBD();


            crvReport.ReportSource = report;
            crvReport.Show();
        }
        public int Pedido { get; set; }

        void ConfiguraParametros()
        {
            report.Load("relPedidorpt.rpt");

            ParameterFieldDefinitions par = report.DataDefinition.ParameterFields;

            par["@PEDIDO"].CurrentValues.AddValue(Pedido);

            par["@PEDIDO"].ApplyCurrentValues(par["@PEDIDO"].CurrentValues);

        }

        void ConfiguraBD()
        {

            if (report == null)
            {
                return;
            }

            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            crConnectionInfo.ServerName = "SERVER05";
            crConnectionInfo.DatabaseName = "Estoque";
            crConnectionInfo.UserID = "ENTERPRISING";
            crConnectionInfo.Password = "ENTERPRISING";

            TableLogOnInfos crTableLogonInfos = new TableLogOnInfos();
            TableLogOnInfo crTableLogonInfo = new TableLogOnInfo();
            Tables crTables;

            // Each table in report needs to have logoninfo setup:
            crTables = report.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table crTable in crTables)
            {
                crTableLogonInfo = crTable.LogOnInfo;
                crTableLogonInfo.ConnectionInfo = crConnectionInfo;
                crTable.ApplyLogOnInfo(crTableLogonInfo);
            }


        }

        private void frmSolicitacaoRelatorio_Load(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }
    }
}
