namespace ClinicaMedica.View
{
    partial class FrmEstoqueCadastrar
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
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblRefrigeracao = new System.Windows.Forms.Label();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.cmbRefrigeracao = new System.Windows.Forms.ComboBox();
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.tBConsultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ConsultorioTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(53, 71);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(62, 13);
            this.lblConsultorio.TabIndex = 0;
            this.lblConsultorio.Text = "Consultório:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(56, 100);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblRefrigeracao
            // 
            this.lblRefrigeracao.AutoSize = true;
            this.lblRefrigeracao.Location = new System.Drawing.Point(59, 136);
            this.lblRefrigeracao.Name = "lblRefrigeracao";
            this.lblRefrigeracao.Size = new System.Drawing.Size(71, 13);
            this.lblRefrigeracao.TabIndex = 2;
            this.lblRefrigeracao.Text = "Refrigeração:";
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.tBConsultorioBindingSource;
            this.cmbConsultorio.DisplayMember = "NomeFantasia";
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(166, 62);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(121, 21);
            this.cmbConsultorio.TabIndex = 3;
            this.cmbConsultorio.ValueMember = "IdConsultorio";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(166, 100);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(121, 20);
            this.txbDescricao.TabIndex = 4;
            // 
            // cmbRefrigeracao
            // 
            this.cmbRefrigeracao.FormattingEnabled = true;
            this.cmbRefrigeracao.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cmbRefrigeracao.Location = new System.Drawing.Point(166, 127);
            this.cmbRefrigeracao.Name = "cmbRefrigeracao";
            this.cmbRefrigeracao.Size = new System.Drawing.Size(121, 21);
            this.cmbRefrigeracao.TabIndex = 5;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEstoqueCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbRefrigeracao);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.lblRefrigeracao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblConsultorio);
            this.Name = "FrmEstoqueCadastrar";
            this.Text = "FrmEstoqueCadastrar";
            this.Load += new System.EventHandler(this.FrmEstoqueCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblRefrigeracao;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.ComboBox cmbRefrigeracao;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource tBConsultorioBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter tB_ConsultorioTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}