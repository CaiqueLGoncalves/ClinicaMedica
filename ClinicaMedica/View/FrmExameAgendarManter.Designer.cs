namespace ClinicaMedica.View
{
    partial class FrmExameAgendarManter
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
            this.txtAnotacoes = new System.Windows.Forms.TextBox();
            this.chkComparecimento = new System.Windows.Forms.CheckBox();
            this.dtpHorarioFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpHorarioInicio = new System.Windows.Forms.DateTimePicker();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.txtConsultorio = new System.Windows.Forms.TextBox();
            this.lblAnotacoes = new System.Windows.Forms.Label();
            this.lblComparecimento = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblExame = new System.Windows.Forms.Label();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.mntData = new System.Windows.Forms.MonthCalendar();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.Location = new System.Drawing.Point(101, 336);
            this.txtAnotacoes.Multiline = true;
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.Size = new System.Drawing.Size(227, 76);
            this.txtAnotacoes.TabIndex = 34;
            // 
            // chkComparecimento
            // 
            this.chkComparecimento.AutoSize = true;
            this.chkComparecimento.Location = new System.Drawing.Point(101, 316);
            this.chkComparecimento.Name = "chkComparecimento";
            this.chkComparecimento.Size = new System.Drawing.Size(15, 14);
            this.chkComparecimento.TabIndex = 33;
            this.chkComparecimento.UseVisualStyleBackColor = true;
            // 
            // dtpHorarioFinal
            // 
            this.dtpHorarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioFinal.Location = new System.Drawing.Point(101, 290);
            this.dtpHorarioFinal.Name = "dtpHorarioFinal";
            this.dtpHorarioFinal.Size = new System.Drawing.Size(227, 20);
            this.dtpHorarioFinal.TabIndex = 32;
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioInicio.Location = new System.Drawing.Point(101, 264);
            this.dtpHorarioInicio.Name = "dtpHorarioInicio";
            this.dtpHorarioInicio.Size = new System.Drawing.Size(227, 20);
            this.dtpHorarioInicio.TabIndex = 31;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(15, 418);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 29;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtExame
            // 
            this.txtExame.Location = new System.Drawing.Point(101, 32);
            this.txtExame.Name = "txtExame";
            this.txtExame.ReadOnly = true;
            this.txtExame.Size = new System.Drawing.Size(227, 20);
            this.txtExame.TabIndex = 27;
            // 
            // txtConsultorio
            // 
            this.txtConsultorio.Location = new System.Drawing.Point(101, 6);
            this.txtConsultorio.Name = "txtConsultorio";
            this.txtConsultorio.ReadOnly = true;
            this.txtConsultorio.Size = new System.Drawing.Size(227, 20);
            this.txtConsultorio.TabIndex = 26;
            // 
            // lblAnotacoes
            // 
            this.lblAnotacoes.AutoSize = true;
            this.lblAnotacoes.Location = new System.Drawing.Point(12, 339);
            this.lblAnotacoes.Name = "lblAnotacoes";
            this.lblAnotacoes.Size = new System.Drawing.Size(58, 13);
            this.lblAnotacoes.TabIndex = 25;
            this.lblAnotacoes.Text = "Anotações";
            // 
            // lblComparecimento
            // 
            this.lblComparecimento.AutoSize = true;
            this.lblComparecimento.Location = new System.Drawing.Point(10, 316);
            this.lblComparecimento.Name = "lblComparecimento";
            this.lblComparecimento.Size = new System.Drawing.Size(86, 13);
            this.lblComparecimento.TabIndex = 24;
            this.lblComparecimento.Text = "Comparecimento";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(10, 290);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(75, 13);
            this.lblFim.TabIndex = 23;
            this.lblFim.Text = "Horário (Final):";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(10, 264);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(80, 13);
            this.lblInicio.TabIndex = 22;
            this.lblInicio.Text = "Horário (Início):";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 90);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 21;
            this.lblData.Text = "Data:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(12, 61);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 13);
            this.lblPaciente.TabIndex = 20;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblExame
            // 
            this.lblExame.AutoSize = true;
            this.lblExame.Location = new System.Drawing.Point(12, 35);
            this.lblExame.Name = "lblExame";
            this.lblExame.Size = new System.Drawing.Size(42, 13);
            this.lblExame.TabIndex = 19;
            this.lblExame.Text = "Exame:";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(10, 9);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(62, 13);
            this.lblConsultorio.TabIndex = 18;
            this.lblConsultorio.Text = "Consultório:";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(101, 58);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(227, 20);
            this.txtPaciente.TabIndex = 35;
            // 
            // mntData
            // 
            this.mntData.Location = new System.Drawing.Point(101, 90);
            this.mntData.Name = "mntData";
            this.mntData.TabIndex = 36;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(253, 418);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmExameAgendarManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 452);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.mntData);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtAnotacoes);
            this.Controls.Add(this.chkComparecimento);
            this.Controls.Add(this.dtpHorarioFinal);
            this.Controls.Add(this.dtpHorarioInicio);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtExame);
            this.Controls.Add(this.txtConsultorio);
            this.Controls.Add(this.lblAnotacoes);
            this.Controls.Add(this.lblComparecimento);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblExame);
            this.Controls.Add(this.lblConsultorio);
            this.Name = "FrmExameAgendarManter";
            this.Text = "Alterar/Excluir Exames Agendados";
            this.Load += new System.EventHandler(this.FrmExameAgendarManter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnotacoes;
        private System.Windows.Forms.CheckBox chkComparecimento;
        private System.Windows.Forms.DateTimePicker dtpHorarioFinal;
        private System.Windows.Forms.DateTimePicker dtpHorarioInicio;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtExame;
        private System.Windows.Forms.TextBox txtConsultorio;
        private System.Windows.Forms.Label lblAnotacoes;
        private System.Windows.Forms.Label lblComparecimento;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblExame;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.MonthCalendar mntData;
        private System.Windows.Forms.Button btnExcluir;
    }
}