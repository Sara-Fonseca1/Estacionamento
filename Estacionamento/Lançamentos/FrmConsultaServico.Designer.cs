namespace Estacionamento
{
    partial class FrmConsultaServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaServico));
            this.grdservico = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdservico)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdservico
            // 
            this.grdservico.BackgroundColor = System.Drawing.Color.Lavender;
            this.grdservico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdservico.Location = new System.Drawing.Point(20, 124);
            this.grdservico.Name = "grdservico";
            this.grdservico.Size = new System.Drawing.Size(571, 369);
            this.grdservico.TabIndex = 1;
            this.grdservico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdservico_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 101);
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
            this.label5.Location = new System.Drawing.Point(106, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(485, 65);
            this.label5.TabIndex = 6;
            this.label5.Text = "CONSULTA SERVIÇO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Teal;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnBuscar.Location = new System.Drawing.Point(149, 74);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(150, 45);
            this.BtnBuscar.TabIndex = 12;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.txtconsulta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.grdservico);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 509);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Informe o serviço a ser consultado";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lavender;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(332, 73);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(142, 45);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtconsulta
            // 
            this.txtconsulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconsulta.FormattingEnabled = true;
            this.txtconsulta.Items.AddRange(new object[] {
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
            this.txtconsulta.Location = new System.Drawing.Point(59, 37);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(501, 24);
            this.txtconsulta.TabIndex = 15;
            this.txtconsulta.SelectedIndexChanged += new System.EventHandler(this.txtconsulta_SelectedIndexChanged);
            // 
            // FrmConsultaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(633, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaServico";
            this.Text = "Consulta Servico";
            this.Load += new System.EventHandler(this.FrmConsultaServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdservico)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdservico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtconsulta;
    }
}