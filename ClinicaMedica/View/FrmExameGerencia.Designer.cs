namespace ClinicaMedica.View
{
    partial class FrmExameGerencia
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
            this.mntCalendario = new System.Windows.Forms.MonthCalendar();
            this.cmbExame = new System.Windows.Forms.ComboBox();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.dtgHorarios = new System.Windows.Forms.DataGridView();
            this.lblExame = new System.Windows.Forms.Label();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.tBExameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ExameTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mntCalendario
            // 
            this.mntCalendario.Location = new System.Drawing.Point(18, 13);
            this.mntCalendario.Name = "mntCalendario";
            this.mntCalendario.TabIndex = 0;
            // 
            // cmbExame
            // 
            this.cmbExame.DataSource = this.tBExameBindingSource;
            this.cmbExame.DisplayMember = "Nome";
            this.cmbExame.FormattingEnabled = true;
            this.cmbExame.Location = new System.Drawing.Point(18, 192);
            this.cmbExame.Name = "cmbExame";
            this.cmbExame.Size = new System.Drawing.Size(227, 21);
            this.cmbExame.TabIndex = 1;
            this.cmbExame.ValueMember = "IdExame";
            this.cmbExame.SelectedIndexChanged += new System.EventHandler(this.cmbExame_SelectedIndexChanged);
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.Enabled = false;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(18, 234);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(227, 21);
            this.cmbConsultorio.TabIndex = 2;
            // 
            // dtgHorarios
            // 
            this.dtgHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHorarios.Location = new System.Drawing.Point(279, 13);
            this.dtgHorarios.Name = "dtgHorarios";
            this.dtgHorarios.Size = new System.Drawing.Size(364, 280);
            this.dtgHorarios.TabIndex = 3;
            // 
            // lblExame
            // 
            this.lblExame.AutoSize = true;
            this.lblExame.Location = new System.Drawing.Point(15, 176);
            this.lblExame.Name = "lblExame";
            this.lblExame.Size = new System.Drawing.Size(42, 13);
            this.lblExame.TabIndex = 4;
            this.lblExame.Text = "Exame:";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(15, 218);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(59, 13);
            this.lblConsultorio.TabIndex = 5;
            this.lblConsultorio.Text = "Consultório";
            // 
            // btnNovo
            // 
            this.btnNovo.Enabled = false;
            this.btnNovo.Location = new System.Drawing.Point(18, 270);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(227, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo Exame";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // clinicaMedicaBDDataSet
            // 
            this.clinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.clinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBExameBindingSource
            // 
            this.tBExameBindingSource.DataMember = "TB_Exame";
            this.tBExameBindingSource.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // tB_ExameTableAdapter
            // 
            this.tB_ExameTableAdapter.ClearBeforeFill = true;
            // 
            // FrmExameGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 313);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblConsultorio);
            this.Controls.Add(this.lblExame);
            this.Controls.Add(this.dtgHorarios);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.cmbExame);
            this.Controls.Add(this.mntCalendario);
            this.Name = "FrmExameGerencia";
            this.Text = "Gerenciamento de Exames";
            this.Load += new System.EventHandler(this.FrmExameGerencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mntCalendario;
        private System.Windows.Forms.ComboBox cmbExame;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.DataGridView dtgHorarios;
        private System.Windows.Forms.Label lblExame;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Button btnNovo;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource tBExameBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter tB_ExameTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}