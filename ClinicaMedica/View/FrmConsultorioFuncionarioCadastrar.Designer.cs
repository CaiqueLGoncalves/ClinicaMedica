namespace ClinicaMedica.View
{
    partial class FrmConsultorioFuncionarioCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultorioFuncionarioCadastrar));
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.TBConsultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.dtpDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.btnContratar = new System.Windows.Forms.Button();
            this.TB_ConsultorioTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBConsultorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(12, 42);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionario.TabIndex = 2;
            this.lblFuncionario.Text = "Funcionário:";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(12, 12);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(62, 13);
            this.lblConsultorio.TabIndex = 0;
            this.lblConsultorio.Text = "Consultório:";
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.TBConsultorioBindingSource;
            this.cmbConsultorio.DisplayMember = "NomeFantasia";
            this.cmbConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(149, 9);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(270, 21);
            this.cmbConsultorio.TabIndex = 1;
            this.cmbConsultorio.ValueMember = "IdConsultorio";
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
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(149, 42);
            this.dgvFuncionario.MultiSelect = false;
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(270, 150);
            this.dgvFuncionario.TabIndex = 3;
            // 
            // dtpDataAdmissao
            // 
            this.dtpDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdmissao.Location = new System.Drawing.Point(149, 205);
            this.dtpDataAdmissao.MaxDate = new System.DateTime(2017, 6, 12, 0, 0, 0, 0);
            this.dtpDataAdmissao.Name = "dtpDataAdmissao";
            this.dtpDataAdmissao.Size = new System.Drawing.Size(270, 20);
            this.dtpDataAdmissao.TabIndex = 5;
            this.dtpDataAdmissao.Value = new System.DateTime(2017, 6, 11, 0, 0, 0, 0);
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(12, 211);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(96, 13);
            this.lblDataAdmissao.TabIndex = 4;
            this.lblDataAdmissao.Text = "Data de Admissão:";
            // 
            // btnContratar
            // 
            this.btnContratar.Location = new System.Drawing.Point(166, 255);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(100, 23);
            this.btnContratar.TabIndex = 6;
            this.btnContratar.Text = "Contratar";
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // TB_ConsultorioTableAdapter
            // 
            this.TB_ConsultorioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsultorioFuncionarioCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 296);
            this.Controls.Add(this.lblDataAdmissao);
            this.Controls.Add(this.dtpDataAdmissao);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.btnContratar);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblConsultorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultorioFuncionarioCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contratação de Funcionários";
            this.Load += new System.EventHandler(this.FrmConsultorioFuncionarioCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBConsultorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DateTimePicker dtpDataAdmissao;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.Button btnContratar;
        private ClinicaMedicaBDDataSet ClinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource TBConsultorioBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter TB_ConsultorioTableAdapter;
    }
}