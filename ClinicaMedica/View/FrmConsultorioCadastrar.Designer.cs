﻿namespace ClinicaMedica.View
{
    partial class FrmConsultorioCadastrar
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
            this.txbNomeFantasia = new System.Windows.Forms.TextBox();
            this.txbRazaoSocial = new System.Windows.Forms.TextBox();
            this.dtpHorairoAbertura = new System.Windows.Forms.DateTimePicker();
            this.dtpHorarioFechamento = new System.Windows.Forms.DateTimePicker();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblHorarioAbertura = new System.Windows.Forms.Label();
            this.lblHorarioFechamento = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnBuscarCep = new System.Windows.Forms.Button();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.lblExames = new System.Windows.Forms.Label();
            this.tBExameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ExameTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter();
            this.tBExameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tBExameBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dtgExame = new System.Windows.Forms.DataGridView();
            this.IdExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recomendacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbEndereço = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExame)).BeginInit();
            this.gpbEndereço.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNomeFantasia
            // 
            this.txbNomeFantasia.Location = new System.Drawing.Point(214, 29);
            this.txbNomeFantasia.Name = "txbNomeFantasia";
            this.txbNomeFantasia.Size = new System.Drawing.Size(192, 20);
            this.txbNomeFantasia.TabIndex = 0;
            // 
            // txbRazaoSocial
            // 
            this.txbRazaoSocial.Location = new System.Drawing.Point(214, 65);
            this.txbRazaoSocial.Name = "txbRazaoSocial";
            this.txbRazaoSocial.Size = new System.Drawing.Size(192, 20);
            this.txbRazaoSocial.TabIndex = 1;
            // 
            // dtpHorairoAbertura
            // 
            this.dtpHorairoAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorairoAbertura.Location = new System.Drawing.Point(232, 143);
            this.dtpHorairoAbertura.Name = "dtpHorairoAbertura";
            this.dtpHorairoAbertura.ShowUpDown = true;
            this.dtpHorairoAbertura.Size = new System.Drawing.Size(82, 20);
            this.dtpHorairoAbertura.TabIndex = 3;
            this.dtpHorairoAbertura.Value = new System.DateTime(2017, 5, 28, 0, 0, 0, 0);
            this.dtpHorairoAbertura.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpHorarioFechamento
            // 
            this.dtpHorarioFechamento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioFechamento.Location = new System.Drawing.Point(232, 178);
            this.dtpHorarioFechamento.Name = "dtpHorarioFechamento";
            this.dtpHorarioFechamento.ShowUpDown = true;
            this.dtpHorarioFechamento.Size = new System.Drawing.Size(82, 20);
            this.dtpHorarioFechamento.TabIndex = 4;
            this.dtpHorarioFechamento.Value = new System.DateTime(2017, 5, 28, 0, 0, 0, 0);
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(105, 29);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(81, 13);
            this.lblNomeFantasia.TabIndex = 5;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(105, 65);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazaoSocial.TabIndex = 6;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(108, 103);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(37, 13);
            this.lblCnpj.TabIndex = 7;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblHorarioAbertura
            // 
            this.lblHorarioAbertura.AutoSize = true;
            this.lblHorarioAbertura.Location = new System.Drawing.Point(105, 149);
            this.lblHorarioAbertura.Name = "lblHorarioAbertura";
            this.lblHorarioAbertura.Size = new System.Drawing.Size(102, 13);
            this.lblHorarioAbertura.TabIndex = 8;
            this.lblHorarioAbertura.Text = "Horário de Abertura:";
            // 
            // lblHorarioFechamento
            // 
            this.lblHorarioFechamento.AutoSize = true;
            this.lblHorarioFechamento.Location = new System.Drawing.Point(105, 184);
            this.lblHorarioFechamento.Name = "lblHorarioFechamento";
            this.lblHorarioFechamento.Size = new System.Drawing.Size(118, 13);
            this.lblHorarioFechamento.TabIndex = 9;
            this.lblHorarioFechamento.Text = "Horário de Fechamento";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(33, 34);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(33, 65);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 11;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(33, 92);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Numero";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(33, 118);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 13;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(33, 147);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 14;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(33, 175);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(33, 210);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Enabled = false;
            this.txbEndereco.Location = new System.Drawing.Point(142, 58);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(192, 20);
            this.txbEndereco.TabIndex = 8;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(142, 85);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 9;
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(142, 115);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(192, 20);
            this.txbComplemento.TabIndex = 10;
            // 
            // txbBairro
            // 
            this.txbBairro.Enabled = false;
            this.txbBairro.Location = new System.Drawing.Point(142, 147);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(100, 20);
            this.txbBairro.TabIndex = 11;
            // 
            // txbCidade
            // 
            this.txbCidade.Enabled = false;
            this.txbCidade.Location = new System.Drawing.Point(142, 175);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(100, 20);
            this.txbCidade.TabIndex = 12;
            // 
            // txbEstado
            // 
            this.txbEstado.Enabled = false;
            this.txbEstado.Location = new System.Drawing.Point(142, 210);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(42, 20);
            this.txbEstado.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(108, 589);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnBuscarCep
            // 
            this.btnBuscarCep.Location = new System.Drawing.Point(259, 25);
            this.btnBuscarCep.Name = "btnBuscarCep";
            this.btnBuscarCep.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCep.TabIndex = 7;
            this.btnBuscarCep.Text = "Buscar";
            this.btnBuscarCep.UseVisualStyleBackColor = true;
            this.btnBuscarCep.Click += new System.EventHandler(this.btnBuscarCep_Click);
            // 
            // mskCnpj
            // 
            this.mskCnpj.Location = new System.Drawing.Point(214, 103);
            this.mskCnpj.Mask = "00,000,000/0000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(109, 20);
            this.mskCnpj.TabIndex = 2;
            this.mskCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(142, 25);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(100, 20);
            this.mskCep.TabIndex = 6;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblExames
            // 
            this.lblExames.AutoSize = true;
            this.lblExames.Location = new System.Drawing.Point(134, 540);
            this.lblExames.Name = "lblExames";
            this.lblExames.Size = new System.Drawing.Size(44, 13);
            this.lblExames.TabIndex = 25;
            this.lblExames.Text = "Exames";
            // 
            // tBExameBindingSource
            // 
            this.tBExameBindingSource.DataMember = "TB_Exame";
            // 
            // tB_ExameTableAdapter
            // 
            this.tB_ExameTableAdapter.ClearBeforeFill = true;
            // 
            // tBExameBindingSource1
            // 
            this.tBExameBindingSource1.DataMember = "TB_Exame";
            // 
            // clinicaMedicaBDDataSet
            // 
            this.clinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.clinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(108, 220);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 27;
            this.lblTelefone.Text = "Telefone";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(214, 212);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 5;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.dtgExame.Location = new System.Drawing.Point(214, 540);
            this.dtgExame.Name = "dtgExame";
            this.dtgExame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgExame.Size = new System.Drawing.Size(232, 150);
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
            this.gpbEndereço.Location = new System.Drawing.Point(75, 254);
            this.gpbEndereço.Name = "gpbEndereço";
            this.gpbEndereço.Size = new System.Drawing.Size(377, 252);
            this.gpbEndereço.TabIndex = 29;
            this.gpbEndereço.TabStop = false;
            this.gpbEndereço.Text = "Localidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(75, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 236);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Gerais";
            // 
            // FrmConsultorioCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 661);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.mskCnpj);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblHorarioFechamento);
            this.Controls.Add(this.dtgExame);
            this.Controls.Add(this.lblHorarioAbertura);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.dtpHorarioFechamento);
            this.Controls.Add(this.dtpHorairoAbertura);
            this.Controls.Add(this.txbRazaoSocial);
            this.Controls.Add(this.txbNomeFantasia);
            this.Controls.Add(this.lblExames);
            this.Controls.Add(this.gpbEndereço);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultorioCadastrar";
            this.Text = "Cadastro de Consultório";
            this.Load += new System.EventHandler(this.FrmConsultorioCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExame)).EndInit();
            this.gpbEndereço.ResumeLayout(false);
            this.gpbEndereço.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNomeFantasia;
        private System.Windows.Forms.TextBox txbRazaoSocial;
        private System.Windows.Forms.DateTimePicker dtpHorairoAbertura;
        private System.Windows.Forms.DateTimePicker dtpHorarioFechamento;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblHorarioAbertura;
        private System.Windows.Forms.Label lblHorarioFechamento;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnBuscarCep;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lblExames;
        private System.Windows.Forms.BindingSource tBExameBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter tB_ExameTableAdapter;
        private System.Windows.Forms.BindingSource tBExameBindingSource1;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.BindingSource tBExameBindingSource2;
        private System.Windows.Forms.DataGridView dtgExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recomendacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gpbEndereço;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}