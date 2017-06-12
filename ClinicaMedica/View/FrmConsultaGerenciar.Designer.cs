namespace ClinicaMedica.View
{
    partial class FrmConsultaGerenciar
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
            this.mclCalendario = new System.Windows.Forms.MonthCalendar();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.TBConsultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.TB_ConsultorioTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBConsultorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // mclCalendario
            // 
            this.mclCalendario.Location = new System.Drawing.Point(18, 18);
            this.mclCalendario.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.mclCalendario.MaxSelectionCount = 1;
            this.mclCalendario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.mclCalendario.Name = "mclCalendario";
            this.mclCalendario.ShowTodayCircle = false;
            this.mclCalendario.TabIndex = 0;
            this.mclCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mclCalendario_DateChanged);
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.TBConsultorioBindingSource;
            this.cmbConsultorio.DisplayMember = "NomeFantasia";
            this.cmbConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(18, 230);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(227, 21);
            this.cmbConsultorio.TabIndex = 1;
            this.cmbConsultorio.ValueMember = "IdConsultorio";
            this.cmbConsultorio.SelectedIndexChanged += new System.EventHandler(this.cmbConsultorio_SelectedIndexChanged);
            // 
            // TBConsultorioBindingSource
            // 
            this.TBConsultorioBindingSource.DataMember = "TB_Consultorio";
            this.TBConsultorioBindingSource.DataSource = this.ClinicaMedicaBDDataSet;
            // 
            // ClinicaMedicaBDDataSet
            // 
            this.ClinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.ClinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(18, 210);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(62, 13);
            this.lblConsultorio.TabIndex = 2;
            this.lblConsultorio.Text = "Consultório:";
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.Location = new System.Drawing.Point(18, 280);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(227, 30);
            this.btnNovaConsulta.TabIndex = 3;
            this.btnNovaConsulta.Text = "Nova Consulta";
            this.btnNovaConsulta.UseVisualStyleBackColor = true;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(277, 18);
            this.dgvConsultas.MultiSelect = false;
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(390, 292);
            this.dgvConsultas.TabIndex = 4;
            this.dgvConsultas.DoubleClick += new System.EventHandler(this.dgvConsultas_DoubleClick);
            // 
            // TB_ConsultorioTableAdapter
            // 
            this.TB_ConsultorioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsultaGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 326);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnNovaConsulta);
            this.Controls.Add(this.lblConsultorio);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.mclCalendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaGerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Consultas";
            this.Activated += new System.EventHandler(this.FrmConsultaGerenciar_Activated);
            this.Load += new System.EventHandler(this.FrmConsultaGerenciar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBConsultorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mclCalendario;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Button btnNovaConsulta;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private ClinicaMedicaBDDataSet ClinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource TBConsultorioBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter TB_ConsultorioTableAdapter;
    }
}