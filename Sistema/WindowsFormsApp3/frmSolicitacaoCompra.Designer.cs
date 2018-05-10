﻿namespace WindowsFormsApp3
{
    partial class frmSolicitacaoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitacaoCompra));
            this.btnSair = new System.Windows.Forms.Button();
            this.grdGerenciamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrSolic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUrgencia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).BeginInit();
            this.SuspendLayout();
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
            this.QtdEstoque,
            this.QtdMinima,
            this.QtdMaxima,
            this.Solicitar});
            this.grdGerenciamento.Location = new System.Drawing.Point(12, 122);
            this.grdGerenciamento.Name = "grdGerenciamento";
            this.grdGerenciamento.Size = new System.Drawing.Size(705, 246);
            this.grdGerenciamento.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 93);
            this.textBox1.TabIndex = 6;
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
            // btnGrSolic
            // 
            this.btnGrSolic.Image = global::WindowsFormsApp3.Properties.Resources.btnSolCompra16;
            this.btnGrSolic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrSolic.Location = new System.Drawing.Point(486, 374);
            this.btnGrSolic.Name = "btnGrSolic";
            this.btnGrSolic.Size = new System.Drawing.Size(169, 23);
            this.btnGrSolic.TabIndex = 7;
            this.btnGrSolic.Text = "Gerar Solicitação de Compra";
            this.btnGrSolic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrSolic.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 99);
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
            this.cmbUrgencia.Location = new System.Drawing.Point(77, 94);
            this.cmbUrgencia.Name = "cmbUrgencia";
            this.cmbUrgencia.Size = new System.Drawing.Size(274, 21);
            this.cmbUrgencia.TabIndex = 9;
            // 
            // frmSolicitacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 409);
            this.Controls.Add(this.cmbUrgencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGrSolic);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdGerenciamento);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSolicitacaoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitação de Compra";
            this.Load += new System.EventHandler(this.frmSolicitacaoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGerenciamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView grdGerenciamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdMaxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGrSolic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUrgencia;
    }
}