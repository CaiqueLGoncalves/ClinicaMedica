﻿namespace ClinicaMedica.View
{
    partial class FrmConsultaCadastrar
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
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txbAnotacoes = new System.Windows.Forms.TextBox();
            this.lblAnotacoes = new System.Windows.Forms.Label();
            this.txbConsultorio = new System.Windows.Forms.TextBox();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.dgvListaPacientes = new System.Windows.Forms.DataGridView();
            this.gpbData = new System.Windows.Forms.GroupBox();
            this.dtpHorarioFinal = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioFinal = new System.Windows.Forms.Label();
            this.dtpHorarioInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioInicio = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblComparecimento = new System.Windows.Forms.Label();
            this.chkComparecimento = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).BeginInit();
            this.gpbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(165, 460);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(100, 23);
            this.btnAgendar.TabIndex = 9;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txbAnotacoes
            // 
            this.txbAnotacoes.Location = new System.Drawing.Point(146, 384);
            this.txbAnotacoes.Multiline = true;
            this.txbAnotacoes.Name = "txbAnotacoes";
            this.txbAnotacoes.Size = new System.Drawing.Size(270, 60);
            this.txbAnotacoes.TabIndex = 8;
            // 
            // lblAnotacoes
            // 
            this.lblAnotacoes.AutoSize = true;
            this.lblAnotacoes.Location = new System.Drawing.Point(12, 387);
            this.lblAnotacoes.Name = "lblAnotacoes";
            this.lblAnotacoes.Size = new System.Drawing.Size(61, 13);
            this.lblAnotacoes.TabIndex = 7;
            this.lblAnotacoes.Text = "Anotações:";
            // 
            // txbConsultorio
            // 
            this.txbConsultorio.Location = new System.Drawing.Point(149, 9);
            this.txbConsultorio.MaxLength = 30;
            this.txbConsultorio.Name = "txbConsultorio";
            this.txbConsultorio.ReadOnly = true;
            this.txbConsultorio.Size = new System.Drawing.Size(270, 20);
            this.txbConsultorio.TabIndex = 6;
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(12, 12);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(62, 13);
            this.lblConsultorio.TabIndex = 5;
            this.lblConsultorio.Text = "Consultório:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(12, 42);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(45, 13);
            this.lblMedico.TabIndex = 10;
            this.lblMedico.Text = "Médico:";
            // 
            // cmbMedico
            // 
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(149, 39);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(270, 21);
            this.cmbMedico.TabIndex = 11;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(12, 72);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 13);
            this.lblPaciente.TabIndex = 12;
            this.lblPaciente.Text = "Paciente:";
            // 
            // dgvListaPacientes
            // 
            this.dgvListaPacientes.AllowUserToAddRows = false;
            this.dgvListaPacientes.AllowUserToDeleteRows = false;
            this.dgvListaPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPacientes.Location = new System.Drawing.Point(149, 72);
            this.dgvListaPacientes.Name = "dgvListaPacientes";
            this.dgvListaPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPacientes.Size = new System.Drawing.Size(270, 150);
            this.dgvListaPacientes.TabIndex = 13;
            // 
            // gpbData
            // 
            this.gpbData.Controls.Add(this.dtpHorarioFinal);
            this.gpbData.Controls.Add(this.lblHorarioFinal);
            this.gpbData.Controls.Add(this.dtpHorarioInicio);
            this.gpbData.Controls.Add(this.lblHorarioInicio);
            this.gpbData.Controls.Add(this.txbData);
            this.gpbData.Controls.Add(this.lblData);
            this.gpbData.Location = new System.Drawing.Point(12, 230);
            this.gpbData.Name = "gpbData";
            this.gpbData.Size = new System.Drawing.Size(407, 107);
            this.gpbData.TabIndex = 14;
            this.gpbData.TabStop = false;
            // 
            // dtpHorarioFinal
            // 
            this.dtpHorarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioFinal.Location = new System.Drawing.Point(134, 74);
            this.dtpHorarioFinal.Name = "dtpHorarioFinal";
            this.dtpHorarioFinal.ShowUpDown = true;
            this.dtpHorarioFinal.Size = new System.Drawing.Size(260, 20);
            this.dtpHorarioFinal.TabIndex = 5;
            // 
            // lblHorarioFinal
            // 
            this.lblHorarioFinal.AutoSize = true;
            this.lblHorarioFinal.Location = new System.Drawing.Point(10, 80);
            this.lblHorarioFinal.Name = "lblHorarioFinal";
            this.lblHorarioFinal.Size = new System.Drawing.Size(75, 13);
            this.lblHorarioFinal.TabIndex = 4;
            this.lblHorarioFinal.Text = "Horário (Final):";
            // 
            // dtpHorarioInicio
            // 
            this.dtpHorarioInicio.CustomFormat = "";
            this.dtpHorarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioInicio.Location = new System.Drawing.Point(134, 45);
            this.dtpHorarioInicio.Name = "dtpHorarioInicio";
            this.dtpHorarioInicio.ShowUpDown = true;
            this.dtpHorarioInicio.Size = new System.Drawing.Size(260, 20);
            this.dtpHorarioInicio.TabIndex = 3;
            // 
            // lblHorarioInicio
            // 
            this.lblHorarioInicio.AutoSize = true;
            this.lblHorarioInicio.Location = new System.Drawing.Point(10, 50);
            this.lblHorarioInicio.Name = "lblHorarioInicio";
            this.lblHorarioInicio.Size = new System.Drawing.Size(80, 13);
            this.lblHorarioInicio.TabIndex = 2;
            this.lblHorarioInicio.Text = "Horário (Início):";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(134, 17);
            this.txbData.Name = "txbData";
            this.txbData.ReadOnly = true;
            this.txbData.Size = new System.Drawing.Size(260, 20);
            this.txbData.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(10, 20);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // lblComparecimento
            // 
            this.lblComparecimento.AutoSize = true;
            this.lblComparecimento.Location = new System.Drawing.Point(12, 357);
            this.lblComparecimento.Name = "lblComparecimento";
            this.lblComparecimento.Size = new System.Drawing.Size(89, 13);
            this.lblComparecimento.TabIndex = 15;
            this.lblComparecimento.Text = "Comparecimento:";
            // 
            // chkComparecimento
            // 
            this.chkComparecimento.AutoSize = true;
            this.chkComparecimento.Location = new System.Drawing.Point(146, 356);
            this.chkComparecimento.Name = "chkComparecimento";
            this.chkComparecimento.Size = new System.Drawing.Size(15, 14);
            this.chkComparecimento.TabIndex = 16;
            this.chkComparecimento.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 496);
            this.Controls.Add(this.chkComparecimento);
            this.Controls.Add(this.lblComparecimento);
            this.Controls.Add(this.gpbData);
            this.Controls.Add(this.dgvListaPacientes);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.txbAnotacoes);
            this.Controls.Add(this.lblAnotacoes);
            this.Controls.Add(this.txbConsultorio);
            this.Controls.Add(this.lblConsultorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento de Consultas";
            this.Load += new System.EventHandler(this.FrmConsultaCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).EndInit();
            this.gpbData.ResumeLayout(false);
            this.gpbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.TextBox txbAnotacoes;
        private System.Windows.Forms.Label lblAnotacoes;
        private System.Windows.Forms.TextBox txbConsultorio;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.DataGridView dgvListaPacientes;
        private System.Windows.Forms.GroupBox gpbData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Label lblHorarioInicio;
        private System.Windows.Forms.DateTimePicker dtpHorarioInicio;
        private System.Windows.Forms.Label lblHorarioFinal;
        private System.Windows.Forms.DateTimePicker dtpHorarioFinal;
        private System.Windows.Forms.Label lblComparecimento;
        private System.Windows.Forms.CheckBox chkComparecimento;
    }
}