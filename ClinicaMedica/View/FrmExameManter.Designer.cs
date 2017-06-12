namespace ClinicaMedica.View
{
    partial class FrmExameManter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExameManter));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txbRecomendacoes = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblRecomendacoes = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(117, 135);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txbRecomendacoes
            // 
            this.txbRecomendacoes.Location = new System.Drawing.Point(117, 52);
            this.txbRecomendacoes.Multiline = true;
            this.txbRecomendacoes.Name = "txbRecomendacoes";
            this.txbRecomendacoes.Size = new System.Drawing.Size(212, 67);
            this.txbRecomendacoes.TabIndex = 8;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(117, 19);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(212, 20);
            this.txbNome.TabIndex = 7;
            // 
            // lblRecomendacoes
            // 
            this.lblRecomendacoes.AutoSize = true;
            this.lblRecomendacoes.Location = new System.Drawing.Point(20, 59);
            this.lblRecomendacoes.Name = "lblRecomendacoes";
            this.lblRecomendacoes.Size = new System.Drawing.Size(91, 13);
            this.lblRecomendacoes.TabIndex = 6;
            this.lblRecomendacoes.Text = "Recomendações:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(73, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(237, 135);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmExameManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 176);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txbRecomendacoes);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblRecomendacoes);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmExameManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExameManter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmExameManter_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txbRecomendacoes;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblRecomendacoes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnExcluir;
    }
}