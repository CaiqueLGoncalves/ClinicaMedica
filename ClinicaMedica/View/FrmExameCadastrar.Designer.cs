namespace ClinicaMedica.View
{
    partial class FrmExameCadastrar
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRecomendacoes = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbRecomendacoes = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(58, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblRecomendacoes
            // 
            this.lblRecomendacoes.AutoSize = true;
            this.lblRecomendacoes.Location = new System.Drawing.Point(5, 51);
            this.lblRecomendacoes.Name = "lblRecomendacoes";
            this.lblRecomendacoes.Size = new System.Drawing.Size(91, 13);
            this.lblRecomendacoes.TabIndex = 1;
            this.lblRecomendacoes.Text = "Recomendações:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(102, 11);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(212, 20);
            this.txbNome.TabIndex = 2;
            // 
            // txbRecomendacoes
            // 
            this.txbRecomendacoes.Location = new System.Drawing.Point(102, 44);
            this.txbRecomendacoes.Multiline = true;
            this.txbRecomendacoes.Name = "txbRecomendacoes";
            this.txbRecomendacoes.Size = new System.Drawing.Size(212, 67);
            this.txbRecomendacoes.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(160, 126);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmExameCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 160);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbRecomendacoes);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblRecomendacoes);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmExameCadastrar";
            this.Text = "Cadastrar Exame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRecomendacoes;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbRecomendacoes;
        private System.Windows.Forms.Button btnCadastrar;
    }
}