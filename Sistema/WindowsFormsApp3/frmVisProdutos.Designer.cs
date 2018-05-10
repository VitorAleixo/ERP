namespace WindowsFormsApp3
{
    partial class frmVisProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisProdutos));
            this.label1 = new System.Windows.Forms.Label();
            this.grdGerenciamento = new System.Windows.Forms.DataGridView();
            this.Codigo_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLegendas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Visualização de Produtos";
            // 
            // grdGerenciamento
            // 
            this.grdGerenciamento.AllowUserToAddRows = false;
            this.grdGerenciamento.AllowUserToDeleteRows = false;
            this.grdGerenciamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdGerenciamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGerenciamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Produto,
            this.Nome_Produto,
            this.UM_Produto,
            this.Preco_Produto});
            this.grdGerenciamento.Location = new System.Drawing.Point(12, 40);
            this.grdGerenciamento.Name = "grdGerenciamento";
            this.grdGerenciamento.ReadOnly = true;
            this.grdGerenciamento.Size = new System.Drawing.Size(680, 299);
            this.grdGerenciamento.TabIndex = 4;
            this.grdGerenciamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGerenciamento_CellDoubleClick);
            this.grdGerenciamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdGerenciamento_CellFormatting);
            this.grdGerenciamento.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdGerenciamento_PreviewKeyDown);
            // 
            // Codigo_Produto
            // 
            this.Codigo_Produto.DataPropertyName = "Codigo_Produto";
            this.Codigo_Produto.HeaderText = "Código do Produto";
            this.Codigo_Produto.Name = "Codigo_Produto";
            this.Codigo_Produto.ReadOnly = true;
            // 
            // Nome_Produto
            // 
            this.Nome_Produto.DataPropertyName = "Nome_Produto";
            this.Nome_Produto.HeaderText = "Nome do Produto";
            this.Nome_Produto.Name = "Nome_Produto";
            this.Nome_Produto.ReadOnly = true;
            // 
            // UM_Produto
            // 
            this.UM_Produto.DataPropertyName = "UM_Produto";
            this.UM_Produto.HeaderText = "Unidade de Medida";
            this.UM_Produto.Name = "UM_Produto";
            this.UM_Produto.ReadOnly = true;
            // 
            // Preco_Produto
            // 
            this.Preco_Produto.DataPropertyName = "Preco_Produto";
            this.Preco_Produto.HeaderText = "Preço";
            this.Preco_Produto.Name = "Preco_Produto";
            this.Preco_Produto.ReadOnly = true;
            // 
            // btnLegendas
            // 
            this.btnLegendas.Image = global::WindowsFormsApp3.Properties.Resources.btnLegendas;
            this.btnLegendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLegendas.Location = new System.Drawing.Point(12, 345);
            this.btnLegendas.Name = "btnLegendas";
            this.btnLegendas.Size = new System.Drawing.Size(75, 23);
            this.btnLegendas.TabIndex = 3;
            this.btnLegendas.Text = "Legendas";
            this.btnLegendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLegendas.UseVisualStyleBackColor = true;
            this.btnLegendas.Click += new System.EventHandler(this.btnLegendas_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::WindowsFormsApp3.Properties.Resources.btnSair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(636, 345);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmVisProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.btnLegendas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdGerenciamento);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento";
            this.Load += new System.EventHandler(this.frmVisProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdGerenciamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UM_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_Produto;
        private System.Windows.Forms.Button btnLegendas;
    }
}