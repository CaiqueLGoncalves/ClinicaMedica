namespace ClinicaMedica.View
{
    partial class FrmConsultorioManter
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblHorarioFechamento = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.dtpHorarioFechamento = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioAbertura = new System.Windows.Forms.Label();
            this.txbNomeFantasia = new System.Windows.Forms.TextBox();
            this.dtpHorairoAbertura = new System.Windows.Forms.DateTimePicker();
            this.tB_ExameTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter();
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.tBExameBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dtgExame = new System.Windows.Forms.DataGridView();
            this.IdExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recomendacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbEndereço = new System.Windows.Forms.GroupBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnBuscarCep = new System.Windows.Forms.Button();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBExameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBExameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExame)).BeginInit();
            this.gpbEndereço.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(77, 538);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 32;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.mskTelefone);
            this.groupBox1.Controls.Add(this.txbRazaoSocial);
            this.groupBox1.Controls.Add(this.lblRazaoSocial);
            this.groupBox1.Controls.Add(this.mskCnpj);
            this.groupBox1.Controls.Add(this.lblHorarioFechamento);
            this.groupBox1.Controls.Add(this.lblNomeFantasia);
            this.groupBox1.Controls.Add(this.lblCnpj);
            this.groupBox1.Controls.Add(this.dtpHorarioFechamento);
            this.groupBox1.Controls.Add(this.lblHorarioAbertura);
            this.groupBox1.Controls.Add(this.txbNomeFantasia);
            this.groupBox1.Controls.Add(this.dtpHorairoAbertura);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 184);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Gerais";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(11, 152);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 27;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(98, 149);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 5;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txbRazaoSocial
            // 
            this.txbRazaoSocial.Location = new System.Drawing.Point(98, 45);
            this.txbRazaoSocial.Name = "txbRazaoSocial";
            this.txbRazaoSocial.Size = new System.Drawing.Size(248, 20);
            this.txbRazaoSocial.TabIndex = 1;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(11, 48);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazaoSocial.TabIndex = 6;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // mskCnpj
            // 
            this.mskCnpj.Location = new System.Drawing.Point(98, 71);
            this.mskCnpj.Mask = "00,000,000/0000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(109, 20);
            this.mskCnpj.TabIndex = 2;
            this.mskCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblHorarioFechamento
            // 
            this.lblHorarioFechamento.AutoSize = true;
            this.lblHorarioFechamento.Location = new System.Drawing.Point(11, 126);
            this.lblHorarioFechamento.Name = "lblHorarioFechamento";
            this.lblHorarioFechamento.Size = new System.Drawing.Size(69, 13);
            this.lblHorarioFechamento.TabIndex = 9;
            this.lblHorarioFechamento.Text = "Fechamento:";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(11, 22);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(81, 13);
            this.lblNomeFantasia.TabIndex = 5;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(11, 74);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(37, 13);
            this.lblCnpj.TabIndex = 7;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // dtpHorarioFechamento
            // 
            this.dtpHorarioFechamento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioFechamento.Location = new System.Drawing.Point(98, 123);
            this.dtpHorarioFechamento.Name = "dtpHorarioFechamento";
            this.dtpHorarioFechamento.ShowUpDown = true;
            this.dtpHorarioFechamento.Size = new System.Drawing.Size(82, 20);
            this.dtpHorarioFechamento.TabIndex = 4;
            this.dtpHorarioFechamento.Value = new System.DateTime(2017, 5, 28, 0, 0, 0, 0);
            // 
            // lblHorarioAbertura
            // 
            this.lblHorarioAbertura.AutoSize = true;
            this.lblHorarioAbertura.Location = new System.Drawing.Point(11, 100);
            this.lblHorarioAbertura.Name = "lblHorarioAbertura";
            this.lblHorarioAbertura.Size = new System.Drawing.Size(50, 13);
            this.lblHorarioAbertura.TabIndex = 8;
            this.lblHorarioAbertura.Text = "Abertura:";
            // 
            // txbNomeFantasia
            // 
            this.txbNomeFantasia.Location = new System.Drawing.Point(98, 19);
            this.txbNomeFantasia.Name = "txbNomeFantasia";
            this.txbNomeFantasia.Size = new System.Drawing.Size(248, 20);
            this.txbNomeFantasia.TabIndex = 0;
            // 
            // dtpHorairoAbertura
            // 
            this.dtpHorairoAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorairoAbertura.Location = new System.Drawing.Point(98, 97);
            this.dtpHorairoAbertura.Name = "dtpHorairoAbertura";
            this.dtpHorairoAbertura.ShowUpDown = true;
            this.dtpHorairoAbertura.Size = new System.Drawing.Size(82, 20);
            this.dtpHorairoAbertura.TabIndex = 3;
            this.dtpHorairoAbertura.Value = new System.DateTime(2017, 5, 28, 0, 0, 0, 0);
            // 
            // tB_ExameTableAdapter
            // 
            this.tB_ExameTableAdapter.ClearBeforeFill = true;
            // 
            // clinicaMedicaBDDataSet
            // 
            this.clinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.clinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(98, 150);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(248, 20);
            this.txbCidade.TabIndex = 12;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(26, 20);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP";
            // 
            // tBExameBindingSource2
            // 
            this.tBExameBindingSource2.DataMember = "TB_Exame";
            this.tBExameBindingSource2.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // dtgExame
            // 
            this.dtgExame.AllowUserToAddRows = false;
            this.dtgExame.AllowUserToDeleteRows = false;
            this.dtgExame.AutoGenerateColumns = false;
            this.dtgExame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgExame.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdExame,
            this.nomeDataGridViewTextBoxColumn,
            this.recomendacoesDataGridViewTextBoxColumn});
            this.dtgExame.DataSource = this.tBExameBindingSource2;
            this.dtgExame.Location = new System.Drawing.Point(6, 19);
            this.dtgExame.Name = "dtgExame";
            this.dtgExame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgExame.Size = new System.Drawing.Size(340, 82);
            this.dtgExame.TabIndex = 28;
            // 
            // IdExame
            // 
            this.IdExame.DataPropertyName = "IdExame";
            this.IdExame.HeaderText = "IdExame";
            this.IdExame.Name = "IdExame";
            this.IdExame.ReadOnly = true;
            this.IdExame.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // recomendacoesDataGridViewTextBoxColumn
            // 
            this.recomendacoesDataGridViewTextBoxColumn.DataPropertyName = "Recomendacoes";
            this.recomendacoesDataGridViewTextBoxColumn.HeaderText = "Recomendacoes";
            this.recomendacoesDataGridViewTextBoxColumn.Name = "recomendacoesDataGridViewTextBoxColumn";
            this.recomendacoesDataGridViewTextBoxColumn.Visible = false;
            // 
            // gpbEndereço
            // 
            this.gpbEndereço.Controls.Add(this.txbCidade);
            this.gpbEndereço.Controls.Add(this.lblCep);
            this.gpbEndereço.Controls.Add(this.txbBairro);
            this.gpbEndereço.Controls.Add(this.lblEndereco);
            this.gpbEndereço.Controls.Add(this.txbComplemento);
            this.gpbEndereço.Controls.Add(this.txbNumero);
            this.gpbEndereço.Controls.Add(this.lblNumero);
            this.gpbEndereço.Controls.Add(this.txbEstado);
            this.gpbEndereço.Controls.Add(this.txbEndereco);
            this.gpbEndereço.Controls.Add(this.lblComplemento);
            this.gpbEndereço.Controls.Add(this.lblEstado);
            this.gpbEndereço.Controls.Add(this.btnBuscarCep);
            this.gpbEndereço.Controls.Add(this.mskCep);
            this.gpbEndereço.Controls.Add(this.lblCidade);
            this.gpbEndereço.Controls.Add(this.lblBairro);
            this.gpbEndereço.Location = new System.Drawing.Point(12, 200);
            this.gpbEndereço.Name = "gpbEndereço";
            this.gpbEndereço.Size = new System.Drawing.Size(369, 219);
            this.gpbEndereço.TabIndex = 33;
            this.gpbEndereço.TabStop = false;
            this.gpbEndereço.Text = "Localidade";
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(98, 124);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(248, 20);
            this.txbBairro.TabIndex = 11;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(26, 46);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 11;
            this.lblEndereco.Text = "Endereço";
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(98, 98);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(248, 20);
            this.txbComplemento.TabIndex = 10;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(98, 72);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(26, 72);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Numero";
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(98, 176);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(42, 20);
            this.txbEstado.TabIndex = 13;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(98, 46);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(248, 20);
            this.txbEndereco.TabIndex = 8;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(26, 98);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 13;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 176);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado";
            // 
            // btnBuscarCep
            // 
            this.btnBuscarCep.Location = new System.Drawing.Point(204, 17);
            this.btnBuscarCep.Name = "btnBuscarCep";
            this.btnBuscarCep.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCep.TabIndex = 7;
            this.btnBuscarCep.Text = "Buscar";
            this.btnBuscarCep.UseVisualStyleBackColor = true;
            this.btnBuscarCep.Click += new System.EventHandler(this.btnBuscarCep_Click);
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(98, 20);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(100, 20);
            this.mskCep.TabIndex = 6;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(26, 150);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(26, 124);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 14;
            this.lblBairro.Text = "Bairro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgExame);
            this.groupBox2.Location = new System.Drawing.Point(12, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 107);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione um ou mais exames";
            // 
            // tBExameBindingSource
            // 
            this.tBExameBindingSource.DataMember = "TB_Exame";
            // 
            // tBExameBindingSource1
            // 
            this.tBExameBindingSource1.DataMember = "TB_Exame";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmConsultorioManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbEndereço);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmConsultorioManter";
            this.Text = "FrmConsultorioManter";
            this.Load += new System.EventHandler(this.FrmConsultorioManter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExame)).EndInit();
            this.gpbEndereço.ResumeLayout(false);
            this.gpbEndereço.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txbRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.Label lblHorarioFechamento;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.DateTimePicker dtpHorarioFechamento;
        private System.Windows.Forms.Label lblHorarioAbertura;
        private System.Windows.Forms.TextBox txbNomeFantasia;
        private System.Windows.Forms.DateTimePicker dtpHorairoAbertura;
        private System.Windows.Forms.BindingSource tBExameBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter tB_ExameTableAdapter;
        private System.Windows.Forms.BindingSource tBExameBindingSource1;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.BindingSource tBExameBindingSource2;
        private System.Windows.Forms.DataGridView dtgExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recomendacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gpbEndereço;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnBuscarCep;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}