namespace WindowsFormsApp3
{
    partial class frmSolicitacaoCompraRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitacaoCompraRelatorio));
            this.crvReport2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReport2
            // 
            this.crvReport2.ActiveViewIndex = -1;
            this.crvReport2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReport2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReport2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReport2.Location = new System.Drawing.Point(0, 0);
            this.crvReport2.Name = "crvReport2";
            this.crvReport2.Size = new System.Drawing.Size(705, 505);
            this.crvReport2.TabIndex = 0;
            // 
            // frmSolicitacaoCompraRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 505);
            this.Controls.Add(this.crvReport2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSolicitacaoCompraRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Solicitação de Compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSolicitacaoCompraRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReport2;
    }
}