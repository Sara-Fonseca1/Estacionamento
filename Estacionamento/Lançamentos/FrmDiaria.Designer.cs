namespace Estacionamento
{
    partial class FrmDiaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiaria));
            this.txtplaca = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnentrada = new System.Windows.Forms.Button();
            this.GBlista = new System.Windows.Forms.GroupBox();
            this.BtnConsultaPlacaVeiculo = new System.Windows.Forms.Button();
            this.txtconsultaplaca = new System.Windows.Forms.MaskedTextBox();
            this.txtconsultacliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdConsulta = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblveiculo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GBlista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtplaca
            // 
            this.txtplaca.BackColor = System.Drawing.Color.Lavender;
            this.txtplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplaca.Location = new System.Drawing.Point(134, 124);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(417, 35);
            this.txtplaca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe a Placa";
            // 
            // btnentrada
            // 
            this.btnentrada.BackColor = System.Drawing.Color.Lavender;
            this.btnentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrada.ForeColor = System.Drawing.Color.Teal;
            this.btnentrada.Location = new System.Drawing.Point(557, 124);
            this.btnentrada.Name = "btnentrada";
            this.btnentrada.Size = new System.Drawing.Size(113, 35);
            this.btnentrada.TabIndex = 3;
            this.btnentrada.Text = "Entrada";
            this.btnentrada.UseVisualStyleBackColor = false;
            this.btnentrada.Click += new System.EventHandler(this.btnentrada_Click);
            // 
            // GBlista
            // 
            this.GBlista.BackColor = System.Drawing.Color.Teal;
            this.GBlista.Controls.Add(this.BtnConsultaPlacaVeiculo);
            this.GBlista.Controls.Add(this.txtconsultaplaca);
            this.GBlista.Controls.Add(this.txtconsultacliente);
            this.GBlista.Controls.Add(this.label3);
            this.GBlista.Controls.Add(this.label2);
            this.GBlista.Controls.Add(this.grdConsulta);
            this.GBlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBlista.ForeColor = System.Drawing.Color.White;
            this.GBlista.Location = new System.Drawing.Point(12, 197);
            this.GBlista.Name = "GBlista";
            this.GBlista.Size = new System.Drawing.Size(783, 400);
            this.GBlista.TabIndex = 5;
            this.GBlista.TabStop = false;
            this.GBlista.Text = "Lista de veiculo no estacionamento";
            // 
            // BtnConsultaPlacaVeiculo
            // 
            this.BtnConsultaPlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaPlacaVeiculo.ForeColor = System.Drawing.Color.Teal;
            this.BtnConsultaPlacaVeiculo.Location = new System.Drawing.Point(312, 72);
            this.BtnConsultaPlacaVeiculo.Name = "BtnConsultaPlacaVeiculo";
            this.BtnConsultaPlacaVeiculo.Size = new System.Drawing.Size(160, 34);
            this.BtnConsultaPlacaVeiculo.TabIndex = 6;
            this.BtnConsultaPlacaVeiculo.Text = "ok";
            this.BtnConsultaPlacaVeiculo.UseVisualStyleBackColor = true;
            this.BtnConsultaPlacaVeiculo.Click += new System.EventHandler(this.BtnConsultaPlacaVeiculo_Click);
            // 
            // txtconsultaplaca
            // 
            this.txtconsultaplaca.BackColor = System.Drawing.Color.Lavender;
            this.txtconsultaplaca.Location = new System.Drawing.Point(23, 44);
            this.txtconsultaplaca.Name = "txtconsultaplaca";
            this.txtconsultaplaca.Size = new System.Drawing.Size(298, 22);
            this.txtconsultaplaca.TabIndex = 1;
            // 
            // txtconsultacliente
            // 
            this.txtconsultacliente.BackColor = System.Drawing.Color.Lavender;
            this.txtconsultacliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtconsultacliente.Location = new System.Drawing.Point(488, 45);
            this.txtconsultacliente.Name = "txtconsultacliente";
            this.txtconsultacliente.Size = new System.Drawing.Size(260, 22);
            this.txtconsultacliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Consulta pelo cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consulta pela Placa";
            // 
            // grdConsulta
            // 
            this.grdConsulta.BackgroundColor = System.Drawing.Color.Lavender;
            this.grdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsulta.Location = new System.Drawing.Point(23, 111);
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.Size = new System.Drawing.Size(745, 283);
            this.grdConsulta.TabIndex = 0;
            this.grdConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsulta_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(181, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 65);
            this.label4.TabIndex = 7;
            this.label4.Text = "SERVIÇO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 65);
            this.label5.TabIndex = 6;
            this.label5.Text = "DIÁRIA";
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
            this.groupBox3.Size = new System.Drawing.Size(783, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lavender;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(676, 120);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 71);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblveiculo
            // 
            this.lblveiculo.AutoSize = true;
            this.lblveiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblveiculo.ForeColor = System.Drawing.Color.Maroon;
            this.lblveiculo.Location = new System.Drawing.Point(408, 165);
            this.lblveiculo.Name = "lblveiculo";
            this.lblveiculo.Size = new System.Drawing.Size(63, 18);
            this.lblveiculo.TabIndex = 12;
            this.lblveiculo.Text = "Veiculo";
            this.lblveiculo.Click += new System.EventHandler(this.lblveiculo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(270, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Marca  do  Veiculo:";
            // 
            // FrmDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(807, 609);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblveiculo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GBlista);
            this.Controls.Add(this.btnentrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtplaca);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diaria";
            this.Load += new System.EventHandler(this.FrmDiaria_Load);
            this.GBlista.ResumeLayout(false);
            this.GBlista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtplaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnentrada;
        private System.Windows.Forms.GroupBox GBlista;
        private System.Windows.Forms.MaskedTextBox txtconsultaplaca;
        private System.Windows.Forms.TextBox txtconsultacliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnConsultaPlacaVeiculo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblveiculo;
        private System.Windows.Forms.Label label7;
    }
}