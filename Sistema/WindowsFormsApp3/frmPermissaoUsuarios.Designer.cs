namespace WindowsFormsApp3
{
    partial class frmPermissaoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermissaoUsuarios));
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTI = new System.Windows.Forms.Button();
            this.btnSegTrabalho = new System.Windows.Forms.Button();
            this.btnRH = new System.Windows.Forms.Button();
            this.btnQualidade = new System.Windows.Forms.Button();
            this.btnProducao = new System.Windows.Forms.Button();
            this.btnPCP = new System.Windows.Forms.Button();
            this.btnGerencia = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnMarketing = new System.Windows.Forms.Button();
            this.btnEngenharia = new System.Windows.Forms.Button();
            this.btnDiretoria = new System.Windows.Forms.Button();
            this.btnCusto = new System.Windows.Forms.Button();
            this.btnComex = new System.Windows.Forms.Button();
            this.btnComercial = new System.Windows.Forms.Button();
            this.btnContabilidade = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnAlmoxarifado = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(6, 19);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(439, 21);
            this.cmbUsuario.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTI);
            this.groupBox2.Controls.Add(this.btnSegTrabalho);
            this.groupBox2.Controls.Add(this.btnRH);
            this.groupBox2.Controls.Add(this.btnQualidade);
            this.groupBox2.Controls.Add(this.btnProducao);
            this.groupBox2.Controls.Add(this.btnPCP);
            this.groupBox2.Controls.Add(this.btnGerencia);
            this.groupBox2.Controls.Add(this.btnFinanceiro);
            this.groupBox2.Controls.Add(this.btnMarketing);
            this.groupBox2.Controls.Add(this.btnEngenharia);
            this.groupBox2.Controls.Add(this.btnDiretoria);
            this.groupBox2.Controls.Add(this.btnCusto);
            this.groupBox2.Controls.Add(this.btnComex);
            this.groupBox2.Controls.Add(this.btnComercial);
            this.groupBox2.Controls.Add(this.btnContabilidade);
            this.groupBox2.Controls.Add(this.btnCompras);
            this.groupBox2.Controls.Add(this.btnAlmoxarifado);
            this.groupBox2.Controls.Add(this.btnAdmin);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 282);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissões";
            // 
            // btnTI
            // 
            this.btnTI.Location = new System.Drawing.Point(280, 251);
            this.btnTI.Name = "btnTI";
            this.btnTI.Size = new System.Drawing.Size(165, 23);
            this.btnTI.TabIndex = 19;
            this.btnTI.Text = "TI";
            this.btnTI.UseVisualStyleBackColor = true;
            this.btnTI.Click += new System.EventHandler(this.btnTI_Click);
            // 
            // btnSegTrabalho
            // 
            this.btnSegTrabalho.Location = new System.Drawing.Point(280, 222);
            this.btnSegTrabalho.Name = "btnSegTrabalho";
            this.btnSegTrabalho.Size = new System.Drawing.Size(165, 23);
            this.btnSegTrabalho.TabIndex = 18;
            this.btnSegTrabalho.Text = "Segurança do Trabalho";
            this.btnSegTrabalho.UseVisualStyleBackColor = true;
            this.btnSegTrabalho.Click += new System.EventHandler(this.btnSegTrabalho_Click);
            // 
            // btnRH
            // 
            this.btnRH.Location = new System.Drawing.Point(280, 193);
            this.btnRH.Name = "btnRH";
            this.btnRH.Size = new System.Drawing.Size(165, 23);
            this.btnRH.TabIndex = 17;
            this.btnRH.Text = "RH";
            this.btnRH.UseVisualStyleBackColor = true;
            this.btnRH.Click += new System.EventHandler(this.btnRH_Click);
            // 
            // btnQualidade
            // 
            this.btnQualidade.Location = new System.Drawing.Point(280, 164);
            this.btnQualidade.Name = "btnQualidade";
            this.btnQualidade.Size = new System.Drawing.Size(165, 23);
            this.btnQualidade.TabIndex = 16;
            this.btnQualidade.Text = "Qualidade";
            this.btnQualidade.UseVisualStyleBackColor = true;
            this.btnQualidade.Click += new System.EventHandler(this.btnQualidade_Click);
            // 
            // btnProducao
            // 
            this.btnProducao.Location = new System.Drawing.Point(280, 135);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(165, 23);
            this.btnProducao.TabIndex = 15;
            this.btnProducao.Text = "Produção";
            this.btnProducao.UseVisualStyleBackColor = true;
            this.btnProducao.Click += new System.EventHandler(this.btnProducao_Click);
            // 
            // btnPCP
            // 
            this.btnPCP.Location = new System.Drawing.Point(280, 106);
            this.btnPCP.Name = "btnPCP";
            this.btnPCP.Size = new System.Drawing.Size(165, 23);
            this.btnPCP.TabIndex = 14;
            this.btnPCP.Text = "PCP";
            this.btnPCP.UseVisualStyleBackColor = true;
            this.btnPCP.Click += new System.EventHandler(this.btnPCP_Click);
            // 
            // btnGerencia
            // 
            this.btnGerencia.Location = new System.Drawing.Point(280, 77);
            this.btnGerencia.Name = "btnGerencia";
            this.btnGerencia.Size = new System.Drawing.Size(165, 23);
            this.btnGerencia.TabIndex = 13;
            this.btnGerencia.Text = "Gerencia";
            this.btnGerencia.UseVisualStyleBackColor = true;
            this.btnGerencia.Click += new System.EventHandler(this.btnGerencia_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Location = new System.Drawing.Point(280, 48);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(165, 23);
            this.btnFinanceiro.TabIndex = 12;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnMarketing
            // 
            this.btnMarketing.Location = new System.Drawing.Point(280, 19);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Size = new System.Drawing.Size(165, 23);
            this.btnMarketing.TabIndex = 11;
            this.btnMarketing.Text = "Marketing";
            this.btnMarketing.UseVisualStyleBackColor = true;
            this.btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnEngenharia
            // 
            this.btnEngenharia.Location = new System.Drawing.Point(6, 251);
            this.btnEngenharia.Name = "btnEngenharia";
            this.btnEngenharia.Size = new System.Drawing.Size(165, 23);
            this.btnEngenharia.TabIndex = 10;
            this.btnEngenharia.Text = "Engenharia";
            this.btnEngenharia.UseVisualStyleBackColor = true;
            this.btnEngenharia.Click += new System.EventHandler(this.btnEngenharia_Click);
            // 
            // btnDiretoria
            // 
            this.btnDiretoria.Location = new System.Drawing.Point(6, 222);
            this.btnDiretoria.Name = "btnDiretoria";
            this.btnDiretoria.Size = new System.Drawing.Size(165, 23);
            this.btnDiretoria.TabIndex = 9;
            this.btnDiretoria.Text = "Diretoria";
            this.btnDiretoria.UseVisualStyleBackColor = true;
            this.btnDiretoria.Click += new System.EventHandler(this.btnDiretoria_Click);
            // 
            // btnCusto
            // 
            this.btnCusto.Location = new System.Drawing.Point(6, 193);
            this.btnCusto.Name = "btnCusto";
            this.btnCusto.Size = new System.Drawing.Size(165, 23);
            this.btnCusto.TabIndex = 8;
            this.btnCusto.Text = "Custo";
            this.btnCusto.UseVisualStyleBackColor = true;
            this.btnCusto.Click += new System.EventHandler(this.btnCusto_Click);
            // 
            // btnComex
            // 
            this.btnComex.Location = new System.Drawing.Point(6, 164);
            this.btnComex.Name = "btnComex";
            this.btnComex.Size = new System.Drawing.Size(165, 23);
            this.btnComex.TabIndex = 7;
            this.btnComex.Text = "Comex";
            this.btnComex.UseVisualStyleBackColor = true;
            this.btnComex.Click += new System.EventHandler(this.btnComex_Click);
            // 
            // btnComercial
            // 
            this.btnComercial.Location = new System.Drawing.Point(6, 135);
            this.btnComercial.Name = "btnComercial";
            this.btnComercial.Size = new System.Drawing.Size(165, 23);
            this.btnComercial.TabIndex = 6;
            this.btnComercial.Text = "Comercial";
            this.btnComercial.UseVisualStyleBackColor = true;
            this.btnComercial.Click += new System.EventHandler(this.btnComercial_Click);
            // 
            // btnContabilidade
            // 
            this.btnContabilidade.Location = new System.Drawing.Point(6, 106);
            this.btnContabilidade.Name = "btnContabilidade";
            this.btnContabilidade.Size = new System.Drawing.Size(165, 23);
            this.btnContabilidade.TabIndex = 5;
            this.btnContabilidade.Text = "Contabilidade";
            this.btnContabilidade.UseVisualStyleBackColor = true;
            this.btnContabilidade.Click += new System.EventHandler(this.btnContabilidade_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(6, 77);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(165, 23);
            this.btnCompras.TabIndex = 4;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnAlmoxarifado
            // 
            this.btnAlmoxarifado.Location = new System.Drawing.Point(6, 48);
            this.btnAlmoxarifado.Name = "btnAlmoxarifado";
            this.btnAlmoxarifado.Size = new System.Drawing.Size(165, 23);
            this.btnAlmoxarifado.TabIndex = 3;
            this.btnAlmoxarifado.Text = "Almoxarifado";
            this.btnAlmoxarifado.UseVisualStyleBackColor = true;
            this.btnAlmoxarifado.Click += new System.EventHandler(this.btnAlmoxarifado_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(6, 19);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(165, 23);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::WindowsFormsApp3.Properties.Resources.btnSair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(407, 360);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 23);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPermissaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 387);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPermissaoUsuarios";
            this.Text = "Alterar Permissões";
            this.Load += new System.EventHandler(this.frmPermissaoUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTI;
        private System.Windows.Forms.Button btnSegTrabalho;
        private System.Windows.Forms.Button btnRH;
        private System.Windows.Forms.Button btnQualidade;
        private System.Windows.Forms.Button btnProducao;
        private System.Windows.Forms.Button btnPCP;
        private System.Windows.Forms.Button btnGerencia;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnMarketing;
        private System.Windows.Forms.Button btnEngenharia;
        private System.Windows.Forms.Button btnDiretoria;
        private System.Windows.Forms.Button btnCusto;
        private System.Windows.Forms.Button btnComex;
        private System.Windows.Forms.Button btnComercial;
        private System.Windows.Forms.Button btnContabilidade;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnAlmoxarifado;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSair;
    }
}