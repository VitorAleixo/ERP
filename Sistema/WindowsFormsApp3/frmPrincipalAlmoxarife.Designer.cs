namespace WindowsFormsApp3
{
    partial class frmPrincipalAlmoxarife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalAlmoxarife));
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVisProduto = new System.Windows.Forms.Button();
            this.btnGerenciamento = new System.Windows.Forms.Button();
            this.btnCadastroProd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraStatus
            // 
            this.barraStatus.Location = new System.Drawing.Point(0, 239);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(551, 22);
            this.barraStatus.TabIndex = 9;
            this.barraStatus.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSetor.Location = new System.Drawing.Point(135, 243);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(38, 13);
            this.lblSetor.TabIndex = 22;
            this.lblSetor.Text = "Setor: ";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHora.Location = new System.Drawing.Point(396, 243);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 21;
            this.lblHora.Text = "Hora:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblData.Location = new System.Drawing.Point(284, 243);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 20;
            this.lblData.Text = "Data: ";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeUsuario.Location = new System.Drawing.Point(2, 243);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblNomeUsuario.TabIndex = 19;
            this.lblNomeUsuario.Text = "Usuário:";
            // 
            // btnLogoff
            // 
            this.btnLogoff.Image = global::WindowsFormsApp3.Properties.Resources.btnLogoff;
            this.btnLogoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoff.Location = new System.Drawing.Point(489, 238);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(62, 23);
            this.btnLogoff.TabIndex = 18;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVisProduto);
            this.groupBox1.Controls.Add(this.btnCadastroProd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 94);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btnVisProduto
            // 
            this.btnVisProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnVisProduto.Image = global::WindowsFormsApp3.Properties.Resources.btnCadastroProduto;
            this.btnVisProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisProduto.Location = new System.Drawing.Point(304, 19);
            this.btnVisProduto.Name = "btnVisProduto";
            this.btnVisProduto.Size = new System.Drawing.Size(216, 57);
            this.btnVisProduto.TabIndex = 8;
            this.btnVisProduto.Text = "Visualizar Produtos";
            this.btnVisProduto.UseVisualStyleBackColor = true;
            this.btnVisProduto.Click += new System.EventHandler(this.btnVisProduto_Click);
            // 
            // btnGerenciamento
            // 
            this.btnGerenciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciamento.Image = global::WindowsFormsApp3.Properties.Resources.btnGerenciamentoEstoque;
            this.btnGerenciamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciamento.Location = new System.Drawing.Point(6, 19);
            this.btnGerenciamento.Name = "btnGerenciamento";
            this.btnGerenciamento.Size = new System.Drawing.Size(216, 57);
            this.btnGerenciamento.TabIndex = 9;
            this.btnGerenciamento.Text = "Gerenciamento de Estoque";
            this.btnGerenciamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciamento.UseVisualStyleBackColor = true;
            this.btnGerenciamento.Click += new System.EventHandler(this.btnGerenciamento_Click);
            // 
            // btnCadastroProd
            // 
            this.btnCadastroProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCadastroProd.Image = global::WindowsFormsApp3.Properties.Resources.btnCadastroProduto;
            this.btnCadastroProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroProd.Location = new System.Drawing.Point(6, 19);
            this.btnCadastroProd.Name = "btnCadastroProd";
            this.btnCadastroProd.Size = new System.Drawing.Size(216, 57);
            this.btnCadastroProd.TabIndex = 7;
            this.btnCadastroProd.Text = "Cadastro de Produtos";
            this.btnCadastroProd.UseVisualStyleBackColor = true;
            this.btnCadastroProd.Click += new System.EventHandler(this.btnCadastroProd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGerenciamento);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 90);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerenciamento ";
            // 
            // frmPrincipalAlmoxarife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.barraStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipalAlmoxarife";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almoxarifado";
            this.Load += new System.EventHandler(this.frmPrincipalAlmoxarife_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVisProduto;
        private System.Windows.Forms.Button btnCadastroProd;
        private System.Windows.Forms.Button btnGerenciamento;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}