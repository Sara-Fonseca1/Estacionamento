namespace Estacionamento
{
    partial class FrmServiço
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServiço));
            this.gbbotoes = new System.Windows.Forms.GroupBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbconsulta = new System.Windows.Forms.GroupBox();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.grdConsulta = new System.Windows.Forms.DataGridView();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lbln = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.gbdados = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.ComboBox();
            this.gbbotoes.SuspendLayout();
            this.gbconsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            this.gbdados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbbotoes
            // 
            this.gbbotoes.BackColor = System.Drawing.Color.Teal;
            this.gbbotoes.Controls.Add(this.btnLimpa);
            this.gbbotoes.Controls.Add(this.btnSair);
            this.gbbotoes.Controls.Add(this.btnSalva);
            this.gbbotoes.Controls.Add(this.btnAltera);
            this.gbbotoes.Controls.Add(this.btnNovo);
            this.gbbotoes.Location = new System.Drawing.Point(12, 124);
            this.gbbotoes.Name = "gbbotoes";
            this.gbbotoes.Size = new System.Drawing.Size(141, 584);
            this.gbbotoes.TabIndex = 2;
            this.gbbotoes.TabStop = false;
            this.gbbotoes.Enter += new System.EventHandler(this.gbbotoes_Enter);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.Lavender;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.ForeColor = System.Drawing.Color.Teal;
            this.btnLimpa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpa.Image")));
            this.btnLimpa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpa.Location = new System.Drawing.Point(3, 361);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(132, 106);
            this.btnLimpa.TabIndex = 6;
            this.btnLimpa.Text = "Excluir";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lavender;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(6, 473);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 105);
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
            this.btnSalva.Location = new System.Drawing.Point(3, 246);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(132, 109);
            this.btnSalva.TabIndex = 2;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.BackColor = System.Drawing.Color.Lavender;
            this.btnAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltera.ForeColor = System.Drawing.Color.Teal;
            this.btnAltera.Image = ((System.Drawing.Image)(resources.GetObject("btnAltera.Image")));
            this.btnAltera.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAltera.Location = new System.Drawing.Point(3, 136);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(132, 104);
            this.btnAltera.TabIndex = 1;
            this.btnAltera.Text = "Altera";
            this.btnAltera.UseVisualStyleBackColor = false;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Lavender;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Teal;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovo.Location = new System.Drawing.Point(5, 16);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(132, 114);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 65);
            this.label2.TabIndex = 7;
            this.label2.Text = "SERVIÇO";
            // 
            // gbconsulta
            // 
            this.gbconsulta.BackColor = System.Drawing.Color.Teal;
            this.gbconsulta.Controls.Add(this.label1);
            this.gbconsulta.Controls.Add(this.btnconsulta);
            this.gbconsulta.Controls.Add(this.grdConsulta);
            this.gbconsulta.Controls.Add(this.txtConsulta);
            this.gbconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbconsulta.ForeColor = System.Drawing.Color.White;
            this.gbconsulta.Location = new System.Drawing.Point(159, 307);
            this.gbconsulta.Name = "gbconsulta";
            this.gbconsulta.Size = new System.Drawing.Size(662, 401);
            this.gbconsulta.TabIndex = 4;
            this.gbconsulta.TabStop = false;
            this.gbconsulta.Text = "Consulta";
            this.gbconsulta.Enter += new System.EventHandler(this.gbconsulta_Enter);
            // 
            // btnconsulta
            // 
            this.btnconsulta.BackColor = System.Drawing.Color.Lavender;
            this.btnconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsulta.ForeColor = System.Drawing.Color.Teal;
            this.btnconsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnconsulta.Image")));
            this.btnconsulta.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnconsulta.Location = new System.Drawing.Point(309, 77);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(145, 40);
            this.btnconsulta.TabIndex = 12;
            this.btnconsulta.Text = "Buscar";
            this.btnconsulta.UseVisualStyleBackColor = false;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // grdConsulta
            // 
            this.grdConsulta.BackgroundColor = System.Drawing.Color.Lavender;
            this.grdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsulta.Location = new System.Drawing.Point(33, 136);
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.Size = new System.Drawing.Size(605, 236);
            this.grdConsulta.TabIndex = 1;
            this.grdConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsulta_CellContentClick);
            this.grdConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsulta_CellDoubleClick);
            // 
            // txtConsulta
            // 
            this.txtConsulta.BackColor = System.Drawing.Color.Lavender;
            this.txtConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(84, 38);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(530, 26);
            this.txtConsulta.TabIndex = 3;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(171, 136);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(0, 16);
            this.lbln.TabIndex = 6;
            // 
            // txtvalor
            // 
            this.txtvalor.BackColor = System.Drawing.Color.Lavender;
            this.txtvalor.Location = new System.Drawing.Point(9, 130);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(172, 22);
            this.txtvalor.TabIndex = 2;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.Teal;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(6, 35);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(83, 22);
            this.txtcodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(6, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 16);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(6, 114);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(45, 16);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Valor";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.ForeColor = System.Drawing.Color.White;
            this.lbDescricao.Location = new System.Drawing.Point(11, 58);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(79, 16);
            this.lbDescricao.TabIndex = 10;
            this.lbDescricao.Text = "Descrição";
            // 
            // gbdados
            // 
            this.gbdados.BackColor = System.Drawing.Color.Teal;
            this.gbdados.Controls.Add(this.txtdescricao);
            this.gbdados.Controls.Add(this.lbDescricao);
            this.gbdados.Controls.Add(this.lblValor);
            this.gbdados.Controls.Add(this.lblCodigo);
            this.gbdados.Controls.Add(this.txtcodigo);
            this.gbdados.Controls.Add(this.txtvalor);
            this.gbdados.Controls.Add(this.lbln);
            this.gbdados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdados.ForeColor = System.Drawing.Color.White;
            this.gbdados.Location = new System.Drawing.Point(159, 124);
            this.gbdados.Name = "gbdados";
            this.gbdados.Size = new System.Drawing.Size(662, 177);
            this.gbdados.TabIndex = 3;
            this.gbdados.TabStop = false;
            this.gbdados.Text = "Dados";
            this.gbdados.Enter += new System.EventHandler(this.gbdados_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Informe a Descrição";
            // 
            // txtdescricao
            // 
            this.txtdescricao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtdescricao.FormattingEnabled = true;
            this.txtdescricao.Items.AddRange(new object[] {
            "ESTACIONAMENTO>>>>>>>>>>>>>>>>>>>>>>>>>>>",
            "Estacionar por Diaria",
            "Estacionar mensalista",
            "Estacionar por Hora",
            "LAVAGEM>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",
            "Lavagem Manual..................................................................." +
                "............",
            "Lavagem de Motor................................................................." +
                "...........",
            "Lavagem por Baixo................................................................" +
                ".............",
            "Lavagem Automática..............................................................." +
                "..........",
            "Lavagem Self-service............................................................." +
                ".............",
            "LIMPEZA>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",
            "Limpeza Ecológica................................................................" +
                "...............",
            "Limpeza de Motor................................................................." +
                "...............",
            "Limpeza Delivery................................................................." +
                ".................",
            "Higienização de Interior........................................................." +
                ".............",
            "Higienização de ar-condicionado.................................................." +
                "....",
            "ENCERAMENTO>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",
            "Enceramento de Pintura..........................................................." +
                "...........",
            "POLIMENTO>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",
            "Polimento de Pintura............................................................." +
                "..............",
            "Polimento de Vidros e Faróis....................................................." +
                ".........",
            "CRISTALIZAÇÃO>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",
            "Cristalização de Pintura........................................................." +
                "..............",
            "Cristalização de Vidro..........................................................." +
                "................",
            "VITRIFICAÇÃO>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",
            "Vitrificação de Pintura.........................................................." +
                ".................",
            "REVITALIZAÇÃO>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",
            "Revitalização de Pintura........................................................." +
                "...............",
            "Revitalização de Plásticos......................................................." +
                "..............",
            "HIDRATAÇÃO>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",
            "Hidratação de Couro.............................................................." +
                "................",
            "IMPERMEABILIZAÇÃO>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",
            "Impermeabilização de Estofados..................................................." +
                "........"});
            this.txtdescricao.Location = new System.Drawing.Point(6, 77);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(464, 24);
            this.txtdescricao.TabIndex = 12;
            // 
            // FrmServiço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(833, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbconsulta);
            this.Controls.Add(this.gbdados);
            this.Controls.Add(this.gbbotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServiço";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmServiço";
            this.Load += new System.EventHandler(this.FrmServiço_Load);
            this.gbbotoes.ResumeLayout(false);
            this.gbconsulta.ResumeLayout(false);
            this.gbconsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            this.gbdados.ResumeLayout(false);
            this.gbdados.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbconsulta;
        private System.Windows.Forms.DataGridView grdConsulta;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.GroupBox gbdados;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtdescricao;
    }
}