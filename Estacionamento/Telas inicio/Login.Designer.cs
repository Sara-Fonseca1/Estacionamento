namespace Estacionamento
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcesso = new System.Windows.Forms.Button();
            this.btnAcessoRapido = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.BackColor = System.Drawing.Color.Lavender;
            this.cmbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.ForeColor = System.Drawing.Color.SlateGray;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(84, 193);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(224, 24);
            this.cmbUsuario.TabIndex = 15;
            this.cmbUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbUsuario_KeyDown);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Red;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.SlateGray;
            this.lblMensagem.Location = new System.Drawing.Point(190, 430);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 16);
            this.lblMensagem.TabIndex = 14;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Lavender;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.SlateGray;
            this.txtSenha.Location = new System.Drawing.Point(84, 243);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(224, 22);
            this.txtSenha.TabIndex = 13;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuário";
            // 
            // btnAcesso
            // 
            this.btnAcesso.BackColor = System.Drawing.Color.Lavender;
            this.btnAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcesso.ForeColor = System.Drawing.Color.SlateGray;
            this.btnAcesso.Location = new System.Drawing.Point(29, 281);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(133, 53);
            this.btnAcesso.TabIndex = 8;
            this.btnAcesso.Text = "Entrar";
            this.btnAcesso.UseVisualStyleBackColor = false;
            this.btnAcesso.Click += new System.EventHandler(this.btnAcesso_Click);
            // 
            // btnAcessoRapido
            // 
            this.btnAcessoRapido.BackColor = System.Drawing.Color.Lavender;
            this.btnAcessoRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessoRapido.ForeColor = System.Drawing.Color.SlateGray;
            this.btnAcessoRapido.Image = ((System.Drawing.Image)(resources.GetObject("btnAcessoRapido.Image")));
            this.btnAcessoRapido.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAcessoRapido.Location = new System.Drawing.Point(29, 348);
            this.btnAcessoRapido.Name = "btnAcessoRapido";
            this.btnAcessoRapido.Size = new System.Drawing.Size(279, 59);
            this.btnAcessoRapido.TabIndex = 9;
            this.btnAcessoRapido.Text = "Acesso Rapido";
            this.btnAcessoRapido.UseVisualStyleBackColor = false;
            this.btnAcessoRapido.Click += new System.EventHandler(this.btnAcessoRapido_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Lavender;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.SlateGray;
            this.btnsair.Image = ((System.Drawing.Image)(resources.GetObject("btnsair.Image")));
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnsair.Location = new System.Drawing.Point(168, 281);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(140, 53);
            this.btnsair.TabIndex = 10;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 132);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(150, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(330, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcesso);
            this.Controls.Add(this.btnAcessoRapido);
            this.Controls.Add(this.btnsair);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcesso;
        private System.Windows.Forms.Button btnAcessoRapido;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}