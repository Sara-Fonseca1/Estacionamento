namespace Estacionamento
{
    partial class FrmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixa));
            this.gbdados = new System.Windows.Forms.GroupBox();
            this.grddados = new System.Windows.Forms.DataGridView();
            this.gbbotoes = new System.Windows.Forms.GroupBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlancar = new System.Windows.Forms.Button();
            this.gbconsulta = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdatafinal = new System.Windows.Forms.DateTimePicker();
            this.txtdatainicio = new System.Windows.Forms.DateTimePicker();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbdados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddados)).BeginInit();
            this.gbbotoes.SuspendLayout();
            this.gbconsulta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbdados
            // 
            this.gbdados.BackColor = System.Drawing.Color.Teal;
            this.gbdados.Controls.Add(this.grddados);
            this.gbdados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdados.ForeColor = System.Drawing.Color.White;
            this.gbdados.Location = new System.Drawing.Point(148, 329);
            this.gbdados.Name = "gbdados";
            this.gbdados.Size = new System.Drawing.Size(688, 259);
            this.gbdados.TabIndex = 0;
            this.gbdados.TabStop = false;
            this.gbdados.Text = "Dados";
            // 
            // grddados
            // 
            this.grddados.BackgroundColor = System.Drawing.Color.Lavender;
            this.grddados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddados.Location = new System.Drawing.Point(14, 21);
            this.grddados.Name = "grddados";
            this.grddados.Size = new System.Drawing.Size(660, 219);
            this.grddados.TabIndex = 0;
            // 
            // gbbotoes
            // 
            this.gbbotoes.BackColor = System.Drawing.Color.Teal;
            this.gbbotoes.Controls.Add(this.btnsair);
            this.gbbotoes.Controls.Add(this.btnlancar);
            this.gbbotoes.ForeColor = System.Drawing.Color.White;
            this.gbbotoes.Location = new System.Drawing.Point(7, 130);
            this.gbbotoes.Name = "gbbotoes";
            this.gbbotoes.Size = new System.Drawing.Size(138, 458);
            this.gbbotoes.TabIndex = 1;
            this.gbbotoes.TabStop = false;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Lavender;
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.Teal;
            this.btnsair.Location = new System.Drawing.Point(8, 246);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(124, 172);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlancar
            // 
            this.btnlancar.BackColor = System.Drawing.Color.Lavender;
            this.btnlancar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlancar.BackgroundImage")));
            this.btnlancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlancar.ForeColor = System.Drawing.Color.Teal;
            this.btnlancar.Location = new System.Drawing.Point(6, 19);
            this.btnlancar.Name = "btnlancar";
            this.btnlancar.Size = new System.Drawing.Size(123, 169);
            this.btnlancar.TabIndex = 3;
            this.btnlancar.Text = "Lançamento";
            this.btnlancar.UseVisualStyleBackColor = false;
            this.btnlancar.Click += new System.EventHandler(this.btnlancar_Click);
            // 
            // gbconsulta
            // 
            this.gbconsulta.BackColor = System.Drawing.Color.Teal;
            this.gbconsulta.Controls.Add(this.label8);
            this.gbconsulta.Controls.Add(this.label7);
            this.gbconsulta.Controls.Add(this.label6);
            this.gbconsulta.Controls.Add(this.txtSaldo);
            this.gbconsulta.Controls.Add(this.txtSaida);
            this.gbconsulta.Controls.Add(this.txtentrada);
            this.gbconsulta.Controls.Add(this.label5);
            this.gbconsulta.Controls.Add(this.label4);
            this.gbconsulta.Controls.Add(this.label2);
            this.gbconsulta.Controls.Add(this.label1);
            this.gbconsulta.Controls.Add(this.txtdatafinal);
            this.gbconsulta.Controls.Add(this.txtdatainicio);
            this.gbconsulta.Controls.Add(this.btnconsulta);
            this.gbconsulta.Controls.Add(this.txtdescricao);
            this.gbconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbconsulta.ForeColor = System.Drawing.Color.White;
            this.gbconsulta.Location = new System.Drawing.Point(148, 130);
            this.gbconsulta.Name = "gbconsulta";
            this.gbconsulta.Size = new System.Drawing.Size(688, 188);
            this.gbconsulta.TabIndex = 2;
            this.gbconsulta.TabStop = false;
            this.gbconsulta.Text = "Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Consulta pelo periodo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consulta pela descrição do Serviço";
            // 
            // txtdatafinal
            // 
            this.txtdatafinal.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.txtdatafinal.CalendarTitleBackColor = System.Drawing.Color.SlateGray;
            this.txtdatafinal.Location = new System.Drawing.Point(411, 95);
            this.txtdatafinal.Name = "txtdatafinal";
            this.txtdatafinal.Size = new System.Drawing.Size(144, 22);
            this.txtdatafinal.TabIndex = 6;
            // 
            // txtdatainicio
            // 
            this.txtdatainicio.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.txtdatainicio.CalendarTitleBackColor = System.Drawing.Color.SlateGray;
            this.txtdatainicio.Location = new System.Drawing.Point(202, 95);
            this.txtdatainicio.Name = "txtdatainicio";
            this.txtdatainicio.Size = new System.Drawing.Size(157, 22);
            this.txtdatainicio.TabIndex = 5;
            // 
            // btnconsulta
            // 
            this.btnconsulta.BackColor = System.Drawing.Color.Lavender;
            this.btnconsulta.ForeColor = System.Drawing.Color.Teal;
            this.btnconsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnconsulta.Image")));
            this.btnconsulta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnconsulta.Location = new System.Drawing.Point(583, 27);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(91, 90);
            this.btnconsulta.TabIndex = 4;
            this.btnconsulta.Text = "Consultar";
            this.btnconsulta.UseVisualStyleBackColor = false;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.BackColor = System.Drawing.Color.Lavender;
            this.txtdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricao.Location = new System.Drawing.Point(6, 51);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(558, 22);
            this.txtdescricao.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 112);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 65);
            this.label3.TabIndex = 5;
            this.label3.Text = "CAIXA";
            // 
            // txtentrada
            // 
            this.txtentrada.Location = new System.Drawing.Point(6, 143);
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(158, 22);
            this.txtentrada.TabIndex = 11;
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(202, 143);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(157, 22);
            this.txtSaida.TabIndex = 12;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(411, 143);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(144, 22);
            this.txtSaldo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Saida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Saldo";
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(848, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbconsulta);
            this.Controls.Add(this.gbbotoes);
            this.Controls.Add(this.gbdados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.FrmCaixa_Load);
            this.gbdados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grddados)).EndInit();
            this.gbbotoes.ResumeLayout(false);
            this.gbconsulta.ResumeLayout(false);
            this.gbconsulta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdados;
        private System.Windows.Forms.DataGridView grddados;
        private System.Windows.Forms.GroupBox gbbotoes;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlancar;
        private System.Windows.Forms.GroupBox gbconsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtdatafinal;
        private System.Windows.Forms.DateTimePicker txtdatainicio;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.TextBox txtentrada;
    }
}