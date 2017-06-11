namespace ClinicaMedica.View
{
    partial class FrmExameAgendar
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
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.lblExame = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.lblComparecimento = new System.Windows.Forms.Label();
            this.lblAnotacoes = new System.Windows.Forms.Label();
            this.txtConsultorio = new System.Windows.Forms.TextBox();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.dgvListaPacientes = new System.Windows.Forms.DataGridView();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.dtpHorarioInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHorarioFinal = new System.Windows.Forms.DateTimePicker();
            this.chkComparecimento = new System.Windows.Forms.CheckBox();
            this.txtAnotacoes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(73, 39);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(62, 13);
            this.lblConsultorio.TabIndex = 0;
            this.lblConsultorio.Text = "Consultório:";
            // 
            // lblExame
            // 
            this.lblExame.AutoSize = true;
            this.lblExame.Location = new System.Drawing.Point(73, 66);
            this.lblExame.Name = "lblExame";
            this.lblExame.Size = new System.Drawing.Size(42, 13);
            this.lblExame.TabIndex = 1;
            this.lblExame.Text = "Exame:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(73, 91);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 13);
            this.lblPaciente.TabIndex = 2;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(73, 261);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(38, 308);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(80, 13);
            this.lblInicio.TabIndex = 4;
            this.lblInicio.Text = "Horário (Início):";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(38, 332);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(75, 13);
            this.lblFim.TabIndex = 5;
            this.lblFim.Text = "Horário (Final):";
            // 
            // lblComparecimento
            // 
            this.lblComparecimento.AutoSize = true;
            this.lblComparecimento.Location = new System.Drawing.Point(38, 353);
            this.lblComparecimento.Name = "lblComparecimento";
            this.lblComparecimento.Size = new System.Drawing.Size(86, 13);
            this.lblComparecimento.TabIndex = 6;
            this.lblComparecimento.Text = "Comparecimento";
            // 
            // lblAnotacoes
            // 
            this.lblAnotacoes.AutoSize = true;
            this.lblAnotacoes.Location = new System.Drawing.Point(41, 383);
            this.lblAnotacoes.Name = "lblAnotacoes";
            this.lblAnotacoes.Size = new System.Drawing.Size(58, 13);
            this.lblAnotacoes.TabIndex = 7;
            this.lblAnotacoes.Text = "Anotações";
            // 
            // txtConsultorio
            // 
            this.txtConsultorio.Location = new System.Drawing.Point(164, 32);
            this.txtConsultorio.Name = "txtConsultorio";
            this.txtConsultorio.ReadOnly = true;
            this.txtConsultorio.Size = new System.Drawing.Size(240, 20);
            this.txtConsultorio.TabIndex = 9;
            // 
            // txtExame
            // 
            this.txtExame.Location = new System.Drawing.Point(164, 59);
            this.txtExame.Name = "txtExame";
            this.txtExame.ReadOnly = true;
            this.txtExame.Size = new System.Drawing.Size(240, 20);
            this.txtExame.TabIndex = 10;
            // 
            // dgvListaPacientes
            // 
            this.dgvListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPacientes.Location = new System.Drawing.Point(164, 91);
            this.dgvListaPacientes.Name = "dgvListaPacientes";
            this.dgvListaPacientes.Size = new System.Drawing.Size(240, 150);
            this.dgvListaPacientes.TabIndex = 11;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(189, 474);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 23);
            this.btnAgendar.TabIndex = 12;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(164, 261);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(240, 20);
            this.txtData.TabIndex = 13;
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioInicio.Location = new System.Drawing.Point(164, 300);
            this.dtpHorarioInicio.Name = "dtpHorarioInicio";
            this.dtpHorarioInicio.ShowUpDown = true;
            this.dtpHorarioInicio.Size = new System.Drawing.Size(240, 20);
            this.dtpHorarioInicio.TabIndex = 14;
            // 
            // dtpHorarioFinal
            // 
            this.dtpHorarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioFinal.Location = new System.Drawing.Point(164, 324);
            this.dtpHorarioFinal.Name = "dtpHorarioFinal";
            this.dtpHorarioFinal.ShowUpDown = true;
            this.dtpHorarioFinal.Size = new System.Drawing.Size(240, 20);
            this.dtpHorarioFinal.TabIndex = 15;
            // 
            // chkComparecimento
            // 
            this.chkComparecimento.AutoSize = true;
            this.chkComparecimento.Location = new System.Drawing.Point(164, 353);
            this.chkComparecimento.Name = "chkComparecimento";
            this.chkComparecimento.Size = new System.Drawing.Size(15, 14);
            this.chkComparecimento.TabIndex = 16;
            this.chkComparecimento.UseVisualStyleBackColor = true;
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.Location = new System.Drawing.Point(164, 383);
            this.txtAnotacoes.Multiline = true;
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.Size = new System.Drawing.Size(240, 76);
            this.txtAnotacoes.TabIndex = 17;
            // 
            // FrmExameAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 526);
            this.Controls.Add(this.txtAnotacoes);
            this.Controls.Add(this.chkComparecimento);
            this.Controls.Add(this.dtpHorarioFinal);
            this.Controls.Add(this.dtpHorarioInicio);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.dgvListaPacientes);
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
            this.Name = "FrmExameAgendar";
            this.Text = "FrmExameAgendar";
            this.Load += new System.EventHandler(this.FrmExameAgendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Label lblExame;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblComparecimento;
        private System.Windows.Forms.Label lblAnotacoes;
        private System.Windows.Forms.TextBox txtConsultorio;
        private System.Windows.Forms.TextBox txtExame;
        private System.Windows.Forms.DataGridView dgvListaPacientes;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.DateTimePicker dtpHorarioInicio;
        private System.Windows.Forms.DateTimePicker dtpHorarioFinal;
        private System.Windows.Forms.CheckBox chkComparecimento;
        private System.Windows.Forms.TextBox txtAnotacoes;
    }
}