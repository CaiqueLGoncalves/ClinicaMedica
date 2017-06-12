namespace ClinicaMedica.View
{
    partial class FrmMedicoCadastrar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicoCadastrar));
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbCRM = new System.Windows.Forms.TextBox();
            this.lblCRM = new System.Windows.Forms.Label();
            this.gpbDadosProfissionais = new System.Windows.Forms.GroupBox();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.IdEspecialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBEspecialidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.lblEspecialidades = new System.Windows.Forms.Label();
            this.TB_EspecialidadeTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_EspecialidadeTableAdapter();
            this.gpbPessoal = new System.Windows.Forms.GroupBox();
            this.gpbSexo.SuspendLayout();
            this.gpbContato.SuspendLayout();
            this.gpbLocalidade.SuspendLayout();
            this.gpbDadosProfissionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBEspecialidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaMedicaBDDataSet)).BeginInit();
            this.gpbPessoal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(10, 148);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo:";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtFeminino);
            this.gpbSexo.Controls.Add(this.rbtMasculino);
            this.gpbSexo.Location = new System.Drawing.Point(131, 138);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(259, 55);
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
            this.gpbContato.Location = new System.Drawing.Point(427, 9);
            this.gpbContato.Name = "gpbContato";
            this.gpbContato.Size = new System.Drawing.Size(406, 150);
            this.gpbContato.TabIndex = 2;
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
            this.gpbLocalidade.Location = new System.Drawing.Point(427, 165);
            this.gpbLocalidade.Name = "gpbLocalidade";
            this.gpbLocalidade.Size = new System.Drawing.Size(406, 240);
            this.gpbLocalidade.TabIndex = 4;
            this.gpbLocalidade.TabStop = false;
            this.gpbLocalidade.Text = "Endereço";
            // 
            // chkCEP
            // 
            this.chkCEP.AutoSize = true;
            this.chkCEP.Location = new System.Drawing.Point(300, 24);
            this.chkCEP.Name = "chkCEP";
            this.chkCEP.Size = new System.Drawing.Size(95, 17);
            this.chkCEP.TabIndex = 3;
            this.chkCEP.Text = "Não sei o CEP";
            this.chkCEP.UseVisualStyleBackColor = true;
            this.chkCEP.CheckedChanged += new System.EventHandler(this.chkCEP_CheckedChanged);
            // 
            // btnBuscarCEP
            // 
            this.btnBuscarCEP.Location = new System.Drawing.Point(215, 20);
            this.btnBuscarCEP.Name = "btnBuscarCEP";
            this.btnBuscarCEP.Size = new System.Drawing.Size(65, 23);
            this.btnBuscarCEP.TabIndex = 2;
            this.btnBuscarCEP.Text = "Buscar";
            this.btnBuscarCEP.UseVisualStyleBackColor = true;
            this.btnBuscarCEP.Click += new System.EventHandler(this.btnBuscarCEP_Click);
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(134, 22);
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
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(374, 415);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(131, 113);
            this.dtpDataNascimento.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(259, 20);
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
            this.txbRG.Location = new System.Drawing.Point(131, 82);
            this.txbRG.MaxLength = 12;
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(259, 20);
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
            this.mskCPF.Location = new System.Drawing.Point(131, 52);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(259, 20);
            this.mskCPF.TabIndex = 3;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(10, 55);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(131, 22);
            this.txbNome.MaxLength = 100;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(259, 20);
            this.txbNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txbCRM
            // 
            this.txbCRM.Location = new System.Drawing.Point(134, 22);
            this.txbCRM.MaxLength = 10;
            this.txbCRM.Name = "txbCRM";
            this.txbCRM.Size = new System.Drawing.Size(256, 20);
            this.txbCRM.TabIndex = 1;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(10, 25);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(34, 13);
            this.lblCRM.TabIndex = 0;
            this.lblCRM.Text = "CRM:";
            // 
            // gpbDadosProfissionais
            // 
            this.gpbDadosProfissionais.Controls.Add(this.dgvEspecialidades);
            this.gpbDadosProfissionais.Controls.Add(this.lblEspecialidades);
            this.gpbDadosProfissionais.Controls.Add(this.lblCRM);
            this.gpbDadosProfissionais.Controls.Add(this.txbCRM);
            this.gpbDadosProfissionais.Location = new System.Drawing.Point(12, 212);
            this.gpbDadosProfissionais.Name = "gpbDadosProfissionais";
            this.gpbDadosProfissionais.Size = new System.Drawing.Size(406, 193);
            this.gpbDadosProfissionais.TabIndex = 1;
            this.gpbDadosProfissionais.TabStop = false;
            this.gpbDadosProfissionais.Text = "Dados Profissionais";
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.AutoGenerateColumns = false;
            this.dgvEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspecialidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEspecialidade,
            this.Nome,
            this.Descricao});
            this.dgvEspecialidades.DataSource = this.TBEspecialidadeBindingSource;
            this.dgvEspecialidades.Location = new System.Drawing.Point(134, 55);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(256, 95);
            this.dgvEspecialidades.TabIndex = 3;
            // 
            // IdEspecialidade
            // 
            this.IdEspecialidade.DataPropertyName = "IdEspecialidade";
            this.IdEspecialidade.HeaderText = "IdEspecialidade";
            this.IdEspecialidade.Name = "IdEspecialidade";
            this.IdEspecialidade.ReadOnly = true;
            this.IdEspecialidade.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Lista de Especialidades";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Visible = false;
            // 
            // TBEspecialidadeBindingSource
            // 
            this.TBEspecialidadeBindingSource.DataMember = "TB_Especialidade";
            this.TBEspecialidadeBindingSource.DataSource = this.ClinicaMedicaBDDataSet;
            // 
            // ClinicaMedicaBDDataSet
            // 
            this.ClinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.ClinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEspecialidades
            // 
            this.lblEspecialidades.AutoSize = true;
            this.lblEspecialidades.Location = new System.Drawing.Point(10, 55);
            this.lblEspecialidades.Name = "lblEspecialidades";
            this.lblEspecialidades.Size = new System.Drawing.Size(81, 13);
            this.lblEspecialidades.TabIndex = 2;
            this.lblEspecialidades.Text = "Especialidades:";
            // 
            // TB_EspecialidadeTableAdapter
            // 
            this.TB_EspecialidadeTableAdapter.ClearBeforeFill = true;
            // 
            // gpbPessoal
            // 
            this.gpbPessoal.Controls.Add(this.lblSexo);
            this.gpbPessoal.Controls.Add(this.gpbSexo);
            this.gpbPessoal.Controls.Add(this.lblNome);
            this.gpbPessoal.Controls.Add(this.lblCPF);
            this.gpbPessoal.Controls.Add(this.lblRG);
            this.gpbPessoal.Controls.Add(this.dtpDataNascimento);
            this.gpbPessoal.Controls.Add(this.lblDataNascimento);
            this.gpbPessoal.Controls.Add(this.txbRG);
            this.gpbPessoal.Controls.Add(this.txbNome);
            this.gpbPessoal.Controls.Add(this.mskCPF);
            this.gpbPessoal.Location = new System.Drawing.Point(12, 9);
            this.gpbPessoal.Name = "gpbPessoal";
            this.gpbPessoal.Size = new System.Drawing.Size(406, 199);
            this.gpbPessoal.TabIndex = 0;
            this.gpbPessoal.TabStop = false;
            this.gpbPessoal.Text = "Dados Pessoais";
            // 
            // FrmMedicoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.gpbDadosProfissionais);
            this.Controls.Add(this.gpbContato);
            this.Controls.Add(this.gpbLocalidade);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbPessoal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMedicoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Médicos";
            this.Load += new System.EventHandler(this.FrmMedicoCadastrar_Load);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbContato.ResumeLayout(false);
            this.gpbContato.PerformLayout();
            this.gpbLocalidade.ResumeLayout(false);
            this.gpbLocalidade.PerformLayout();
            this.gpbDadosProfissionais.ResumeLayout(false);
            this.gpbDadosProfissionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBEspecialidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaMedicaBDDataSet)).EndInit();
            this.gpbPessoal.ResumeLayout(false);
            this.gpbPessoal.PerformLayout();
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
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbCRM;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.GroupBox gpbDadosProfissionais;
        private System.Windows.Forms.Label lblEspecialidades;
        private ClinicaMedicaBDDataSet ClinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource TBEspecialidadeBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_EspecialidadeTableAdapter TB_EspecialidadeTableAdapter;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEspecialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.CheckBox chkCEP;
        private System.Windows.Forms.Button btnBuscarCEP;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.GroupBox gpbPessoal;
    }
}