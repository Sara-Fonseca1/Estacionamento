namespace Estacionamento
{
    partial class FrmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.gbbotoes = new System.Windows.Forms.GroupBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbdados = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cmbfuncao = new System.Windows.Forms.ComboBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lbln = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.gbconsulta = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.grdConsulta = new System.Windows.Forms.DataGridView();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.gbbotoes.Controls.Add(this.btnSair);
            this.gbbotoes.Controls.Add(this.btnSalva);
            this.gbbotoes.Controls.Add(this.btnAltera);
            this.gbbotoes.Controls.Add(this.btnNovo);
            this.gbbotoes.ForeColor = System.Drawing.Color.White;
            this.gbbotoes.Location = new System.Drawing.Point(12, 117);
            this.gbbotoes.Name = "gbbotoes";
            this.gbbotoes.Size = new System.Drawing.Size(145, 598);
            this.gbbotoes.TabIndex = 1;
            this.gbbotoes.TabStop = false;
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.Lavender;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.ForeColor = System.Drawing.Color.Teal;
            this.btnLimpa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpa.Image")));
            this.btnLimpa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpa.Location = new System.Drawing.Point(6, 372);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(133, 108);
            this.btnLimpa.TabIndex = 4;
            this.btnLimpa.Text = "Excluir";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Lavender;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(6, 486);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 106);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.Lavender;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.Teal;
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalva.Location = new System.Drawing.Point(6, 255);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(133, 111);
            this.btnSalva.TabIndex = 2;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.BackColor = System.Drawing.Color.Lavender;
            this.btnAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltera.ForeColor = System.Drawing.Color.Teal;
            this.btnAltera.Image = ((System.Drawing.Image)(resources.GetObject("btnAltera.Image")));
            this.btnAltera.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAltera.Location = new System.Drawing.Point(6, 139);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(133, 110);
            this.btnAltera.TabIndex = 1;
            this.btnAltera.Text = "Altera";
            this.btnAltera.UseVisualStyleBackColor = false;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Lavender;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Teal;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovo.Location = new System.Drawing.Point(6, 16);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(133, 114);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "FUNCIONÁRIO";
            // 
            // gbdados
            // 
            this.gbdados.BackColor = System.Drawing.Color.Teal;
            this.gbdados.Controls.Add(this.txtTelefone);
            this.gbdados.Controls.Add(this.cmbfuncao);
            this.gbdados.Controls.Add(this.cmbUf);
            this.gbdados.Controls.Add(this.txtcep);
            this.gbdados.Controls.Add(this.txtnumero);
            this.gbdados.Controls.Add(this.txtCidade);
            this.gbdados.Controls.Add(this.txtRua);
            this.gbdados.Controls.Add(this.txtBairro);
            this.gbdados.Controls.Add(this.lblUf);
            this.gbdados.Controls.Add(this.rbAtivo);
            this.gbdados.Controls.Add(this.rbInativo);
            this.gbdados.Controls.Add(this.lblNome);
            this.gbdados.Controls.Add(this.lblTelefone);
            this.gbdados.Controls.Add(this.lblCodigo);
            this.gbdados.Controls.Add(this.lblCep);
            this.gbdados.Controls.Add(this.lblCidade);
            this.gbdados.Controls.Add(this.txtcodigo);
            this.gbdados.Controls.Add(this.lbln);
            this.gbdados.Controls.Add(this.txtNome);
            this.gbdados.Controls.Add(this.lblBairro);
            this.gbdados.Controls.Add(this.lblFuncao);
            this.gbdados.Controls.Add(this.lblRua);
            this.gbdados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdados.ForeColor = System.Drawing.Color.White;
            this.gbdados.Location = new System.Drawing.Point(163, 117);
            this.gbdados.Name = "gbdados";
            this.gbdados.Size = new System.Drawing.Size(663, 285);
            this.gbdados.TabIndex = 2;
            this.gbdados.TabStop = false;
            this.gbdados.Text = "Dados";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(9, 120);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(293, 22);
            this.txtTelefone.TabIndex = 15;
            // 
            // cmbfuncao
            // 
            this.cmbfuncao.BackColor = System.Drawing.Color.Lavender;
            this.cmbfuncao.FormattingEnabled = true;
            this.cmbfuncao.Items.AddRange(new object[] {
            "Atendente",
            "Gerente",
            "Lavador",
            "Manobrista"});
            this.cmbfuncao.Location = new System.Drawing.Point(451, 74);
            this.cmbfuncao.Name = "cmbfuncao";
            this.cmbfuncao.Size = new System.Drawing.Size(205, 24);
            this.cmbfuncao.TabIndex = 1;
            // 
            // cmbUf
            // 
            this.cmbUf.BackColor = System.Drawing.Color.Lavender;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "AC\t ",
            "AL\t ",
            "AP\t ",
            "AM\t ",
            "BA\t ",
            "CE\t ",
            "DF\t ",
            "ES\t ",
            "GO\t ",
            "MA\t ",
            "MT\t ",
            "MS\t ",
            "MG\t ",
            "PA\t ",
            "PB\t ",
            "PR\t ",
            "PE\t ",
            "PI\t ",
            "RJ\t ",
            "RN\t ",
            "RS\t ",
            "RO\t ",
            "RR\t ",
            "SC\t ",
            "SP\t ",
            "SE\t ",
            "TO",
            "Cliente Internacional"});
            this.cmbUf.Location = new System.Drawing.Point(6, 250);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(228, 24);
            this.cmbUf.TabIndex = 8;
            // 
            // txtcep
            // 
            this.txtcep.BackColor = System.Drawing.Color.Lavender;
            this.txtcep.Location = new System.Drawing.Point(430, 208);
            this.txtcep.Mask = "0000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(229, 22);
            this.txtcep.TabIndex = 7;
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.Color.Lavender;
            this.txtnumero.Location = new System.Drawing.Point(350, 159);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(71, 22);
            this.txtnumero.TabIndex = 4;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.Lavender;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(6, 208);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(415, 22);
            this.txtCidade.TabIndex = 6;
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.Lavender;
            this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRua.Location = new System.Drawing.Point(9, 159);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(332, 22);
            this.txtRua.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.Lavender;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(430, 159);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(229, 22);
            this.txtBairro.TabIndex = 5;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(6, 233);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(23, 16);
            this.lblUf.TabIndex = 10;
            this.lblUf.Text = "Uf";
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(127, 35);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(61, 20);
            this.rbAtivo.TabIndex = 14;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(203, 35);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(72, 20);
            this.rbInativo.TabIndex = 13;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 101);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 16);
            this.lblTelefone.TabIndex = 11;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 16);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(427, 192);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(36, 16);
            this.lblCep.TabIndex = 7;
            this.lblCep.Text = "Cep";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 192);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 16);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.Teal;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.ForeColor = System.Drawing.Color.Teal;
            this.txtcodigo.Location = new System.Drawing.Point(6, 35);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(83, 22);
            this.txtcodigo.TabIndex = 2;
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(347, 145);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(21, 16);
            this.lbln.TabIndex = 6;
            this.lbln.Text = "n°";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Lavender;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(9, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(436, 22);
            this.txtNome.TabIndex = 0;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(427, 143);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 16);
            this.lblBairro.TabIndex = 5;
            this.lblBairro.Text = "Bairro";
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(448, 55);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(59, 16);
            this.lblFuncao.TabIndex = 4;
            this.lblFuncao.Text = "Funçao";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(6, 143);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(36, 16);
            this.lblRua.TabIndex = 3;
            this.lblRua.Text = "Rua";
            // 
            // gbconsulta
            // 
            this.gbconsulta.BackColor = System.Drawing.Color.Teal;
            this.gbconsulta.Controls.Add(this.label2);
            this.gbconsulta.Controls.Add(this.btnconsulta);
            this.gbconsulta.Controls.Add(this.grdConsulta);
            this.gbconsulta.Controls.Add(this.txtConsulta);
            this.gbconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbconsulta.ForeColor = System.Drawing.Color.White;
            this.gbconsulta.Location = new System.Drawing.Point(163, 408);
            this.gbconsulta.Name = "gbconsulta";
            this.gbconsulta.Size = new System.Drawing.Size(662, 307);
            this.gbconsulta.TabIndex = 3;
            this.gbconsulta.TabStop = false;
            this.gbconsulta.Text = "Consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite o Nome ou Telefone";
            // 
            // btnconsulta
            // 
            this.btnconsulta.BackColor = System.Drawing.Color.Lavender;
            this.btnconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsulta.ForeColor = System.Drawing.Color.Teal;
            this.btnconsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnconsulta.Image")));
            this.btnconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconsulta.Location = new System.Drawing.Point(245, 64);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(183, 40);
            this.btnconsulta.TabIndex = 10;
            this.btnconsulta.Text = "Buscar";
            this.btnconsulta.UseVisualStyleBackColor = false;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // grdConsulta
            // 
            this.grdConsulta.BackgroundColor = System.Drawing.Color.Lavender;
            this.grdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsulta.Location = new System.Drawing.Point(29, 110);
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.Size = new System.Drawing.Size(612, 180);
            this.grdConsulta.TabIndex = 1;
            this.grdConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsulta_CellContentClick);
            this.grdConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsulta_CellDoubleClick);
            // 
            // txtConsulta
            // 
            this.txtConsulta.BackColor = System.Drawing.Color.Lavender;
            this.txtConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(76, 32);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(515, 26);
            this.txtConsulta.TabIndex = 9;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
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
            this.groupBox1.Size = new System.Drawing.Size(813, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(837, 731);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbconsulta);
            this.Controls.Add(this.gbdados);
            this.Controls.Add(this.gbbotoes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
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
        private System.Windows.Forms.ComboBox cmbfuncao;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.GroupBox gbconsulta;
        private System.Windows.Forms.DataGridView grdConsulta;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label2;
    }
}