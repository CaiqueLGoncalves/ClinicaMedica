namespace ClinicaMedica.View
{
    partial class FrmExameConsultorio
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
            this.lblExame = new System.Windows.Forms.Label();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.tBConsultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.cmbExame = new System.Windows.Forms.ComboBox();
            this.tBExameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInserir = new System.Windows.Forms.Button();
            this.tB_ConsultorioTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter();
            this.tB_ExameTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(98, 91);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(59, 13);
            this.lblConsultorio.TabIndex = 0;
            this.lblConsultorio.Text = "Consultório";
            // 
            // lblExame
            // 
            this.lblExame.AutoSize = true;
            this.lblExame.Location = new System.Drawing.Point(98, 126);
            this.lblExame.Name = "lblExame";
            this.lblExame.Size = new System.Drawing.Size(39, 13);
            this.lblExame.TabIndex = 1;
            this.lblExame.Text = "Exame";
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.tBConsultorioBindingSource;
            this.cmbConsultorio.DisplayMember = "NomeFantasia";
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(186, 83);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(121, 21);
            this.cmbConsultorio.TabIndex = 2;
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
            // cmbExame
            // 
            this.cmbExame.DataSource = this.tBExameBindingSource;
            this.cmbExame.DisplayMember = "Nome";
            this.cmbExame.FormattingEnabled = true;
            this.cmbExame.Location = new System.Drawing.Point(186, 118);
            this.cmbExame.Name = "cmbExame";
            this.cmbExame.Size = new System.Drawing.Size(121, 21);
            this.cmbExame.TabIndex = 3;
            this.cmbExame.ValueMember = "IdExame";
            // 
            // tBExameBindingSource
            // 
            this.tBExameBindingSource.DataMember = "TB_Exame";
            this.tBExameBindingSource.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(186, 162);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // tB_ConsultorioTableAdapter
            // 
            this.tB_ConsultorioTableAdapter.ClearBeforeFill = true;
            // 
            // tB_ExameTableAdapter
            // 
            this.tB_ExameTableAdapter.ClearBeforeFill = true;
            // 
            // FrmExameConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 333);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.cmbExame);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.lblExame);
            this.Controls.Add(this.lblConsultorio);
            this.Name = "FrmExameConsultorio";
            this.Text = "Inserir Exame em Consultório";
            this.Load += new System.EventHandler(this.FrmExameConsultorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBExameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Label lblExame;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.ComboBox cmbExame;
        private System.Windows.Forms.Button btnInserir;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource tBConsultorioBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter tB_ConsultorioTableAdapter;
        private System.Windows.Forms.BindingSource tBExameBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ExameTableAdapter tB_ExameTableAdapter;
    }
}