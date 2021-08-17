namespace Estacionamento
{
    partial class Frmlancamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlancamento));
            this.gbbotoes = new System.Windows.Forms.GroupBox();
            this.rbsaida = new System.Windows.Forms.RadioButton();
            this.rbentrada = new System.Windows.Forms.RadioButton();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlancar = new System.Windows.Forms.Button();
            this.gbdados = new System.Windows.Forms.GroupBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbbotoes.SuspendLayout();
            this.gbdados.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbbotoes
            // 
            this.gbbotoes.BackColor = System.Drawing.Color.Teal;
            this.gbbotoes.Controls.Add(this.rbsaida);
            this.gbbotoes.Controls.Add(this.rbentrada);
            this.gbbotoes.Controls.Add(this.btnsair);
            this.gbbotoes.Controls.Add(this.btnlancar);
            this.gbbotoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbbotoes.ForeColor = System.Drawing.Color.White;
            this.gbbotoes.Location = new System.Drawing.Point(7, 118);
            this.gbbotoes.Name = "gbbotoes";
            this.gbbotoes.Size = new System.Drawing.Size(157, 249);
            this.gbbotoes.TabIndex = 0;
            this.gbbotoes.TabStop = false;
            this.gbbotoes.Enter += new System.EventHandler(this.gbbotoes_Enter);
            // 
            // rbsaida
            // 
            this.rbsaida.AutoSize = true;
            this.rbsaida.Location = new System.Drawing.Point(84, 34);
            this.rbsaida.Name = "rbsaida";
            this.rbsaida.Size = new System.Drawing.Size(67, 20);
            this.rbsaida.TabIndex = 7;
            this.rbsaida.TabStop = true;
            this.rbsaida.Text = "Saida";
            this.rbsaida.UseVisualStyleBackColor = true;
            // 
            // rbentrada
            // 
            this.rbentrada.AutoSize = true;
            this.rbentrada.Location = new System.Drawing.Point(6, 34);
            this.rbentrada.Name = "rbentrada";
            this.rbentrada.Size = new System.Drawing.Size(80, 20);
            this.rbentrada.TabIndex = 6;
            this.rbentrada.TabStop = true;
            this.rbentrada.Text = "Entrada";
            this.rbentrada.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Lavender;
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsair.ForeColor = System.Drawing.Color.Teal;
            this.btnsair.Location = new System.Drawing.Point(16, 158);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(124, 85);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlancar
            // 
            this.btnlancar.BackColor = System.Drawing.Color.Lavender;
            this.btnlancar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlancar.BackgroundImage")));
            this.btnlancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlancar.ForeColor = System.Drawing.Color.Teal;
            this.btnlancar.Location = new System.Drawing.Point(16, 60);
            this.btnlancar.Name = "btnlancar";
            this.btnlancar.Size = new System.Drawing.Size(124, 91);
            this.btnlancar.TabIndex = 5;
            this.btnlancar.Text = "lançar";
            this.btnlancar.UseVisualStyleBackColor = false;
            this.btnlancar.Click += new System.EventHandler(this.btnlancar_Click);
            // 
            // gbdados
            // 
            this.gbdados.BackColor = System.Drawing.Color.Teal;
            this.gbdados.Controls.Add(this.txtvalor);
            this.gbdados.Controls.Add(this.txtdescricao);
            this.gbdados.Controls.Add(this.label2);
            this.gbdados.Controls.Add(this.label1);
            this.gbdados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdados.ForeColor = System.Drawing.Color.White;
            this.gbdados.Location = new System.Drawing.Point(170, 118);
            this.gbdados.Name = "gbdados";
            this.gbdados.Size = new System.Drawing.Size(526, 249);
            this.gbdados.TabIndex = 1;
            this.gbdados.TabStop = false;
            this.gbdados.Text = "Dados";
            this.gbdados.Enter += new System.EventHandler(this.gbdados_Enter);
            // 
            // txtvalor
            // 
            this.txtvalor.BackColor = System.Drawing.Color.Lavender;
            this.txtvalor.Location = new System.Drawing.Point(20, 129);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(136, 22);
            this.txtvalor.TabIndex = 3;
            // 
            // txtdescricao
            // 
            this.txtdescricao.BackColor = System.Drawing.Color.Lavender;
            this.txtdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricao.Location = new System.Drawing.Point(20, 54);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(423, 22);
            this.txtdescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe o valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a descrição";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(7, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(684, 91);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 65);
            this.label5.TabIndex = 6;
            this.label5.Text = "LANÇAMENTO";
            // 
            // Frmlancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(703, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbdados);
            this.Controls.Add(this.gbbotoes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmlancamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento caixa";
            this.Load += new System.EventHandler(this.Frmlancamento_Load);
            this.gbbotoes.ResumeLayout(false);
            this.gbbotoes.PerformLayout();
            this.gbdados.ResumeLayout(false);
            this.gbdados.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbbotoes;
        private System.Windows.Forms.GroupBox gbdados;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlancar;
        private System.Windows.Forms.RadioButton rbsaida;
        private System.Windows.Forms.RadioButton rbentrada;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
    }
}