namespace Estacionamento
{
    partial class FrmRecebimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecebimento));
            this.GBtitulo = new System.Windows.Forms.GroupBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.GBBotoes = new System.Windows.Forms.GroupBox();
            this.btnservico = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btndiaria = new System.Windows.Forms.Button();
            this.btnreceber = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbdados = new System.Windows.Forms.GroupBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lblservico = new System.Windows.Forms.Label();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtservico = new System.Windows.Forms.TextBox();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.gbitens = new System.Windows.Forms.GroupBox();
            this.btnlimparlista = new System.Windows.Forms.Button();
            this.Meusitens = new System.Windows.Forms.ListView();
            this.gbtotal = new System.Windows.Forms.GroupBox();
            this.txtvalorliquido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.txtvalorrecebido = new System.Windows.Forms.TextBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltroco = new System.Windows.Forms.Label();
            this.lblvalorrecebido = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBtitulo.SuspendLayout();
            this.GBBotoes.SuspendLayout();
            this.gbdados.SuspendLayout();
            this.gbitens.SuspendLayout();
            this.gbtotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBtitulo
            // 
            this.GBtitulo.BackColor = System.Drawing.Color.Teal;
            this.GBtitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GBtitulo.Controls.Add(this.pictureBox1);
            this.GBtitulo.Controls.Add(this.lbltitulo);
            this.GBtitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.GBtitulo.Location = new System.Drawing.Point(8, 12);
            this.GBtitulo.Name = "GBtitulo";
            this.GBtitulo.Size = new System.Drawing.Size(1083, 119);
            this.GBtitulo.TabIndex = 0;
            this.GBtitulo.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Image = ((System.Drawing.Image)(resources.GetObject("lbltitulo.Image")));
            this.lbltitulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbltitulo.Location = new System.Drawing.Point(185, 37);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(742, 37);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "RECEBIMENTO Estacionamento e Lava Rapido";
            // 
            // GBBotoes
            // 
            this.GBBotoes.BackColor = System.Drawing.Color.Teal;
            this.GBBotoes.Controls.Add(this.btnservico);
            this.GBBotoes.Controls.Add(this.btnlimpar);
            this.GBBotoes.Controls.Add(this.btndiaria);
            this.GBBotoes.Controls.Add(this.btnreceber);
            this.GBBotoes.Controls.Add(this.btnsair);
            this.GBBotoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBBotoes.ForeColor = System.Drawing.SystemColors.Control;
            this.GBBotoes.Location = new System.Drawing.Point(8, 137);
            this.GBBotoes.Name = "GBBotoes";
            this.GBBotoes.Size = new System.Drawing.Size(156, 548);
            this.GBBotoes.TabIndex = 1;
            this.GBBotoes.TabStop = false;
            // 
            // btnservico
            // 
            this.btnservico.BackColor = System.Drawing.Color.Lavender;
            this.btnservico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnservico.BackgroundImage")));
            this.btnservico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnservico.ForeColor = System.Drawing.Color.SlateGray;
            this.btnservico.Location = new System.Drawing.Point(2, 120);
            this.btnservico.Name = "btnservico";
            this.btnservico.Size = new System.Drawing.Size(148, 96);
            this.btnservico.TabIndex = 3;
            this.btnservico.Text = "Serviço";
            this.btnservico.UseVisualStyleBackColor = false;
            this.btnservico.Click += new System.EventHandler(this.btnservico_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Lavender;
            this.btnlimpar.ForeColor = System.Drawing.Color.SlateGray;
            this.btnlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpar.Image")));
            this.btnlimpar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnlimpar.Location = new System.Drawing.Point(2, 220);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(148, 101);
            this.btnlimpar.TabIndex = 2;
            this.btnlimpar.Text = "Excluir";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btndiaria
            // 
            this.btndiaria.BackColor = System.Drawing.Color.Lavender;
            this.btndiaria.ForeColor = System.Drawing.Color.SlateGray;
            this.btndiaria.Image = ((System.Drawing.Image)(resources.GetObject("btndiaria.Image")));
            this.btndiaria.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btndiaria.Location = new System.Drawing.Point(2, 18);
            this.btndiaria.Name = "btndiaria";
            this.btndiaria.Size = new System.Drawing.Size(148, 96);
            this.btndiaria.TabIndex = 4;
            this.btndiaria.Text = "Diaria";
            this.btndiaria.UseVisualStyleBackColor = false;
            this.btndiaria.Click += new System.EventHandler(this.btndiaria_Click);
            // 
            // btnreceber
            // 
            this.btnreceber.BackColor = System.Drawing.Color.Lavender;
            this.btnreceber.ForeColor = System.Drawing.Color.SlateGray;
            this.btnreceber.Image = ((System.Drawing.Image)(resources.GetObject("btnreceber.Image")));
            this.btnreceber.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnreceber.Location = new System.Drawing.Point(2, 327);
            this.btnreceber.Name = "btnreceber";
            this.btnreceber.Size = new System.Drawing.Size(148, 105);
            this.btnreceber.TabIndex = 6;
            this.btnreceber.Text = "Receber";
            this.btnreceber.UseVisualStyleBackColor = false;
            this.btnreceber.Click += new System.EventHandler(this.btnreceber_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Lavender;
            this.btnsair.ForeColor = System.Drawing.Color.SlateGray;
            this.btnsair.Image = ((System.Drawing.Image)(resources.GetObject("btnsair.Image")));
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnsair.Location = new System.Drawing.Point(2, 438);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(148, 104);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // gbdados
            // 
            this.gbdados.BackColor = System.Drawing.Color.Teal;
            this.gbdados.Controls.Add(this.lblvalor);
            this.gbdados.Controls.Add(this.lblservico);
            this.gbdados.Controls.Add(this.lblquantidade);
            this.gbdados.Controls.Add(this.lbl20);
            this.gbdados.Controls.Add(this.lblcliente);
            this.gbdados.Controls.Add(this.txtquantidade);
            this.gbdados.Controls.Add(this.txtservico);
            this.gbdados.Controls.Add(this.cmbcliente);
            this.gbdados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdados.ForeColor = System.Drawing.Color.White;
            this.gbdados.Location = new System.Drawing.Point(170, 137);
            this.gbdados.Name = "gbdados";
            this.gbdados.Size = new System.Drawing.Size(921, 214);
            this.gbdados.TabIndex = 7;
            this.gbdados.TabStop = false;
            this.gbdados.Text = "Dados";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(635, 129);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(51, 16);
            this.lblvalor.TabIndex = 8;
            this.lblvalor.Text = "label2";
            // 
            // lblservico
            // 
            this.lblservico.AutoSize = true;
            this.lblservico.Location = new System.Drawing.Point(635, 94);
            this.lblservico.Name = "lblservico";
            this.lblservico.Size = new System.Drawing.Size(51, 16);
            this.lblservico.TabIndex = 7;
            this.lblservico.Text = "label1";
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantidade.ForeColor = System.Drawing.Color.White;
            this.lblquantidade.Location = new System.Drawing.Point(22, 151);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(181, 20);
            this.lblquantidade.TabIndex = 5;
            this.lblquantidade.Text = "Informe a quantidade";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.ForeColor = System.Drawing.Color.White;
            this.lbl20.Location = new System.Drawing.Point(22, 90);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(235, 20);
            this.lbl20.TabIndex = 4;
            this.lbl20.Text = "Informe o codigo do  serviço";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.ForeColor = System.Drawing.Color.White;
            this.lblcliente.Location = new System.Drawing.Point(19, 27);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(144, 20);
            this.lblcliente.TabIndex = 3;
            this.lblcliente.Text = "Informe o cliente";
            // 
            // txtquantidade
            // 
            this.txtquantidade.BackColor = System.Drawing.Color.Lavender;
            this.txtquantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidade.Location = new System.Drawing.Point(26, 174);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(555, 26);
            this.txtquantidade.TabIndex = 2;
            this.txtquantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtquantidade_KeyDown);
            // 
            // txtservico
            // 
            this.txtservico.BackColor = System.Drawing.Color.Lavender;
            this.txtservico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtservico.Location = new System.Drawing.Point(26, 113);
            this.txtservico.Name = "txtservico";
            this.txtservico.Size = new System.Drawing.Size(555, 22);
            this.txtservico.TabIndex = 1;
            this.txtservico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtservico_KeyDown);
            // 
            // cmbcliente
            // 
            this.cmbcliente.BackColor = System.Drawing.Color.Lavender;
            this.cmbcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(23, 50);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(558, 24);
            this.cmbcliente.TabIndex = 0;
            // 
            // gbitens
            // 
            this.gbitens.BackColor = System.Drawing.Color.Teal;
            this.gbitens.Controls.Add(this.btnlimparlista);
            this.gbitens.Controls.Add(this.Meusitens);
            this.gbitens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbitens.ForeColor = System.Drawing.Color.White;
            this.gbitens.Location = new System.Drawing.Point(170, 357);
            this.gbitens.Name = "gbitens";
            this.gbitens.Size = new System.Drawing.Size(581, 328);
            this.gbitens.TabIndex = 8;
            this.gbitens.TabStop = false;
            this.gbitens.Text = "Lista";
            // 
            // btnlimparlista
            // 
            this.btnlimparlista.ForeColor = System.Drawing.Color.Black;
            this.btnlimparlista.Location = new System.Drawing.Point(235, 286);
            this.btnlimparlista.Name = "btnlimparlista";
            this.btnlimparlista.Size = new System.Drawing.Size(118, 35);
            this.btnlimparlista.TabIndex = 1;
            this.btnlimparlista.Text = "Limpar";
            this.btnlimparlista.UseVisualStyleBackColor = true;
            this.btnlimparlista.Click += new System.EventHandler(this.btnlimparlista_Click);
            // 
            // Meusitens
            // 
            this.Meusitens.BackColor = System.Drawing.Color.Lavender;
            this.Meusitens.Location = new System.Drawing.Point(6, 21);
            this.Meusitens.Name = "Meusitens";
            this.Meusitens.Size = new System.Drawing.Size(569, 259);
            this.Meusitens.TabIndex = 0;
            this.Meusitens.UseCompatibleStateImageBehavior = false;
            // 
            // gbtotal
            // 
            this.gbtotal.BackColor = System.Drawing.Color.Teal;
            this.gbtotal.Controls.Add(this.txtvalorliquido);
            this.gbtotal.Controls.Add(this.label1);
            this.gbtotal.Controls.Add(this.txttroco);
            this.gbtotal.Controls.Add(this.txtvalorrecebido);
            this.gbtotal.Controls.Add(this.txtdesconto);
            this.gbtotal.Controls.Add(this.txttotal);
            this.gbtotal.Controls.Add(this.lbltroco);
            this.gbtotal.Controls.Add(this.lblvalorrecebido);
            this.gbtotal.Controls.Add(this.lbltotal);
            this.gbtotal.Controls.Add(this.lbldesconto);
            this.gbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtotal.ForeColor = System.Drawing.Color.White;
            this.gbtotal.Location = new System.Drawing.Point(759, 357);
            this.gbtotal.Name = "gbtotal";
            this.gbtotal.Size = new System.Drawing.Size(332, 328);
            this.gbtotal.TabIndex = 9;
            this.gbtotal.TabStop = false;
            this.gbtotal.Text = "Valores";
            this.gbtotal.Enter += new System.EventHandler(this.gbtotal_Enter);
            // 
            // txtvalorliquido
            // 
            this.txtvalorliquido.BackColor = System.Drawing.Color.Lavender;
            this.txtvalorliquido.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorliquido.Location = new System.Drawing.Point(183, 140);
            this.txtvalorliquido.Name = "txtvalorliquido";
            this.txtvalorliquido.Size = new System.Drawing.Size(134, 24);
            this.txtvalorliquido.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor Liquido R$";
            // 
            // txttroco
            // 
            this.txttroco.BackColor = System.Drawing.Color.Lavender;
            this.txttroco.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroco.Location = new System.Drawing.Point(183, 246);
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(134, 24);
            this.txttroco.TabIndex = 11;
            // 
            // txtvalorrecebido
            // 
            this.txtvalorrecebido.BackColor = System.Drawing.Color.Lavender;
            this.txtvalorrecebido.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorrecebido.Location = new System.Drawing.Point(183, 212);
            this.txtvalorrecebido.Name = "txtvalorrecebido";
            this.txtvalorrecebido.Size = new System.Drawing.Size(134, 24);
            this.txtvalorrecebido.TabIndex = 10;
            this.txtvalorrecebido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvalorrecebido_KeyDown);
            // 
            // txtdesconto
            // 
            this.txtdesconto.BackColor = System.Drawing.Color.Lavender;
            this.txtdesconto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesconto.Location = new System.Drawing.Point(183, 99);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(134, 24);
            this.txtdesconto.TabIndex = 9;
            this.txtdesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdesconto_KeyDown);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.Lavender;
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(183, 65);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(134, 24);
            this.txttotal.TabIndex = 8;
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltroco.ForeColor = System.Drawing.Color.White;
            this.lbltroco.Location = new System.Drawing.Point(89, 250);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(82, 20);
            this.lbltroco.TabIndex = 7;
            this.lbltroco.Text = "Troco R$";
            // 
            // lblvalorrecebido
            // 
            this.lblvalorrecebido.AutoSize = true;
            this.lblvalorrecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorrecebido.ForeColor = System.Drawing.Color.White;
            this.lblvalorrecebido.Location = new System.Drawing.Point(11, 216);
            this.lblvalorrecebido.Name = "lblvalorrecebido";
            this.lblvalorrecebido.Size = new System.Drawing.Size(160, 20);
            this.lblvalorrecebido.TabIndex = 6;
            this.lblvalorrecebido.Text = "Valor Recebido R$";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(94, 73);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(77, 20);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total R$";
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesconto.ForeColor = System.Drawing.Color.White;
            this.lbldesconto.Location = new System.Drawing.Point(62, 107);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(114, 20);
            this.lbldesconto.TabIndex = 4;
            this.lbldesconto.Text = "Desconto R$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1103, 700);
            this.Controls.Add(this.gbtotal);
            this.Controls.Add(this.GBBotoes);
            this.Controls.Add(this.gbitens);
            this.Controls.Add(this.gbdados);
            this.Controls.Add(this.GBtitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecebimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recebimento";
            this.Load += new System.EventHandler(this.FrmRecebimento_Load);
            this.GBtitulo.ResumeLayout(false);
            this.GBtitulo.PerformLayout();
            this.GBBotoes.ResumeLayout(false);
            this.gbdados.ResumeLayout(false);
            this.gbdados.PerformLayout();
            this.gbitens.ResumeLayout(false);
            this.gbtotal.ResumeLayout(false);
            this.gbtotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBtitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.GroupBox GBBotoes;
        private System.Windows.Forms.Button btnservico;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btndiaria;
        private System.Windows.Forms.Button btnreceber;
        private System.Windows.Forms.Button btnsair;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbdados;
        private System.Windows.Forms.GroupBox gbitens;
        private System.Windows.Forms.GroupBox gbtotal;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtservico;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.ListView Meusitens;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.TextBox txtvalorrecebido;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.Label lblvalorrecebido;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.Button btnlimparlista;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lblservico;
        private System.Windows.Forms.TextBox txtvalorliquido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}