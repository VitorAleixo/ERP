namespace WindowsFormsApp3
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblControleEstoque = new System.Windows.Forms.Label();
            this.btnGerenciamento = new System.Windows.Forms.Button();
            this.btnCadastroForn = new System.Windows.Forms.Button();
            this.btnCadastroProd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVisForn = new System.Windows.Forms.Button();
            this.btnVisProduto = new System.Windows.Forms.Button();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblControleEstoque
            // 
            this.lblControleEstoque.AutoSize = true;
            this.lblControleEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControleEstoque.Location = new System.Drawing.Point(207, 9);
            this.lblControleEstoque.Name = "lblControleEstoque";
            this.lblControleEstoque.Size = new System.Drawing.Size(158, 25);
            this.lblControleEstoque.TabIndex = 4;
            this.lblControleEstoque.Text = "Gerenciamento";
            // 
            // btnGerenciamento
            // 
            this.btnGerenciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciamento.Image = global::WindowsFormsApp3.Properties.Resources.btnGerenciamentoEstoque;
            this.btnGerenciamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciamento.Location = new System.Drawing.Point(6, 129);
            this.btnGerenciamento.Name = "btnGerenciamento";
            this.btnGerenciamento.Size = new System.Drawing.Size(216, 57);
            this.btnGerenciamento.TabIndex = 3;
            this.btnGerenciamento.Text = "Gerenciamento de Estoque";
            this.btnGerenciamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciamento.UseVisualStyleBackColor = true;
            this.btnGerenciamento.Click += new System.EventHandler(this.btnGerenciamento_Click);
            // 
            // btnCadastroForn
            // 
            this.btnCadastroForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCadastroForn.Image = global::WindowsFormsApp3.Properties.Resources.btnCadastroFornecedor;
            this.btnCadastroForn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroForn.Location = new System.Drawing.Point(312, 19);
            this.btnCadastroForn.Name = "btnCadastroForn";
            this.btnCadastroForn.Size = new System.Drawing.Size(216, 57);
            this.btnCadastroForn.TabIndex = 2;
            this.btnCadastroForn.Text = "Cadastro de Fornecedores";
            this.btnCadastroForn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroForn.UseVisualStyleBackColor = true;
            this.btnCadastroForn.Click += new System.EventHandler(this.btnCadastroForn_Click);
            // 
            // btnCadastroProd
            // 
            this.btnCadastroProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCadastroProd.Image = global::WindowsFormsApp3.Properties.Resources.btnCadastroProduto;
            this.btnCadastroProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroProd.Location = new System.Drawing.Point(6, 19);
            this.btnCadastroProd.Name = "btnCadastroProd";
            this.btnCadastroProd.Size = new System.Drawing.Size(216, 57);
            this.btnCadastroProd.TabIndex = 1;
            this.btnCadastroProd.Text = "Cadastro de Produtos";
            this.btnCadastroProd.UseVisualStyleBackColor = true;
            this.btnCadastroProd.Click += new System.EventHandler(this.btnCadastroProd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadastroProd);
            this.groupBox1.Controls.Add(this.btnCadastroForn);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 170);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Enabled = false;
            this.btnAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAdministrador.Image = global::WindowsFormsApp3.Properties.Resources.btnCadastroProduto;
            this.btnAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrador.Location = new System.Drawing.Point(394, 8);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(152, 26);
            this.btnAdministrador.TabIndex = 3;
            this.btnAdministrador.Text = "Administradores";
            this.btnAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Visible = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVisForn);
            this.groupBox2.Controls.Add(this.btnVisProduto);
            this.groupBox2.Controls.Add(this.btnGerenciamento);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 206);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualização e Gerenciamento";
            // 
            // btnVisForn
            // 
            this.btnVisForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnVisForn.Image = global::WindowsFormsApp3.Properties.Resources.btnCadastroFornecedor;
            this.btnVisForn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisForn.Location = new System.Drawing.Point(312, 31);
            this.btnVisForn.Name = "btnVisForn";
            this.btnVisForn.Size = new System.Drawing.Size(216, 57);
            this.btnVisForn.TabIndex = 5;
            this.btnVisForn.Text = "Visualizar Fornecedores";
            this.btnVisForn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisForn.UseVisualStyleBackColor = true;
            this.btnVisForn.Click += new System.EventHandler(this.btnVisForn_Click);
            // 
            // btnVisProduto
            // 
            this.btnVisProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnVisProduto.Image = global::WindowsFormsApp3.Properties.Resources.btnCadastroProduto;
            this.btnVisProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisProduto.Location = new System.Drawing.Point(6, 31);
            this.btnVisProduto.Name = "btnVisProduto";
            this.btnVisProduto.Size = new System.Drawing.Size(216, 57);
            this.btnVisProduto.TabIndex = 4;
            this.btnVisProduto.Text = "Visualizar Produtos";
            this.btnVisProduto.UseVisualStyleBackColor = true;
            this.btnVisProduto.Click += new System.EventHandler(this.btnVisProduto_Click);
            // 
            // barraStatus
            // 
            this.barraStatus.Location = new System.Drawing.Point(0, 426);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(558, 22);
            this.barraStatus.TabIndex = 7;
            this.barraStatus.Text = "statusStrip1";
            // 
            // btnLogoff
            // 
            this.btnLogoff.Image = global::WindowsFormsApp3.Properties.Resources.btnLogoff;
            this.btnLogoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoff.Location = new System.Drawing.Point(496, 425);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(62, 23);
            this.btnLogoff.TabIndex = 8;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeUsuario.Location = new System.Drawing.Point(9, 430);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblNomeUsuario.TabIndex = 9;
            this.lblNomeUsuario.Text = "Usuário:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblData.Location = new System.Drawing.Point(291, 430);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data: ";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHora.Location = new System.Drawing.Point(403, 430);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora:";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSetor.Location = new System.Drawing.Point(142, 430);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(38, 13);
            this.lblSetor.TabIndex = 12;
            this.lblSetor.Text = "Setor: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 448);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblControleEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastroProd;
        private System.Windows.Forms.Button btnCadastroForn;
        private System.Windows.Forms.Button btnGerenciamento;
        private System.Windows.Forms.Label lblControleEstoque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVisForn;
        private System.Windows.Forms.Button btnVisProduto;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Label lblSetor;
    }
}