namespace WindowsFormsApp3
{
    partial class frmAdminRights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminRights));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastroUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVisUsuarios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadastroUser);
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btnCadastroUser
            // 
            this.btnCadastroUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCadastroUser.Image = global::WindowsFormsApp3.Properties.Resources.btnUsuário;
            this.btnCadastroUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroUser.Location = new System.Drawing.Point(6, 19);
            this.btnCadastroUser.Name = "btnCadastroUser";
            this.btnCadastroUser.Size = new System.Drawing.Size(216, 57);
            this.btnCadastroUser.TabIndex = 1;
            this.btnCadastroUser.Text = "Cadastro de Usuários";
            this.btnCadastroUser.UseVisualStyleBackColor = true;
            this.btnCadastroUser.Click += new System.EventHandler(this.btnCadastroUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Direitos de Admin";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::WindowsFormsApp3.Properties.Resources.btnSair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(420, 327);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVisUsuarios);
            this.groupBox2.Location = new System.Drawing.Point(13, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 93);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualização";
            // 
            // btnVisUsuarios
            // 
            this.btnVisUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnVisUsuarios.Image = global::WindowsFormsApp3.Properties.Resources.btnUsuário;
            this.btnVisUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisUsuarios.Location = new System.Drawing.Point(6, 19);
            this.btnVisUsuarios.Name = "btnVisUsuarios";
            this.btnVisUsuarios.Size = new System.Drawing.Size(216, 57);
            this.btnVisUsuarios.TabIndex = 2;
            this.btnVisUsuarios.Text = "Visualizar Usuarios";
            this.btnVisUsuarios.UseVisualStyleBackColor = true;
            this.btnVisUsuarios.Click += new System.EventHandler(this.btnVisUsuarios_Click);
            // 
            // frmAdminRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminRights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diretos de Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastroUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVisUsuarios;
    }
}