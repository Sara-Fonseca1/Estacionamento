namespace Estacionamento
{
    partial class frmVeículo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeículo));
            this.gbbotoes = new System.Windows.Forms.GroupBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbdados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.cmbProprietario_cliente = new System.Windows.Forms.ComboBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lbln = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gbconsulta = new System.Windows.Forms.GroupBox();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.grdConsulta = new System.Windows.Forms.DataGridView();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbbotoes.SuspendLayout();
            this.gbdados.SuspendLayout();
            this.gbconsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbbotoes
            // 
            this.gbbotoes.BackColor = System.Drawing.Color.Teal;
            this.gbbotoes.Controls.Add(this.btnLimpa);
            this.gbbotoes.Controls.Add(this.btnNovo);
            this.gbbotoes.Controls.Add(this.btnAltera);
            this.gbbotoes.Controls.Add(this.btnSair);
            this.gbbotoes.Controls.Add(this.btnSalva);
            this.gbbotoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbbotoes.ForeColor = System.Drawing.Color.White;
            this.gbbotoes.Location = new System.Drawing.Point(12, 123);
            this.gbbotoes.Name = "gbbotoes";
            this.gbbotoes.Size = new System.Drawing.Size(141, 585);
            this.gbbotoes.TabIndex = 3;
            this.gbbotoes.TabStop = false;
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.Lavender;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.ForeColor = System.Drawing.Color.Teal;
            this.btnLimpa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpa.Image")));
            this.btnLimpa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpa.Location = new System.Drawing.Point(4, 364);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(131, 101);
            this.btnLimpa.TabIndex = 5;
            this.btnLimpa.Text = "Excluir";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Lavender;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Teal;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovo.Location = new System.Drawing.Point(4, 18);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(131, 105);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.BackColor = System.Drawing.Color.Lavender;
            this.btnAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltera.ForeColor = System.Drawing.Color.Teal;
            this.btnAltera.Image = ((System.Drawing.Image)(resources.GetObject("btnAltera.Image")));
            this.btnAltera.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAltera.Location = new System.Drawing.Point(4, 129);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(131, 108);
            this.btnAltera.TabIndex = 1;
            this.btnAltera.Text = "Altera";
            this.btnAltera.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lavender;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(4, 471);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 108);
            this.btnSair.TabIndex = 3;
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
            this.btnSalva.Location = new System.Drawing.Point(4, 243);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(131, 115);
            this.btnSalva.TabIndex = 2;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "VEÍCULO";
            // 
            // gbdados
            // 
            this.gbdados.BackColor = System.Drawing.Color.Teal;
            this.gbdados.Controls.Add(this.label2);
            this.gbdados.Controls.Add(this.txtPlaca);
            this.gbdados.Controls.Add(this.cmbProprietario_cliente);
            this.gbdados.Controls.Add(this.lblPlaca);
            this.gbdados.Controls.Add(this.lblValor);
            this.gbdados.Controls.Add(this.lblCodigo);
            this.gbdados.Controls.Add(this.txtcodigo);
            this.gbdados.Controls.Add(this.lbln);
            this.gbdados.Controls.Add(this.txtDescricao);
            this.gbdados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdados.ForeColor = System.Drawing.Color.White;
            this.gbdados.Location = new System.Drawing.Point(163, 123);
            this.gbdados.Name = "gbdados";
            this.gbdados.Size = new System.Drawing.Size(651, 238);
            this.gbdados.TabIndex = 4;
            this.gbdados.TabStop = false;
            this.gbdados.Text = "Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Proprietario/Cliente";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.Lavender;
            this.txtPlaca.Location = new System.Drawing.Point(13, 82);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 22);
            this.txtPlaca.TabIndex = 1;
            // 
            // cmbProprietario_cliente
            // 
            this.cmbProprietario_cliente.BackColor = System.Drawing.Color.Lavender;
            this.cmbProprietario_cliente.FormattingEnabled = true;
            this.cmbProprietario_cliente.Location = new System.Drawing.Point(14, 200);
            this.cmbProprietario_cliente.Name = "cmbProprietario_cliente";
            this.cmbProprietario_cliente.Size = new System.Drawing.Size(542, 24);
            this.cmbProprietario_cliente.TabIndex = 3;
            this.cmbProprietario_cliente.SelectedIndexChanged += new System.EventHandler(this.cmbProprietario_cliente_SelectedIndexChanged);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(10, 63);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 16);
            this.lblPlaca.TabIndex = 10;
            this.lblPlaca.Text = "Placa";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(10, 120);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(79, 16);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Descrição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(10, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 16);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.Teal;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(13, 37);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(83, 22);
            this.txtcodigo.TabIndex = 0;
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(175, 192);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(0, 16);
            this.lbln.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Lavender;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(13, 139);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(543, 22);
            this.txtDescricao.TabIndex = 2;
            // 
            // gbconsulta
            // 
            this.gbconsulta.BackColor = System.Drawing.Color.Teal;
            this.gbconsulta.Controls.Add(this.label3);
            this.gbconsulta.Controls.Add(this.btnconsulta);
            this.gbconsulta.Controls.Add(this.grdConsulta);
            this.gbconsulta.Controls.Add(this.txtConsulta);
            this.gbconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbconsulta.ForeColor = System.Drawing.Color.White;
            this.gbconsulta.Location = new System.Drawing.Point(163, 370);
            this.gbconsulta.Name = "gbconsulta";
            this.gbconsulta.Size = new System.Drawing.Size(651, 338);
            this.gbconsulta.TabIndex = 5;
            this.gbconsulta.TabStop = false;
            this.gbconsulta.Text = "Consulta";
            // 
            // btnconsulta
            // 
            this.btnconsulta.BackColor = System.Drawing.Color.Lavender;
            this.btnconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsulta.ForeColor = System.Drawing.Color.Teal;
            this.btnconsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnconsulta.Image")));
            this.btnconsulta.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnconsulta.Location = new System.Drawing.Point(247, 70);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(160, 41);
            this.btnconsulta.TabIndex = 13;
            this.btnconsulta.Text = "Buscar";
            this.btnconsulta.UseVisualStyleBackColor = false;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            this.btnconsulta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnconsulta_KeyDown);
            // 
            // grdConsulta
            // 
            this.grdConsulta.BackgroundColor = System.Drawing.Color.Lavender;
            this.grdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsulta.Location = new System.Drawing.Point(27, 117);
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.Size = new System.Drawing.Size(596, 196);
            this.grdConsulta.TabIndex = 1;
            this.grdConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsulta_CellDoubleClick);
            // 
            // txtConsulta
            // 
            this.txtConsulta.BackColor = System.Drawing.Color.Lavender;
            this.txtConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(65, 38);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(530, 26);
            this.txtConsulta.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Informe a placa";
            // 
            // frmVeículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(826, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbconsulta);
            this.Controls.Add(this.gbdados);
            this.Controls.Add(this.gbbotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVeículo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVeículo";
            this.Load += new System.EventHandler(this.frmVeículo_Load);
            this.gbbotoes.ResumeLayout(false);
            this.gbdados.ResumeLayout(false);
            this.gbdados.PerformLayout();
            this.gbconsulta.ResumeLayout(false);
            this.gbconsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbbotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gbdados;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gbconsulta;
        private System.Windows.Forms.DataGridView grdConsulta;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.ComboBox cmbProprietario_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}