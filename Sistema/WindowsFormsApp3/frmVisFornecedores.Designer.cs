﻿namespace WindowsFormsApp3
{
    partial class frmVisFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisFornecedores));
            this.label1 = new System.Windows.Forms.Label();
            this.grdGerenciamento = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLegendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Visualização de Fornecedores";
            // 
            // grdGerenciamento
            // 
            this.grdGerenciamento.AllowUserToAddRows = false;
            this.grdGerenciamento.AllowUserToDeleteRows = false;
            this.grdGerenciamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdGerenciamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGerenciamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.CEP,
            this.Estado,
            this.Telefone,
            this.Email});
            this.grdGerenciamento.Location = new System.Drawing.Point(12, 40);
            this.grdGerenciamento.Name = "grdGerenciamento";
            this.grdGerenciamento.ReadOnly = true;
            this.grdGerenciamento.Size = new System.Drawing.Size(680, 299);
            this.grdGerenciamento.TabIndex = 4;
            this.grdGerenciamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGerenciamento_CellDoubleClick);
            this.grdGerenciamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdGerenciamento_CellFormatting);
            this.grdGerenciamento.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdGerenciamento_PreviewKeyDown);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome / Razão Social";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF / CNPJ";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "CEP";
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::WindowsFormsApp3.Properties.Resources.btnSair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(636, 345);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLegendas
            // 
            this.btnLegendas.Image = global::WindowsFormsApp3.Properties.Resources.btnLegendas;
            this.btnLegendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLegendas.Location = new System.Drawing.Point(12, 345);
            this.btnLegendas.Name = "btnLegendas";
            this.btnLegendas.Size = new System.Drawing.Size(75, 23);
            this.btnLegendas.TabIndex = 6;
            this.btnLegendas.Text = "Legendas";
            this.btnLegendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLegendas.UseVisualStyleBackColor = true;
            this.btnLegendas.Click += new System.EventHandler(this.btnLegendas_Click);
            // 
            // frmVisFornecedores
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
            this.Name = "frmVisFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento";
            this.Load += new System.EventHandler(this.frmVisFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdGerenciamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button btnLegendas;
    }
}