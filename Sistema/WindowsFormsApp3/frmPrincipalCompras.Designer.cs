namespace WindowsFormsApp3
{
    partial class frmPrincipalCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalCompras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSolicCompras = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnVisForn = new System.Windows.Forms.Button();
            this.btnCadastroForn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVisForn);
            this.groupBox1.Controls.Add(this.btnCadastroForn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedores";
            // 
            // barraStatus
            // 
            this.barraStatus.Location = new System.Drawing.Point(0, 239);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(551, 22);
            this.barraStatus.TabIndex = 8;
            this.barraStatus.Text = "statusStrip1";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSetor.Location = new System.Drawing.Point(135, 244);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(38, 13);
            this.lblSetor.TabIndex = 17;
            this.lblSetor.Text = "Setor: ";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHora.Location = new System.Drawing.Point(396, 244);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 16;
            this.lblHora.Text = "Hora:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblData.Location = new System.Drawing.Point(284, 244);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data: ";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeUsuario.Location = new System.Drawing.Point(2, 244);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblNomeUsuario.TabIndex = 14;
            this.lblNomeUsuario.Text = "Usuário:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSolicCompras);
            this.groupBox2.Location = new System.Drawing.Point(13, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 94);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solicitações";
            // 
            // btnSolicCompras
            // 
            this.btnSolicCompras.Image = global::WindowsFormsApp3.Properties.Resources.btnSolCompra;
            this.btnSolicCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicCompras.Location = new System.Drawing.Point(6, 19);
            this.btnSolicCompras.Name = "btnSolicCompras";
            this.btnSolicCompras.Size = new System.Drawing.Size(216, 57);
            this.btnSolicCompras.TabIndex = 0;
            this.btnSolicCompras.Text = "Solicitação de Compras";
            this.btnSolicCompras.UseVisualStyleBackColor = true;
            // 
            // btnLogoff
            // 
            this.btnLogoff.Image = global::WindowsFormsApp3.Properties.Resources.btnLogoff;
            this.btnLogoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoff.Location = new System.Drawing.Point(489, 239);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(62, 23);
            this.btnLogoff.TabIndex = 13;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnVisForn
            // 
            this.btnVisForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnVisForn.Image = global::WindowsFormsApp3.Properties.Resources.btnCadastroFornecedor;
            this.btnVisForn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisForn.Location = new System.Drawing.Point(304, 19);
            this.btnVisForn.Name = "btnVisForn";
            this.btnVisForn.Size = new System.Drawing.Size(216, 57);
            this.btnVisForn.TabIndex = 7;
            this.btnVisForn.Text = "Visualizar Fornecedores";
            this.btnVisForn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisForn.UseVisualStyleBackColor = true;
            this.btnVisForn.Click += new System.EventHandler(this.btnVisForn_Click);
            // 
            // btnCadastroForn
            // 
            this.btnCadastroForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCadastroForn.Image = global::WindowsFormsApp3.Properties.Resources.btnCadastroFornecedor;
            this.btnCadastroForn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroForn.Location = new System.Drawing.Point(6, 19);
            this.btnCadastroForn.Name = "btnCadastroForn";
            this.btnCadastroForn.Size = new System.Drawing.Size(216, 57);
            this.btnCadastroForn.TabIndex = 6;
            this.btnCadastroForn.Text = "Cadastro de Fornecedores";
            this.btnCadastroForn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroForn.UseVisualStyleBackColor = true;
            this.btnCadastroForn.Click += new System.EventHandler(this.btnCadastroForn_Click);
            // 
            // frmPrincipalCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipalCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmPrincipalCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVisForn;
        private System.Windows.Forms.Button btnCadastroForn;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSolicCompras;
    }
}