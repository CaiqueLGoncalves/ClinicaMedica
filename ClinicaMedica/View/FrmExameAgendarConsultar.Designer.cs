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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExameAgendarConsultar));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.tBConsultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.cmbExame = new System.Windows.Forms.ComboBox();
            this.tBExameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvExame = new System.Windows.Forms.DataGridView();
            this.tB_ConsultorioTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter();
            this.tB_ExameTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.rdbPessoa = new System.Windows.Forms.RadioButton();
            this.rdbExame = new System.Windows.Forms.RadioButton();
            this.rdbConsultorio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExame)).BeginInit();
            this.gpbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Exames";
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.tBConsultorioBindingSource;
            this.cmbConsultorio.DisplayMember = "NomeFantasia";
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(168, 41);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(524, 21);
            this.cmbConsultorio.TabIndex = 2;
            this.cmbConsultorio.ValueMember = "IdConsultorio";
            this.cmbConsultorio.Visible = false;
            this.cmbConsultorio.SelectedIndexChanged += new System.EventHandler(this.cmbConsultorio_SelectedIndexChanged);
            // 
            // tBConsultorioBindingSource
            // 
            this.tBConsultorioBindingSource.DataMember = "TB_Consultorio";
            this.tBConsultorioBindingSource.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // clinicaMedicaBDDataSet
            // 
            this.clinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.clinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbExame
            // 
            this.cmbExame.DataSource = this.tBExameBindingSource;
            this.cmbExame.DisplayMember = "Nome";
            this.cmbExame.FormattingEnabled = true;
            this.cmbExame.Location = new System.Drawing.Point(168, 41);
            this.cmbExame.Name = "cmbExame";
            this.cmbExame.Size = new System.Drawing.Size(523, 21);
            this.cmbExame.TabIndex = 4;
            this.cmbExame.ValueMember = "IdExame";
            this.cmbExame.Visible = false;
            this.cmbExame.SelectedIndexChanged += new System.EventHandler(this.cmbExame_SelectedIndexChanged);
            // 
            // tBExameBindingSource
            // 
            this.tBExameBindingSource.DataMember = "TB_Exame";
            this.tBExameBindingSource.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // dgvExame
            // 
            this.dgvExame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExame.Location = new System.Drawing.Point(12, 142);
            this.dgvExame.MultiSelect = false;
            this.dgvExame.Name = "dgvExame";
            this.dgvExame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExame.Size = new System.Drawing.Size(776, 279);
            this.dgvExame.TabIndex = 5;
            this.dgvExame.DoubleClick += new System.EventHandler(this.dgvExame_DoubleClick);
            // 
            // tB_ConsultorioTableAdapter
            // 
            this.tB_ConsultorioTableAdapter.ClearBeforeFill = true;
            // 
            // tB_ExameTableAdapter
            // 
            this.tB_ExameTableAdapter.ClearBeforeFill = true;
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.txtBusca);
            this.gpbOpcoes.Controls.Add(this.rdbPessoa);
            this.gpbOpcoes.Controls.Add(this.rdbExame);
            this.gpbOpcoes.Controls.Add(this.cmbExame);
            this.gpbOpcoes.Controls.Add(this.rdbConsultorio);
            this.gpbOpcoes.Controls.Add(this.cmbConsultorio);
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 38);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(776, 98);
            this.gpbOpcoes.TabIndex = 6;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Selecione o Tipo de Consulta:";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(168, 41);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(524, 20);
            this.txtBusca.TabIndex = 7;
            this.txtBusca.Visible = false;
            this.txtBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPessoa_KeyUp);
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
            // FrmExameAgendarConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.gpbOpcoes);
            this.Controls.Add(this.dgvExame);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmExameAgendarConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Exames Agendados";
            this.Activated += new System.EventHandler(this.FrmExameAgendarConsultar_Activated);
            this.Load += new System.EventHandler(this.FrmExameAgendarConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExame)).EndInit();
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