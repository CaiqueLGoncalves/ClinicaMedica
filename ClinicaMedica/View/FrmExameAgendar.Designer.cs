namespace ClinicaMedica.View
{
    partial class FrmExameAgendar
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
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.lblExame = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.tBConsultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ConsultorioTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(132, 134);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(35, 13);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "label1";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(132, 66);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(35, 13);
            this.lblConsultorio.TabIndex = 1;
            this.lblConsultorio.Text = "label1";
            // 
            // lblExame
            // 
            this.lblExame.AutoSize = true;
            this.lblExame.Location = new System.Drawing.Point(132, 103);
            this.lblExame.Name = "lblExame";
            this.lblExame.Size = new System.Drawing.Size(35, 13);
            this.lblExame.TabIndex = 2;
            this.lblExame.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tBConsultorioBindingSource;
            this.comboBox1.DisplayMember = "NomeFantasia";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "IdConsultorio";
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(174, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // FrmExameAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 384);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblExame);
            this.Controls.Add(this.lblConsultorio);
            this.Controls.Add(this.lblPaciente);
            this.Name = "FrmExameAgendar";
            this.Text = "FrmExameAgendar";
            this.Load += new System.EventHandler(this.FrmExameAgendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBConsultorioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Label lblExame;
        private System.Windows.Forms.ComboBox comboBox1;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource tBConsultorioBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ConsultorioTableAdapter tB_ConsultorioTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}