namespace WindowsFormsApp3
{
    partial class frmOrcamentoRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamentoRelatorio));
            this.crvReport3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReport3
            // 
            this.crvReport3.ActiveViewIndex = -1;
            this.crvReport3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReport3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReport3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReport3.Location = new System.Drawing.Point(0, 0);
            this.crvReport3.Name = "crvReport3";
            this.crvReport3.Size = new System.Drawing.Size(764, 503);
            this.crvReport3.TabIndex = 0;
            // 
            // frmOrcamentoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 503);
            this.Controls.Add(this.crvReport3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrcamentoRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Orçamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrcamentoRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReport3;
    }
}