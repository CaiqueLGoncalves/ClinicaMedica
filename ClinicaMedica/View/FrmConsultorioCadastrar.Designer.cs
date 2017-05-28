namespace ClinicaMedica.View
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
            this.lblCnpj.Location = new System.Drawing.Point(105, 110);
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
            this.lblCep.Location = new System.Drawing.Point(105, 220);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(105, 251);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 11;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(105, 278);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Numero";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(105, 304);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 13;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(105, 333);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 14;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(105, 361);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(105, 396);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Enabled = false;
            this.txbEndereco.Location = new System.Drawing.Point(214, 244);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(192, 20);
            this.txbEndereco.TabIndex = 7;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(214, 271);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 8;
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(214, 301);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(192, 20);
            this.txbComplemento.TabIndex = 9;
            // 
            // txbBairro
            // 
            this.txbBairro.Enabled = false;
            this.txbBairro.Location = new System.Drawing.Point(214, 333);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(100, 20);
            this.txbBairro.TabIndex = 10;
            // 
            // txbCidade
            // 
            this.txbCidade.Enabled = false;
            this.txbCidade.Location = new System.Drawing.Point(214, 361);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(100, 20);
            this.txbCidade.TabIndex = 11;
            // 
            // txbEstado
            // 
            this.txbEstado.Enabled = false;
            this.txbEstado.Location = new System.Drawing.Point(214, 396);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(42, 20);
            this.txbEstado.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(214, 438);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnBuscarCep
            // 
            this.btnBuscarCep.Location = new System.Drawing.Point(331, 211);
            this.btnBuscarCep.Name = "btnBuscarCep";
            this.btnBuscarCep.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCep.TabIndex = 6;
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
            this.mskCep.Location = new System.Drawing.Point(214, 211);
            this.mskCep.Mask = "00000-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(100, 20);
            this.mskCep.TabIndex = 5;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FrmConsultorioCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 501);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.mskCnpj);
            this.Controls.Add(this.btnBuscarCep);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbComplemento);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblHorarioFechamento);
            this.Controls.Add(this.lblHorarioAbertura);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.dtpHorarioFechamento);
            this.Controls.Add(this.dtpHorairoAbertura);
            this.Controls.Add(this.txbRazaoSocial);
            this.Controls.Add(this.txbNomeFantasia);
            this.Name = "FrmConsultorioCadastrar";
            this.Text = "Cadastro de Consultório";
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
    }
}