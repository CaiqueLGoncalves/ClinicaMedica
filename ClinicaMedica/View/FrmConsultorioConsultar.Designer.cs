namespace ClinicaMedica.View
{
    partial class FrmConsultorioConsultar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idConsultorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioAberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioFechamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeIdLocalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBConsultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaMedicaBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.consultorioExameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorioExameTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.ConsultorioExameTableAdapter();
            this.tB_ConsultorioTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioExameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsultorioDataGridViewTextBoxColumn,
            this.nomeFantasiaDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.horarioAberturaDataGridViewTextBoxColumn,
            this.horarioFechamentoDataGridViewTextBoxColumn,
            this.localidadeIdLocalidadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBConsultorioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idConsultorioDataGridViewTextBoxColumn
            // 
            this.idConsultorioDataGridViewTextBoxColumn.DataPropertyName = "IdConsultorio";
            this.idConsultorioDataGridViewTextBoxColumn.HeaderText = "IdConsultorio";
            this.idConsultorioDataGridViewTextBoxColumn.Name = "idConsultorioDataGridViewTextBoxColumn";
            this.idConsultorioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFantasiaDataGridViewTextBoxColumn
            // 
            this.nomeFantasiaDataGridViewTextBoxColumn.DataPropertyName = "NomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.HeaderText = "NomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.Name = "nomeFantasiaDataGridViewTextBoxColumn";
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // horarioAberturaDataGridViewTextBoxColumn
            // 
            this.horarioAberturaDataGridViewTextBoxColumn.DataPropertyName = "HorarioAbertura";
            this.horarioAberturaDataGridViewTextBoxColumn.HeaderText = "HorarioAbertura";
            this.horarioAberturaDataGridViewTextBoxColumn.Name = "horarioAberturaDataGridViewTextBoxColumn";
            // 
            // horarioFechamentoDataGridViewTextBoxColumn
            // 
            this.horarioFechamentoDataGridViewTextBoxColumn.DataPropertyName = "HorarioFechamento";
            this.horarioFechamentoDataGridViewTextBoxColumn.HeaderText = "HorarioFechamento";
            this.horarioFechamentoDataGridViewTextBoxColumn.Name = "horarioFechamentoDataGridViewTextBoxColumn";
            // 
            // localidadeIdLocalidadeDataGridViewTextBoxColumn
            // 
            this.localidadeIdLocalidadeDataGridViewTextBoxColumn.DataPropertyName = "Localidade_IdLocalidade";
            this.localidadeIdLocalidadeDataGridViewTextBoxColumn.HeaderText = "Localidade_IdLocalidade";
            this.localidadeIdLocalidadeDataGridViewTextBoxColumn.Name = "localidadeIdLocalidadeDataGridViewTextBoxColumn";
            // 
            // tBConsultorioBindingSource
            // 
            this.tBConsultorioBindingSource.DataMember = "TB_Consultorio";
            this.tBConsultorioBindingSource.DataSource = this.clinicaMedicaBDDataSetBindingSource;
            // 
            // clinicaMedicaBDDataSetBindingSource
            // 
            this.clinicaMedicaBDDataSetBindingSource.DataSource = this.clinicaMedicaBDDataSet;
            this.clinicaMedicaBDDataSetBindingSource.Position = 0;
            // 
            // clinicaMedicaBDDataSet
            // 
            this.clinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.clinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultorioExameBindingSource
            // 
            this.consultorioExameBindingSource.DataMember = "ConsultorioExame";
            this.consultorioExameBindingSource.DataSource = this.clinicaMedicaBDDataSetBindingSource;
            // 
            // consultorioExameTableAdapter
            // 
            this.consultorioExameTableAdapter.ClearBeforeFill = true;
            // 
            // tB_ConsultorioTableAdapter
            // 
            this.tB_ConsultorioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsultorioConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 445);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmConsultorioConsultar";
            this.Text = "Consulta de Consultório";
            this.Load += new System.EventHandler(this.FrmConsultorioConsultarcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioExameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clinicaMedicaBDDataSetBindingSource;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource consultorioExameBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.ConsultorioExameTableAdapter consultorioExameTableAdapter;
        private System.Windows.Forms.BindingSource tBConsultorioBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter tB_ConsultorioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsultorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioAberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioFechamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeIdLocalidadeDataGridViewTextBoxColumn;
    }
}