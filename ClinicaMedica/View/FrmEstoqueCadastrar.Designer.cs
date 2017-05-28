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
            this.tBConsultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.cmbRefrigeracao = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tB_ConsultorioTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(57, 62);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(62, 13);
            this.lblConsultorio.TabIndex = 0;
            this.lblConsultorio.Text = "Consultório:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(57, 123);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblRefrigeracao
            // 
            this.lblRefrigeracao.AutoSize = true;
            this.lblRefrigeracao.Location = new System.Drawing.Point(59, 157);
            this.lblRefrigeracao.Name = "lblRefrigeracao";
            this.lblRefrigeracao.Size = new System.Drawing.Size(71, 13);
            this.lblRefrigeracao.TabIndex = 2;
            this.lblRefrigeracao.Text = "Refrigeração:";
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.tBConsultorioBindingSource;
            this.cmbConsultorio.DisplayMember = "NomeFantasia";
            this.cmbConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(166, 59);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(206, 21);
            this.cmbConsultorio.TabIndex = 1;
            this.cmbConsultorio.ValueMember = "IdConsultorio";
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
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(166, 116);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(121, 20);
            this.txbDescricao.TabIndex = 3;
            // 
            // cmbRefrigeracao
            // 
            this.cmbRefrigeracao.FormattingEnabled = true;
            this.cmbRefrigeracao.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cmbRefrigeracao.Location = new System.Drawing.Point(166, 148);
            this.cmbRefrigeracao.Name = "cmbRefrigeracao";
            this.cmbRefrigeracao.Size = new System.Drawing.Size(121, 21);
            this.cmbRefrigeracao.TabIndex = 4;
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
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(166, 90);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(206, 20);
            this.txbNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(59, 90);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // tB_ConsultorioTableAdapter
            // 
            this.tB_ConsultorioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEstoqueCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 355);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbRefrigeracao);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.lblRefrigeracao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblConsultorio);
            this.Name = "FrmEstoqueCadastrar";
            this.Text = "Cadastrar Estoque";
            this.Load += new System.EventHandler(this.FrmEstoqueCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource tBConsultorioBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter tB_ConsultorioTableAdapter;
    }
}