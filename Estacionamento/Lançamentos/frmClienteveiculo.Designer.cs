namespace Estacionamento
{
    partial class frmClienteveiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteveiculo));
            this.gbdados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttelresidencial = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.gbbotoes = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbdados.SuspendLayout();
            this.gbbotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbdados
            // 
            this.gbdados.BackColor = System.Drawing.Color.Teal;
            this.gbdados.Controls.Add(this.label2);
            this.gbdados.Controls.Add(this.txtPlaca);
            this.gbdados.Controls.Add(this.lblPlaca);
            this.gbdados.Controls.Add(this.lblValor);
            this.gbdados.Controls.Add(this.txtDescricao);
            this.gbdados.Controls.Add(this.label1);
            this.gbdados.Controls.Add(this.txttelresidencial);
            this.gbdados.Controls.Add(this.lblNome);
            this.gbdados.Controls.Add(this.lblTelefone);
            this.gbdados.Controls.Add(this.txtCelular);
            this.gbdados.Controls.Add(this.txtNome);
            this.gbdados.ForeColor = System.Drawing.Color.White;
            this.gbdados.Location = new System.Drawing.Point(164, 141);
            this.gbdados.Name = "gbdados";
            this.gbdados.Size = new System.Drawing.Size(688, 246);
            this.gbdados.TabIndex = 0;
            this.gbdados.TabStop = false;
            this.gbdados.Text = "Dados";
            this.gbdados.Enter += new System.EventHandler(this.gbdados_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.Lavender;
            this.txtPlaca.Location = new System.Drawing.Point(557, 161);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 4;
            this.txtPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPlaca_MaskInputRejected);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(554, 142);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 25;
            this.lblPlaca.Text = "Placa";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 142);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(144, 13);
            this.lblValor.TabIndex = 26;
            this.lblValor.Text = "Digite a descrição do veiculo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Lavender;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(9, 161);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(543, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Telefone Residencial";
            // 
            // txttelresidencial
            // 
            this.txttelresidencial.BackColor = System.Drawing.Color.Lavender;
            this.txttelresidencial.Location = new System.Drawing.Point(12, 99);
            this.txttelresidencial.Name = "txttelresidencial";
            this.txttelresidencial.Size = new System.Drawing.Size(198, 20);
            this.txttelresidencial.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(-91, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(289, 83);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(84, 13);
            this.lblTelefone.TabIndex = 20;
            this.lblTelefone.Text = "Telefone Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.Lavender;
            this.txtCelular.Location = new System.Drawing.Point(292, 99);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(195, 20);
            this.txtCelular.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Lavender;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(9, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(648, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lavender;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(7, 129);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 111);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.Lavender;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.Teal;
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalva.Location = new System.Drawing.Point(9, 11);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(133, 109);
            this.btnSalva.TabIndex = 4;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // gbbotoes
            // 
            this.gbbotoes.BackColor = System.Drawing.Color.Teal;
            this.gbbotoes.Controls.Add(this.btnSalva);
            this.gbbotoes.Controls.Add(this.btnSair);
            this.gbbotoes.ForeColor = System.Drawing.Color.White;
            this.gbbotoes.Location = new System.Drawing.Point(12, 141);
            this.gbbotoes.Name = "gbbotoes";
            this.gbbotoes.Size = new System.Drawing.Size(146, 246);
            this.gbbotoes.TabIndex = 6;
            this.gbbotoes.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(205, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "CLIENTE_VEICULO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmClienteveiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(864, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbbotoes);
            this.Controls.Add(this.gbdados);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClienteveiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClienteveiculo";
            this.Load += new System.EventHandler(this.frmClienteveiculo_Load);
            this.gbdados.ResumeLayout(false);
            this.gbdados.PerformLayout();
            this.gbbotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttelresidencial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.GroupBox gbbotoes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}