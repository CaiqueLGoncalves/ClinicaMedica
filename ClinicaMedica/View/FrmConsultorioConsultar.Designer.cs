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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvConsultorio = new System.Windows.Forms.DataGridView();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.rdbCidade = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.cmbExame = new System.Windows.Forms.ComboBox();
            this.tBExameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.tB_ExameTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter();
            this.rdbExame = new System.Windows.Forms.RadioButton();
            this.rdbTudo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultorio)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Consultórios";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(401, 19);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(376, 20);
            this.txtBusca.TabIndex = 2;
            this.txtBusca.Visible = false;
            this.txtBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyUp);
            // 
            // dgvConsultorio
            // 
            this.dgvConsultorio.AllowUserToAddRows = false;
            this.dgvConsultorio.AllowUserToDeleteRows = false;
            this.dgvConsultorio.AllowUserToResizeColumns = false;
            this.dgvConsultorio.AllowUserToResizeRows = false;
            this.dgvConsultorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultorio.Location = new System.Drawing.Point(3, 145);
            this.dgvConsultorio.Name = "dgvConsultorio";
            this.dgvConsultorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultorio.Size = new System.Drawing.Size(891, 304);
            this.dgvConsultorio.TabIndex = 3;
            this.dgvConsultorio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultorio_CellContentClick);
            this.dgvConsultorio.DoubleClick += new System.EventHandler(this.dgvConsultorio_DoubleClick);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.cmbExame);
            this.gpbFiltro.Controls.Add(this.rdbTudo);
            this.gpbFiltro.Controls.Add(this.rdbExame);
            this.gpbFiltro.Controls.Add(this.rdbCidade);
            this.gpbFiltro.Controls.Add(this.rdbNome);
            this.gpbFiltro.Controls.Add(this.txtBusca);
            this.gpbFiltro.Location = new System.Drawing.Point(23, 52);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(871, 50);
            this.gpbFiltro.TabIndex = 4;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Busca Aberta";
            // 
            // rdbCidade
            // 
            this.rdbCidade.AutoSize = true;
            this.rdbCidade.Location = new System.Drawing.Point(129, 20);
            this.rdbCidade.Name = "rdbCidade";
            this.rdbCidade.Size = new System.Drawing.Size(58, 17);
            this.rdbCidade.TabIndex = 1;
            this.rdbCidade.TabStop = true;
            this.rdbCidade.Text = "Cidade";
            this.rdbCidade.UseVisualStyleBackColor = true;
            this.rdbCidade.CheckedChanged += new System.EventHandler(this.rdbCidade_CheckedChanged);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(70, 20);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 0;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // cmbExame
            // 
            this.cmbExame.DataSource = this.tBExameBindingSource;
            this.cmbExame.DisplayMember = "Nome";
            this.cmbExame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExame.Location = new System.Drawing.Point(401, 19);
            this.cmbExame.Name = "cmbExame";
            this.cmbExame.Size = new System.Drawing.Size(376, 21);
            this.cmbExame.TabIndex = 5;
            this.cmbExame.ValueMember = "IdExame";
            this.cmbExame.Visible = false;
            this.cmbExame.SelectedIndexChanged += new System.EventHandler(this.cmbExame_SelectedIndexChanged);
            // 
            // tBExameBindingSource
            // 
            this.tBExameBindingSource.DataMember = "TB_Exame";
            this.tBExameBindingSource.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // clinicaMedicaBDDataSet
            // 
            this.clinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.clinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_ExameTableAdapter
            // 
            this.tB_ExameTableAdapter.ClearBeforeFill = true;
            // 
            // rdbExame
            // 
            this.rdbExame.AutoSize = true;
            this.rdbExame.Location = new System.Drawing.Point(194, 21);
            this.rdbExame.Name = "rdbExame";
            this.rdbExame.Size = new System.Drawing.Size(57, 17);
            this.rdbExame.TabIndex = 3;
            this.rdbExame.TabStop = true;
            this.rdbExame.Text = "Exame";
            this.rdbExame.UseVisualStyleBackColor = true;
            this.rdbExame.CheckedChanged += new System.EventHandler(this.rdbExame_CheckedChanged);
            // 
            // rdbTudo
            // 
            this.rdbTudo.AutoSize = true;
            this.rdbTudo.Checked = true;
            this.rdbTudo.Location = new System.Drawing.Point(257, 21);
            this.rdbTudo.Name = "rdbTudo";
            this.rdbTudo.Size = new System.Drawing.Size(78, 17);
            this.rdbTudo.TabIndex = 4;
            this.rdbTudo.TabStop = true;
            this.rdbTudo.Text = "Exibir Tudo";
            this.rdbTudo.UseVisualStyleBackColor = true;
            this.rdbTudo.CheckedChanged += new System.EventHandler(this.rdbTudo_CheckedChanged);
            // 
            // FrmConsultorioConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 461);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.dgvConsultorio);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultorioConsultar";
            this.Text = "Consulta de Consultório";
            this.Activated += new System.EventHandler(this.FrmConsultorioConsultar_Activated_1);
            this.Load += new System.EventHandler(this.FrmConsultorioConsultarcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultorio)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvConsultorio;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.RadioButton rdbCidade;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.ComboBox cmbExame;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource tBExameBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter tB_ExameTableAdapter;
        private System.Windows.Forms.RadioButton rdbTudo;
        private System.Windows.Forms.RadioButton rdbExame;
    }
}