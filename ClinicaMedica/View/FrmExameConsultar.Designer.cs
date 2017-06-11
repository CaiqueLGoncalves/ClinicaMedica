namespace ClinicaMedica.View
{
    partial class FrmExameConsultar
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
            this.lblExame = new System.Windows.Forms.Label();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.dtgExame = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExame)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExame
            // 
            this.lblExame.AutoSize = true;
            this.lblExame.Location = new System.Drawing.Point(21, 46);
            this.lblExame.Name = "lblExame";
            this.lblExame.Size = new System.Drawing.Size(125, 13);
            this.lblExame.TabIndex = 0;
            this.lblExame.Text = "Digite o nome do Exame:";
            // 
            // txtExame
            // 
            this.txtExame.Location = new System.Drawing.Point(206, 46);
            this.txtExame.Name = "txtExame";
            this.txtExame.Size = new System.Drawing.Size(180, 20);
            this.txtExame.TabIndex = 1;
            this.txtExame.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExame_KeyUp);
            // 
            // dtgExame
            // 
            this.dtgExame.AllowUserToAddRows = false;
            this.dtgExame.AllowUserToDeleteRows = false;
            this.dtgExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExame.Location = new System.Drawing.Point(12, 86);
            this.dtgExame.Name = "dtgExame";
            this.dtgExame.ReadOnly = true;
            this.dtgExame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgExame.Size = new System.Drawing.Size(470, 150);
            this.dtgExame.TabIndex = 2;
            this.dtgExame.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgExame_CellContentClick);
            this.dtgExame.DoubleClick += new System.EventHandler(this.dtgExame_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta de Exames";
            // 
            // FrmExameConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgExame);
            this.Controls.Add(this.txtExame);
            this.Controls.Add(this.lblExame);
            this.Name = "FrmExameConsultar";
            this.Text = "FrmExameConsultar";
            this.Load += new System.EventHandler(this.FrmExameConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgExame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExame;
        private System.Windows.Forms.TextBox txtExame;
        private System.Windows.Forms.DataGridView dtgExame;
        private System.Windows.Forms.Label label1;
    }
}