namespace WindowsFormsApp3
{
    partial class frmPedidoCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoCompra));
            this.grdGerenciamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUrgencia = new System.Windows.Forms.ComboBox();
            this.btnLegendas = new System.Windows.Forms.Button();
            this.btnGrSolic = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.CodigoProduto,
            this.Nome,
            this.UM,
            this.Preco,
            this.QtdEstoque,
            this.QtdMinima,
            this.QtdMaxima,
            this.Solicitar});
            this.grdGerenciamento.Location = new System.Drawing.Point(12, 122);
            this.grdGerenciamento.Name = "grdGerenciamento";
            this.grdGerenciamento.Size = new System.Drawing.Size(705, 246);
            this.grdGerenciamento.TabIndex = 2;
            this.grdGerenciamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdGerenciamento_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Solicitante :";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Enabled = false;
            this.txtSolicitante.Location = new System.Drawing.Point(77, 23);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(274, 20);
            this.txtSolicitante.TabIndex = 4;
            this.txtSolicitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(408, 23);
            this.txtMotivo.MaxLength = 1000;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(309, 93);
            this.txtMotivo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Motivo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Urgencia :";
            // 
            // cmbUrgencia
            // 
            this.cmbUrgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrgencia.FormattingEnabled = true;
            this.cmbUrgencia.Items.AddRange(new object[] {
            "Nivel 1 - Normal",
            "Nivel 2 - Mediana",
            "Nivel 3 - Urgente"});
            this.cmbUrgencia.Location = new System.Drawing.Point(77, 56);
            this.cmbUrgencia.Name = "cmbUrgencia";
            this.cmbUrgencia.Size = new System.Drawing.Size(274, 21);
            this.cmbUrgencia.TabIndex = 9;
            // 
            // btnLegendas
            // 
            this.btnLegendas.Image = global::WindowsFormsApp3.Properties.Resources.btnLegendas;
            this.btnLegendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLegendas.Location = new System.Drawing.Point(12, 374);
            this.btnLegendas.Name = "btnLegendas";
            this.btnLegendas.Size = new System.Drawing.Size(75, 23);
            this.btnLegendas.TabIndex = 10;
            this.btnLegendas.Text = "Legendas";
            this.btnLegendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLegendas.UseVisualStyleBackColor = true;
            this.btnLegendas.Click += new System.EventHandler(this.btnLegendas_Click);
            // 
            // btnGrSolic
            // 
            this.btnGrSolic.Image = global::WindowsFormsApp3.Properties.Resources.btnSolCompra16;
            this.btnGrSolic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrSolic.Location = new System.Drawing.Point(504, 374);
            this.btnGrSolic.Name = "btnGrSolic";
            this.btnGrSolic.Size = new System.Drawing.Size(151, 23);
            this.btnGrSolic.TabIndex = 7;
            this.btnGrSolic.Text = "Gerar Pedido de Compra";
            this.btnGrSolic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrSolic.UseVisualStyleBackColor = true;
            this.btnGrSolic.Click += new System.EventHandler(this.btnGrSolic_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::WindowsFormsApp3.Properties.Resources.btnSair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(661, 374);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(77, 90);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(274, 20);
            this.txtValor.TabIndex = 12;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Total";
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.DataPropertyName = "CodigoProduto";
            this.CodigoProduto.HeaderText = "Código do Produto";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome do Produto";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // UM
            // 
            this.UM.DataPropertyName = "UM";
            this.UM.HeaderText = "Unidade de Medida";
            this.UM.Name = "UM";
            this.UM.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle1;
            this.Preco.HeaderText = "Preco Unitário";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // QtdEstoque
            // 
            this.QtdEstoque.DataPropertyName = "QtdEstoque";
            this.QtdEstoque.HeaderText = "QtdEstoque";
            this.QtdEstoque.Name = "QtdEstoque";
            this.QtdEstoque.ReadOnly = true;
            // 
            // QtdMinima
            // 
            this.QtdMinima.DataPropertyName = "QtdMinima";
            this.QtdMinima.HeaderText = "QtdMinima";
            this.QtdMinima.Name = "QtdMinima";
            this.QtdMinima.ReadOnly = true;
            // 
            // QtdMaxima
            // 
            this.QtdMaxima.DataPropertyName = "QtdMaxima";
            this.QtdMaxima.HeaderText = "QtdMaxima";
            this.QtdMaxima.Name = "QtdMaxima";
            this.QtdMaxima.ReadOnly = true;
            // 
            // Solicitar
            // 
            this.Solicitar.DataPropertyName = "Solicitar";
            this.Solicitar.HeaderText = "A Solicitar";
            this.Solicitar.Name = "Solicitar";
            // 
            // frmPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 409);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLegendas);
            this.Controls.Add(this.cmbUrgencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGrSolic);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdGerenciamento);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Compra";
            this.Load += new System.EventHandler(this.frmSolicitacaoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.DataGridView grdGerenciamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGrSolic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUrgencia;
        private System.Windows.Forms.Button btnLegendas;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdMaxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitar;
    }
}