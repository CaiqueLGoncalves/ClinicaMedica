namespace ClinicaMedica.View
{
    partial class FrmExameAgendarConsultar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.cmbExame = new System.Windows.Forms.ComboBox();
            this.dgvExame = new System.Windows.Forms.DataGridView();
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.tBConsultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ConsultorioTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter();
            this.tBExameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ExameTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rdbConsultorio = new System.Windows.Forms.RadioButton();
            this.rdbExame = new System.Windows.Forms.RadioButton();
            this.rdbPessoa = new System.Windows.Forms.RadioButton();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).BeginInit();
            this.gpbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Exames";
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.tBConsultorioBindingSource;
            this.cmbConsultorio.DisplayMember = "NomeFantasia";
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(123, 132);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(345, 21);
            this.cmbConsultorio.TabIndex = 2;
            this.cmbConsultorio.ValueMember = "IdConsultorio";
            this.cmbConsultorio.Visible = false;
            this.cmbConsultorio.SelectedIndexChanged += new System.EventHandler(this.cmbConsultorio_SelectedIndexChanged);
            // 
            // cmbExame
            // 
            this.cmbExame.DataSource = this.tBExameBindingSource;
            this.cmbExame.DisplayMember = "Nome";
            this.cmbExame.FormattingEnabled = true;
            this.cmbExame.Location = new System.Drawing.Point(123, 132);
            this.cmbExame.Name = "cmbExame";
            this.cmbExame.Size = new System.Drawing.Size(344, 21);
            this.cmbExame.TabIndex = 4;
            this.cmbExame.ValueMember = "IdExame";
            this.cmbExame.Visible = false;
            this.cmbExame.SelectedIndexChanged += new System.EventHandler(this.cmbExame_SelectedIndexChanged);
            // 
            // dgvExame
            // 
            this.dgvExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExame.Location = new System.Drawing.Point(58, 168);
            this.dgvExame.Name = "dgvExame";
            this.dgvExame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExame.Size = new System.Drawing.Size(571, 279);
            this.dgvExame.TabIndex = 5;
            this.dgvExame.DoubleClick += new System.EventHandler(this.dgvExame_DoubleClick);
            // 
            // clinicaMedicaBDDataSet
            // 
            this.clinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.clinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBConsultorioBindingSource
            // 
            this.tBConsultorioBindingSource.DataMember = "TB_Consultorio";
            this.tBConsultorioBindingSource.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // tB_ConsultorioTableAdapter
            // 
            this.tB_ConsultorioTableAdapter.ClearBeforeFill = true;
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
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rdbPessoa);
            this.gpbOpcoes.Controls.Add(this.rdbExame);
            this.gpbOpcoes.Controls.Add(this.rdbConsultorio);
            this.gpbOpcoes.Location = new System.Drawing.Point(123, 28);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(345, 98);
            this.gpbOpcoes.TabIndex = 6;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Selecione o Tipo de Consulta:";
            // 
            // rdbConsultorio
            // 
            this.rdbConsultorio.AutoSize = true;
            this.rdbConsultorio.Location = new System.Drawing.Point(7, 20);
            this.rdbConsultorio.Name = "rdbConsultorio";
            this.rdbConsultorio.Size = new System.Drawing.Size(77, 17);
            this.rdbConsultorio.TabIndex = 0;
            this.rdbConsultorio.TabStop = true;
            this.rdbConsultorio.Text = "Consultorio";
            this.rdbConsultorio.UseVisualStyleBackColor = true;
            this.rdbConsultorio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbExame
            // 
            this.rdbExame.AutoSize = true;
            this.rdbExame.Location = new System.Drawing.Point(7, 44);
            this.rdbExame.Name = "rdbExame";
            this.rdbExame.Size = new System.Drawing.Size(57, 17);
            this.rdbExame.TabIndex = 1;
            this.rdbExame.TabStop = true;
            this.rdbExame.Text = "Exame";
            this.rdbExame.UseVisualStyleBackColor = true;
            this.rdbExame.CheckedChanged += new System.EventHandler(this.rdbExame_CheckedChanged);
            // 
            // rdbPessoa
            // 
            this.rdbPessoa.AutoSize = true;
            this.rdbPessoa.Location = new System.Drawing.Point(7, 68);
            this.rdbPessoa.Name = "rdbPessoa";
            this.rdbPessoa.Size = new System.Drawing.Size(60, 17);
            this.rdbPessoa.TabIndex = 2;
            this.rdbPessoa.TabStop = true;
            this.rdbPessoa.Text = "Pessoa";
            this.rdbPessoa.UseVisualStyleBackColor = true;
            this.rdbPessoa.CheckedChanged += new System.EventHandler(this.rdbPessoa_CheckedChanged);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(123, 132);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(345, 20);
            this.txtBusca.TabIndex = 7;
            this.txtBusca.Visible = false;
            this.txtBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPessoa_KeyUp);
            // 
            // FrmExameAgendarConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 483);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.gpbOpcoes);
            this.Controls.Add(this.dgvExame);
            this.Controls.Add(this.cmbExame);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.label1);
            this.Name = "FrmExameAgendarConsultar";
            this.Text = "Consultar Exames Agendados";
            this.Load += new System.EventHandler(this.FrmExameAgendarConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).EndInit();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.ComboBox cmbExame;
        private System.Windows.Forms.DataGridView dgvExame;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource tBConsultorioBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter tB_ConsultorioTableAdapter;
        private System.Windows.Forms.BindingSource tBExameBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter tB_ExameTableAdapter;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rdbPessoa;
        private System.Windows.Forms.RadioButton rdbExame;
        private System.Windows.Forms.RadioButton rdbConsultorio;
        private System.Windows.Forms.TextBox txtBusca;
    }
}