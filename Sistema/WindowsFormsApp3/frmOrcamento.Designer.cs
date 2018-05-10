namespace WindowsFormsApp3
{
    partial class frmOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamento));
            this.grdGerenciamento = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataEmissao = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtCondicaoPag = new System.Windows.Forms.TextBox();
            this.txtPrazoEntrega = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.btnReprovar = new System.Windows.Forms.Button();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdGerenciamento
            // 
            this.grdGerenciamento.AllowUserToAddRows = false;
            this.grdGerenciamento.AllowUserToDeleteRows = false;
            this.grdGerenciamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdGerenciamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGerenciamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Nome,
            this.UnidadeMedida,
            this.Solicitar});
            this.grdGerenciamento.Location = new System.Drawing.Point(12, 165);
            this.grdGerenciamento.Name = "grdGerenciamento";
            this.grdGerenciamento.ReadOnly = true;
            this.grdGerenciamento.Size = new System.Drawing.Size(705, 200);
            this.grdGerenciamento.TabIndex = 3;
            this.grdGerenciamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdGerenciamento_CellFormatting);
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "Cod";
            this.Cod.HeaderText = "Código do Produto";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome do Produto";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // UnidadeMedida
            // 
            this.UnidadeMedida.DataPropertyName = "UnidadeMedida";
            this.UnidadeMedida.HeaderText = "Unidade de Medida";
            this.UnidadeMedida.Name = "UnidadeMedida";
            this.UnidadeMedida.ReadOnly = true;
            // 
            // Solicitar
            // 
            this.Solicitar.DataPropertyName = "Solicitar";
            this.Solicitar.HeaderText = "A Solicitar";
            this.Solicitar.Name = "Solicitar";
            this.Solicitar.ReadOnly = true;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(9, 38);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(255, 20);
            this.txtTipo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDataEmissao);
            this.groupBox1.Controls.Add(this.txtVendedor);
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.txtObservacoes);
            this.groupBox1.Controls.Add(this.txtCondicaoPag);
            this.groupBox1.Controls.Add(this.txtPrazoEntrega);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Orçamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Observações";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Valor Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Condição de Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Prazo de Entrega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data de Emissão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Enabled = false;
            this.txtDataEmissao.Location = new System.Drawing.Point(9, 77);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.ReadOnly = true;
            this.txtDataEmissao.Size = new System.Drawing.Size(255, 20);
            this.txtDataEmissao.TabIndex = 2;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(9, 120);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(255, 20);
            this.txtVendedor.TabIndex = 3;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(270, 120);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(178, 20);
            this.txtValorTotal.TabIndex = 6;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Enabled = false;
            this.txtObservacoes.Location = new System.Drawing.Point(454, 38);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.ReadOnly = true;
            this.txtObservacoes.Size = new System.Drawing.Size(244, 102);
            this.txtObservacoes.TabIndex = 7;
            // 
            // txtCondicaoPag
            // 
            this.txtCondicaoPag.Enabled = false;
            this.txtCondicaoPag.Location = new System.Drawing.Point(270, 77);
            this.txtCondicaoPag.Name = "txtCondicaoPag";
            this.txtCondicaoPag.ReadOnly = true;
            this.txtCondicaoPag.Size = new System.Drawing.Size(178, 20);
            this.txtCondicaoPag.TabIndex = 5;
            // 
            // txtPrazoEntrega
            // 
            this.txtPrazoEntrega.Enabled = false;
            this.txtPrazoEntrega.Location = new System.Drawing.Point(270, 38);
            this.txtPrazoEntrega.Name = "txtPrazoEntrega";
            this.txtPrazoEntrega.ReadOnly = true;
            this.txtPrazoEntrega.Size = new System.Drawing.Size(178, 20);
            this.txtPrazoEntrega.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::WindowsFormsApp3.Properties.Resources.btnSair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(661, 371);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 29);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAprovar
            // 
            this.btnAprovar.Image = global::WindowsFormsApp3.Properties.Resources.btnAprovar;
            this.btnAprovar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAprovar.Location = new System.Drawing.Point(582, 371);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(73, 29);
            this.btnAprovar.TabIndex = 9;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAprovar.UseVisualStyleBackColor = true;
            this.btnAprovar.Click += new System.EventHandler(this.btnAprovar_Click);
            // 
            // btnReprovar
            // 
            this.btnReprovar.Image = global::WindowsFormsApp3.Properties.Resources.btnReprovar;
            this.btnReprovar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReprovar.Location = new System.Drawing.Point(503, 371);
            this.btnReprovar.Name = "btnReprovar";
            this.btnReprovar.Size = new System.Drawing.Size(73, 29);
            this.btnReprovar.TabIndex = 8;
            this.btnReprovar.Text = "Reprovar";
            this.btnReprovar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReprovar.UseVisualStyleBackColor = true;
            this.btnReprovar.Click += new System.EventHandler(this.btnReprovar_Click);
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(13, 373);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.ReadOnly = true;
            this.txtIdPedido.Size = new System.Drawing.Size(22, 20);
            this.txtIdPedido.TabIndex = 11;
            this.txtIdPedido.Visible = false;
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 405);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.btnReprovar);
            this.Controls.Add(this.btnAprovar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdGerenciamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprovação de Orçamentos";
            this.Load += new System.EventHandler(this.frmOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView grdGerenciamento;
        public System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDataEmissao;
        public System.Windows.Forms.TextBox txtVendedor;
        public System.Windows.Forms.TextBox txtValorTotal;
        public System.Windows.Forms.TextBox txtObservacoes;
        public System.Windows.Forms.TextBox txtCondicaoPag;
        public System.Windows.Forms.TextBox txtPrazoEntrega;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.Button btnReprovar;
        public System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitar;
    }
}