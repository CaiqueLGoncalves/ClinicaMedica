namespace ClinicaMedica.View
{
    partial class FrmPacienteManter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacienteManter));
            this.lblSexo = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.gpbContato = new System.Windows.Forms.GroupBox();
            this.mskTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneCelular = new System.Windows.Forms.Label();
            this.mskTelefoneComercial = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneComercial = new System.Windows.Forms.Label();
            this.mskTelefoneResidencial = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneResidencial = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.gpbLocalidade = new System.Windows.Forms.GroupBox();
            this.chkCEP = new System.Windows.Forms.CheckBox();
            this.btnBuscarCEP = new System.Windows.Forms.Button();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.gpbSexo.SuspendLayout();
            this.gpbContato.SuspendLayout();
            this.gpbLocalidade.SuspendLayout();
            this.gpbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(10, 145);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo:";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtFeminino);
            this.gpbSexo.Controls.Add(this.rbtMasculino);
            this.gpbSexo.Location = new System.Drawing.Point(143, 145);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(247, 55);
            this.gpbSexo.TabIndex = 9;
            this.gpbSexo.TabStop = false;
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(6, 33);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtFeminino.TabIndex = 1;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(6, 10);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // gpbContato
            // 
            this.gpbContato.Controls.Add(this.mskTelefoneCelular);
            this.gpbContato.Controls.Add(this.lblTelefoneCelular);
            this.gpbContato.Controls.Add(this.mskTelefoneComercial);
            this.gpbContato.Controls.Add(this.lblTelefoneComercial);
            this.gpbContato.Controls.Add(this.mskTelefoneResidencial);
            this.gpbContato.Controls.Add(this.lblTelefoneResidencial);
            this.gpbContato.Controls.Add(this.lblEmail);
            this.gpbContato.Controls.Add(this.txbEmail);
            this.gpbContato.Location = new System.Drawing.Point(15, 238);
            this.gpbContato.Name = "gpbContato";
            this.gpbContato.Size = new System.Drawing.Size(403, 150);
            this.gpbContato.TabIndex = 1;
            this.gpbContato.TabStop = false;
            this.gpbContato.Text = "Contato";
            // 
            // mskTelefoneCelular
            // 
            this.mskTelefoneCelular.Location = new System.Drawing.Point(134, 82);
            this.mskTelefoneCelular.Mask = "(99) 00000-0000";
            this.mskTelefoneCelular.Name = "mskTelefoneCelular";
            this.mskTelefoneCelular.Size = new System.Drawing.Size(256, 20);
            this.mskTelefoneCelular.TabIndex = 5;
            this.mskTelefoneCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelefoneCelular
            // 
            this.lblTelefoneCelular.AutoSize = true;
            this.lblTelefoneCelular.Location = new System.Drawing.Point(10, 85);
            this.lblTelefoneCelular.Name = "lblTelefoneCelular";
            this.lblTelefoneCelular.Size = new System.Drawing.Size(87, 13);
            this.lblTelefoneCelular.TabIndex = 4;
            this.lblTelefoneCelular.Text = "Telefone Celular:";
            // 
            // mskTelefoneComercial
            // 
            this.mskTelefoneComercial.Location = new System.Drawing.Point(134, 52);
            this.mskTelefoneComercial.Mask = "(99) 0000-0000";
            this.mskTelefoneComercial.Name = "mskTelefoneComercial";
            this.mskTelefoneComercial.Size = new System.Drawing.Size(256, 20);
            this.mskTelefoneComercial.TabIndex = 3;
            this.mskTelefoneComercial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelefoneComercial
            // 
            this.lblTelefoneComercial.AutoSize = true;
            this.lblTelefoneComercial.Location = new System.Drawing.Point(10, 55);
            this.lblTelefoneComercial.Name = "lblTelefoneComercial";
            this.lblTelefoneComercial.Size = new System.Drawing.Size(101, 13);
            this.lblTelefoneComercial.TabIndex = 2;
            this.lblTelefoneComercial.Text = "Telefone Comercial:";
            // 
            // mskTelefoneResidencial
            // 
            this.mskTelefoneResidencial.Location = new System.Drawing.Point(134, 22);
            this.mskTelefoneResidencial.Mask = "(99) 0000-0000";
            this.mskTelefoneResidencial.Name = "mskTelefoneResidencial";
            this.mskTelefoneResidencial.Size = new System.Drawing.Size(256, 20);
            this.mskTelefoneResidencial.TabIndex = 1;
            this.mskTelefoneResidencial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelefoneResidencial
            // 
            this.lblTelefoneResidencial.AutoSize = true;
            this.lblTelefoneResidencial.Location = new System.Drawing.Point(10, 25);
            this.lblTelefoneResidencial.Name = "lblTelefoneResidencial";
            this.lblTelefoneResidencial.Size = new System.Drawing.Size(110, 13);
            this.lblTelefoneResidencial.TabIndex = 0;
            this.lblTelefoneResidencial.Text = "Telefone Residencial:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(134, 112);
            this.txbEmail.MaxLength = 64;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(256, 20);
            this.txbEmail.TabIndex = 7;
            // 
            // gpbLocalidade
            // 
            this.gpbLocalidade.Controls.Add(this.chkCEP);
            this.gpbLocalidade.Controls.Add(this.btnBuscarCEP);
            this.gpbLocalidade.Controls.Add(this.mskCEP);
            this.gpbLocalidade.Controls.Add(this.cmbEstado);
            this.gpbLocalidade.Controls.Add(this.lblCEP);
            this.gpbLocalidade.Controls.Add(this.lblEndereco);
            this.gpbLocalidade.Controls.Add(this.txbCidade);
            this.gpbLocalidade.Controls.Add(this.txbEndereco);
            this.gpbLocalidade.Controls.Add(this.lblEstado);
            this.gpbLocalidade.Controls.Add(this.lblCidade);
            this.gpbLocalidade.Controls.Add(this.lblNumero);
            this.gpbLocalidade.Controls.Add(this.txbNumero);
            this.gpbLocalidade.Controls.Add(this.lblComplemento);
            this.gpbLocalidade.Controls.Add(this.txbComplemento);
            this.gpbLocalidade.Controls.Add(this.txbBairro);
            this.gpbLocalidade.Controls.Add(this.lblBairro);
            this.gpbLocalidade.Location = new System.Drawing.Point(15, 398);
            this.gpbLocalidade.Name = "gpbLocalidade";
            this.gpbLocalidade.Size = new System.Drawing.Size(403, 240);
            this.gpbLocalidade.TabIndex = 2;
            this.gpbLocalidade.TabStop = false;
            this.gpbLocalidade.Text = "Endereço";
            // 
            // chkCEP
            // 
            this.chkCEP.AutoSize = true;
            this.chkCEP.Location = new System.Drawing.Point(298, 24);
            this.chkCEP.Name = "chkCEP";
            this.chkCEP.Size = new System.Drawing.Size(95, 17);
            this.chkCEP.TabIndex = 3;
            this.chkCEP.Text = "Não sei o CEP";
            this.chkCEP.UseVisualStyleBackColor = true;
            this.chkCEP.CheckedChanged += new System.EventHandler(this.chkCEP_CheckedChanged);
            // 
            // btnBuscarCEP
            // 
            this.btnBuscarCEP.Location = new System.Drawing.Point(213, 20);
            this.btnBuscarCEP.Name = "btnBuscarCEP";
            this.btnBuscarCEP.Size = new System.Drawing.Size(65, 23);
            this.btnBuscarCEP.TabIndex = 2;
            this.btnBuscarCEP.Text = "Buscar";
            this.btnBuscarCEP.UseVisualStyleBackColor = true;
            this.btnBuscarCEP.Click += new System.EventHandler(this.btnBuscarCEP_Click);
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(132, 22);
            this.mskCEP.Mask = "00000-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(75, 20);
            this.mskCEP.TabIndex = 1;
            this.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA) ",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cmbEstado.Location = new System.Drawing.Point(134, 202);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(256, 21);
            this.cmbEstado.TabIndex = 15;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(10, 25);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(10, 55);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(134, 172);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.ReadOnly = true;
            this.txbCidade.Size = new System.Drawing.Size(256, 20);
            this.txbCidade.TabIndex = 13;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(134, 52);
            this.txbEndereco.MaxLength = 100;
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.ReadOnly = true;
            this.txbEndereco.Size = new System.Drawing.Size(256, 20);
            this.txbEndereco.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(10, 205);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(10, 175);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(10, 85);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Número:";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(134, 82);
            this.txbNumero.MaxLength = 6;
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(256, 20);
            this.txbNumero.TabIndex = 7;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(10, 115);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 8;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(134, 112);
            this.txbComplemento.MaxLength = 100;
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(256, 20);
            this.txbComplemento.TabIndex = 9;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(134, 142);
            this.txbBairro.MaxLength = 100;
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.ReadOnly = true;
            this.txbBairro.Size = new System.Drawing.Size(256, 20);
            this.txbBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(10, 145);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 10;
            this.lblBairro.Text = "Bairro:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(80, 648);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(143, 109);
            this.dtpDataNascimento.MaxDate = new System.DateTime(2017, 6, 30, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(247, 20);
            this.dtpDataNascimento.TabIndex = 7;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(10, 115);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 6;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(143, 82);
            this.txbRG.MaxLength = 12;
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(247, 20);
            this.txbRG.TabIndex = 5;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(10, 85);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 4;
            this.lblRG.Text = "RG:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(143, 52);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(247, 20);
            this.mskCPF.TabIndex = 3;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(10, 55);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(143, 22);
            this.txbNome.MaxLength = 100;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(247, 20);
            this.txbNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(255, 648);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 24);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Controls.Add(this.txbNome);
            this.gpbDadosPessoais.Controls.Add(this.lblSexo);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.gpbSexo);
            this.gpbDadosPessoais.Controls.Add(this.mskCPF);
            this.gpbDadosPessoais.Controls.Add(this.lblRG);
            this.gpbDadosPessoais.Controls.Add(this.txbRG);
            this.gpbDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.gpbDadosPessoais.Location = new System.Drawing.Point(15, 12);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(403, 215);
            this.gpbDadosPessoais.TabIndex = 0;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // FrmPacienteManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 691);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.gpbContato);
            this.Controls.Add(this.gpbLocalidade);
            this.Controls.Add(this.btnAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPacienteManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Pacientes";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbContato.ResumeLayout(false);
            this.gpbContato.PerformLayout();
            this.gpbLocalidade.ResumeLayout(false);
            this.gpbLocalidade.PerformLayout();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.GroupBox gpbContato;
        private System.Windows.Forms.MaskedTextBox mskTelefoneCelular;
        private System.Windows.Forms.Label lblTelefoneCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefoneComercial;
        private System.Windows.Forms.Label lblTelefoneComercial;
        private System.Windows.Forms.MaskedTextBox mskTelefoneResidencial;
        private System.Windows.Forms.Label lblTelefoneResidencial;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.GroupBox gpbLocalidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.CheckBox chkCEP;
        private System.Windows.Forms.Button btnBuscarCEP;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
    }
}