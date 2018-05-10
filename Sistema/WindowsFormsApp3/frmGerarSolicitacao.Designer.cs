namespace WindowsFormsApp3
{
    partial class frmGerarSolicitacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarSolicitacao));
            this.grdGerenciamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSolicCompra = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLegendas = new System.Windows.Forms.Button();
            this.Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).BeginInit();
            this.SuspendLayout();
            // 
            // grdGerenciamento
            // 
            this.grdGerenciamento.AllowUserToAddRows = false;
            this.grdGerenciamento.AllowUserToDeleteRows = false;
            this.grdGerenciamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdGerenciamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGerenciamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Solicitante,
            this.Urgencia,
            this.DataCriacao,
            this.Tipo,
            this.Status});
            this.grdGerenciamento.Location = new System.Drawing.Point(12, 37);
            this.grdGerenciamento.Name = "grdGerenciamento";
            this.grdGerenciamento.ReadOnly = true;
            this.grdGerenciamento.Size = new System.Drawing.Size(705, 309);
            this.grdGerenciamento.TabIndex = 3;
            this.grdGerenciamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdGerenciamento_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Solicitações de Compra";
            // 
            // btnSolicCompra
            // 
            this.btnSolicCompra.Image = global::WindowsFormsApp3.Properties.Resources.btnGerarSolicitacaoDeCompra;
            this.btnSolicCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicCompra.Location = new System.Drawing.Point(486, 352);
            this.btnSolicCompra.Name = "btnSolicCompra";
            this.btnSolicCompra.Size = new System.Drawing.Size(168, 23);
            this.btnSolicCompra.TabIndex = 21;
            this.btnSolicCompra.Text = "Gerar Solicitação de Compra";
            this.btnSolicCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSolicCompra.UseVisualStyleBackColor = true;
            this.btnSolicCompra.Click += new System.EventHandler(this.btnSolicCompra_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::WindowsFormsApp3.Properties.Resources.btnSair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(660, 352);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLegendas
            // 
            this.btnLegendas.Image = global::WindowsFormsApp3.Properties.Resources.btnLegendas;
            this.btnLegendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLegendas.Location = new System.Drawing.Point(12, 352);
            this.btnLegendas.Name = "btnLegendas";
            this.btnLegendas.Size = new System.Drawing.Size(75, 23);
            this.btnLegendas.TabIndex = 22;
            this.btnLegendas.Text = "Legendas";
            this.btnLegendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLegendas.UseVisualStyleBackColor = true;
            this.btnLegendas.Click += new System.EventHandler(this.btnLegendas_Click);
            // 
            // Solicitante
            // 
            this.Solicitante.DataPropertyName = "Solicitante";
            this.Solicitante.HeaderText = "Solicitante";
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.ReadOnly = true;
            // 
            // Urgencia
            // 
            this.Urgencia.DataPropertyName = "Urgencia";
            this.Urgencia.HeaderText = "Urgencia";
            this.Urgencia.Name = "Urgencia";
            this.Urgencia.ReadOnly = true;
            // 
            // DataCriacao
            // 
            this.DataCriacao.DataPropertyName = "DataCriacao";
            this.DataCriacao.HeaderText = "DataCriacao";
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // frmGerarSolicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 380);
            this.Controls.Add(this.btnLegendas);
            this.Controls.Add(this.btnSolicCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grdGerenciamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerarSolicitacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Solicitação de Compras";
            this.Load += new System.EventHandler(this.frmGerarSolicitacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView grdGerenciamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSolicCompra;
        private System.Windows.Forms.Button btnLegendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}