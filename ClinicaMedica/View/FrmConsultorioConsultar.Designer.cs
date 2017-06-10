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
            this.tBConsultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaMedicaBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.consultorioExameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorioExameTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.ConsultorioExameTableAdapter();
            this.tB_ConsultorioTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvConsultorio = new System.Windows.Forms.DataGridView();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.rdbExame = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioExameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultorio)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Consultórios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesquisa";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(211, 76);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(201, 20);
            this.txtBusca.TabIndex = 2;
            this.txtBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyUp);
            // 
            // dgvConsultorio
            // 
            this.dgvConsultorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultorio.Location = new System.Drawing.Point(81, 175);
            this.dgvConsultorio.Name = "dgvConsultorio";
            this.dgvConsultorio.Size = new System.Drawing.Size(544, 224);
            this.dgvConsultorio.TabIndex = 3;
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.rdbExame);
            this.gpbFiltro.Controls.Add(this.rdbNome);
            this.gpbFiltro.Location = new System.Drawing.Point(81, 127);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(544, 42);
            this.gpbFiltro.TabIndex = 4;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "groupBox1";
            // 
            // rdbExame
            // 
            this.rdbExame.AutoSize = true;
            this.rdbExame.Location = new System.Drawing.Point(179, 20);
            this.rdbExame.Name = "rdbExame";
            this.rdbExame.Size = new System.Drawing.Size(85, 17);
            this.rdbExame.TabIndex = 1;
            this.rdbExame.TabStop = true;
            this.rdbExame.Text = "radioButton2";
            this.rdbExame.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(54, 20);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(85, 17);
            this.rdbNome.TabIndex = 0;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "radioButton1";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // FrmConsultorioConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 445);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.dgvConsultorio);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultorioConsultar";
            this.Text = "Consulta de Consultório";
            this.Activated += new System.EventHandler(this.FrmConsultorioConsultar_Activated_1);
            this.Load += new System.EventHandler(this.FrmConsultorioConsultarcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioExameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultorio)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource clinicaMedicaBDDataSetBindingSource;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource consultorioExameBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.ConsultorioExameTableAdapter consultorioExameTableAdapter;
        private System.Windows.Forms.BindingSource tBConsultorioBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter tB_ConsultorioTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvConsultorio;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.RadioButton rdbExame;
        private System.Windows.Forms.RadioButton rdbNome;
    }
}