namespace Vendas
{
    partial class frmCadcliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadcliente));
            this.grpDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf_Cnpj = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtCpf_Cnpj = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.dttDataNasc = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblLougradouro = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtLougradouro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.bttCep = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblCel = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtCod_Clie = new System.Windows.Forms.TextBox();
            this.pctClie = new System.Windows.Forms.PictureBox();
            this.bttFoto = new System.Windows.Forms.Button();
            this.bttGravar = new System.Windows.Forms.Button();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.grpDadosPessoais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctClie)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.Controls.Add(this.txtCel);
            this.grpDadosPessoais.Controls.Add(this.lblCel);
            this.grpDadosPessoais.Controls.Add(this.txtTel);
            this.grpDadosPessoais.Controls.Add(this.lblTel);
            this.grpDadosPessoais.Controls.Add(this.txtEmail);
            this.grpDadosPessoais.Controls.Add(this.lblEmail);
            this.grpDadosPessoais.Controls.Add(this.groupBox1);
            this.grpDadosPessoais.Controls.Add(this.dttDataNasc);
            this.grpDadosPessoais.Controls.Add(this.txtRg);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.Controls.Add(this.txtCpf_Cnpj);
            this.grpDadosPessoais.Controls.Add(this.lblDataNasc);
            this.grpDadosPessoais.Controls.Add(this.lblRg);
            this.grpDadosPessoais.Controls.Add(this.lblCpf_Cnpj);
            this.grpDadosPessoais.Controls.Add(this.lblNome);
            this.grpDadosPessoais.Location = new System.Drawing.Point(12, 33);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Size = new System.Drawing.Size(466, 199);
            this.grpDadosPessoais.TabIndex = 0;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf_Cnpj
            // 
            this.lblCpf_Cnpj.AutoSize = true;
            this.lblCpf_Cnpj.Location = new System.Drawing.Point(6, 44);
            this.lblCpf_Cnpj.Name = "lblCpf_Cnpj";
            this.lblCpf_Cnpj.Size = new System.Drawing.Size(62, 13);
            this.lblCpf_Cnpj.TabIndex = 1;
            this.lblCpf_Cnpj.Text = "CPF/CNPJ:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(248, 44);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(26, 13);
            this.lblRg.TabIndex = 2;
            this.lblRg.Text = "RG:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(6, 80);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(61, 13);
            this.lblDataNasc.TabIndex = 3;
            this.lblDataNasc.Text = "Data Nasc.";
            // 
            // txtCpf_Cnpj
            // 
            this.txtCpf_Cnpj.Location = new System.Drawing.Point(74, 41);
            this.txtCpf_Cnpj.Name = "txtCpf_Cnpj";
            this.txtCpf_Cnpj.Size = new System.Drawing.Size(143, 20);
            this.txtCpf_Cnpj.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(357, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(280, 41);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(151, 20);
            this.txtRg.TabIndex = 6;
            // 
            // dttDataNasc
            // 
            this.dttDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttDataNasc.Location = new System.Drawing.Point(74, 80);
            this.dttDataNasc.Name = "dttDataNasc";
            this.dttDataNasc.Size = new System.Drawing.Size(78, 20);
            this.dttDataNasc.TabIndex = 7;
            this.dttDataNasc.Value = new System.DateTime(2018, 7, 24, 0, 0, 0, 0);
            this.dttDataNasc.ValueChanged += new System.EventHandler(this.dttDataNasc_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Location = new System.Drawing.Point(158, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(357, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.lblBairro);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.bttCep);
            this.grpEndereco.Controls.Add(this.lblComplemento);
            this.grpEndereco.Controls.Add(this.txtComplemento);
            this.grpEndereco.Controls.Add(this.txtCidade);
            this.grpEndereco.Controls.Add(this.lblCidade);
            this.grpEndereco.Controls.Add(this.txtNumero);
            this.grpEndereco.Controls.Add(this.lblNumero);
            this.grpEndereco.Controls.Add(this.txtLougradouro);
            this.grpEndereco.Controls.Add(this.lblUf);
            this.grpEndereco.Controls.Add(this.lblLougradouro);
            this.grpEndereco.Controls.Add(this.cmbEstado);
            this.grpEndereco.Controls.Add(this.txtCep);
            this.grpEndereco.Controls.Add(this.lblCep);
            this.grpEndereco.Location = new System.Drawing.Point(12, 294);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Size = new System.Drawing.Size(631, 155);
            this.grpEndereco.TabIndex = 1;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(6, 32);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(29, 13);
            this.lblCep.TabIndex = 1;
            this.lblCep.Text = "Cep:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(41, 29);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(71, 20);
            this.txtCep.TabIndex = 11;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC"});
            this.cmbEstado.Location = new System.Drawing.Point(280, 89);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(54, 21);
            this.cmbEstado.TabIndex = 12;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblLougradouro
            // 
            this.lblLougradouro.AutoSize = true;
            this.lblLougradouro.Location = new System.Drawing.Point(147, 32);
            this.lblLougradouro.Name = "lblLougradouro";
            this.lblLougradouro.Size = new System.Drawing.Size(70, 13);
            this.lblLougradouro.TabIndex = 13;
            this.lblLougradouro.Text = "Lougradouro:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(250, 92);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(24, 13);
            this.lblUf.TabIndex = 14;
            this.lblUf.Text = "UF:";
            // 
            // txtLougradouro
            // 
            this.txtLougradouro.Location = new System.Drawing.Point(223, 29);
            this.txtLougradouro.Name = "txtLougradouro";
            this.txtLougradouro.Size = new System.Drawing.Size(285, 20);
            this.txtLougradouro.TabIndex = 15;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(524, 32);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(22, 13);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Nº:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(552, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(51, 20);
            this.txtNumero.TabIndex = 16;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 92);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 17;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(55, 89);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(170, 20);
            this.txtCidade.TabIndex = 18;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(86, 55);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(168, 20);
            this.txtComplemento.TabIndex = 19;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(6, 58);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 20;
            this.lblComplemento.Text = "Complemento:";
            // 
            // bttCep
            // 
            this.bttCep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttCep.BackgroundImage")));
            this.bttCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttCep.Location = new System.Drawing.Point(118, 27);
            this.bttCep.Name = "bttCep";
            this.bttCep.Size = new System.Drawing.Size(31, 22);
            this.bttCep.TabIndex = 2;
            this.bttCep.UseVisualStyleBackColor = true;
            this.bttCep.Click += new System.EventHandler(this.bttCep_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(320, 55);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(168, 20);
            this.txtBairro.TabIndex = 21;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(277, 58);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 22;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(251, 80);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Telefone:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(309, 77);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(122, 20);
            this.txtTel.TabIndex = 12;
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(261, 106);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(42, 13);
            this.lblCel.TabIndex = 13;
            this.lblCel.Text = "Celular:";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(309, 103);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(122, 20);
            this.txtCel.TabIndex = 14;
            // 
            // txtCod_Clie
            // 
            this.txtCod_Clie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCod_Clie.Location = new System.Drawing.Point(36, 12);
            this.txtCod_Clie.Name = "txtCod_Clie";
            this.txtCod_Clie.Size = new System.Drawing.Size(44, 13);
            this.txtCod_Clie.TabIndex = 2;
            // 
            // pctClie
            // 
            this.pctClie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctClie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctClie.Location = new System.Drawing.Point(515, 33);
            this.pctClie.Name = "pctClie";
            this.pctClie.Size = new System.Drawing.Size(128, 150);
            this.pctClie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctClie.TabIndex = 3;
            this.pctClie.TabStop = false;
            this.pctClie.Click += new System.EventHandler(this.pctClie_Click);
            // 
            // bttFoto
            // 
            this.bttFoto.Location = new System.Drawing.Point(515, 190);
            this.bttFoto.Name = "bttFoto";
            this.bttFoto.Size = new System.Drawing.Size(128, 35);
            this.bttFoto.TabIndex = 4;
            this.bttFoto.Text = "Incluir Foto";
            this.bttFoto.UseVisualStyleBackColor = true;
            this.bttFoto.Click += new System.EventHandler(this.bttFoto_Click);
            // 
            // bttGravar
            // 
            this.bttGravar.Location = new System.Drawing.Point(12, 504);
            this.bttGravar.Name = "bttGravar";
            this.bttGravar.Size = new System.Drawing.Size(110, 43);
            this.bttGravar.TabIndex = 5;
            this.bttGravar.Text = "Gravar";
            this.bttGravar.UseVisualStyleBackColor = true;
            this.bttGravar.Click += new System.EventHandler(this.bttGravar_Click);
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(6, 19);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(68, 20);
            this.txtSexo.TabIndex = 13;
            this.txtSexo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmCadcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(871, 572);
            this.Controls.Add(this.bttGravar);
            this.Controls.Add(this.bttFoto);
            this.Controls.Add(this.pctClie);
            this.Controls.Add(this.txtCod_Clie);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.grpDadosPessoais);
            this.Name = "frmCadcliente";
            this.Text = "Cadastro de Cliente";
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctClie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosPessoais;
        private System.Windows.Forms.DateTimePicker dttDataNasc;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf_Cnpj;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf_Cnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Button bttCep;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLougradouro;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblLougradouro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtCod_Clie;
        public System.Windows.Forms.PictureBox pctClie;
        private System.Windows.Forms.Button bttFoto;
        private System.Windows.Forms.Button bttGravar;
        private System.Windows.Forms.TextBox txtSexo;
    }
}