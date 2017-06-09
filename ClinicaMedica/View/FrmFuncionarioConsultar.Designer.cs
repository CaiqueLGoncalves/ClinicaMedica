﻿namespace ClinicaMedica.View
{
    partial class FrmFuncionarioConsultar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mskPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.rbtCPF = new System.Windows.Forms.RadioButton();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.rbtCodigo = new System.Windows.Forms.RadioButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // mskPesquisa
            // 
            this.mskPesquisa.Location = new System.Drawing.Point(82, 55);
            this.mskPesquisa.Name = "mskPesquisa";
            this.mskPesquisa.Size = new System.Drawing.Size(590, 20);
            this.mskPesquisa.TabIndex = 19;
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.lblFiltros);
            this.gpbFiltros.Controls.Add(this.rbtCPF);
            this.gpbFiltros.Controls.Add(this.rbtNome);
            this.gpbFiltros.Controls.Add(this.rbtCodigo);
            this.gpbFiltros.Location = new System.Drawing.Point(12, 87);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(660, 50);
            this.gpbFiltros.TabIndex = 18;
            this.gpbFiltros.TabStop = false;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(6, 21);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(37, 13);
            this.lblFiltros.TabIndex = 3;
            this.lblFiltros.Text = "Filtros:";
            // 
            // rbtCPF
            // 
            this.rbtCPF.AutoSize = true;
            this.rbtCPF.Location = new System.Drawing.Point(193, 19);
            this.rbtCPF.Name = "rbtCPF";
            this.rbtCPF.Size = new System.Drawing.Size(45, 17);
            this.rbtCPF.TabIndex = 2;
            this.rbtCPF.TabStop = true;
            this.rbtCPF.Text = "CPF";
            this.rbtCPF.UseVisualStyleBackColor = true;
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Location = new System.Drawing.Point(134, 19);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(53, 17);
            this.rbtNome.TabIndex = 1;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            // 
            // rbtCodigo
            // 
            this.rbtCodigo.AutoSize = true;
            this.rbtCodigo.Location = new System.Drawing.Point(70, 19);
            this.rbtCodigo.Name = "rbtCodigo";
            this.rbtCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbtCodigo.TabIndex = 0;
            this.rbtCodigo.TabStop = true;
            this.rbtCodigo.Text = "Código";
            this.rbtCodigo.UseVisualStyleBackColor = true;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(13, 58);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisa.TabIndex = 17;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFuncionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(12, 154);
            this.dgvFuncionarios.MultiSelect = false;
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(660, 295);
            this.dgvFuncionarios.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(660, 25);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Consulta de Funcionários";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFuncionarioConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 471);
            this.Controls.Add(this.mskPesquisa);
            this.Controls.Add(this.gpbFiltros);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFuncionarioConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Funcionários";
            this.Load += new System.EventHandler(this.FrmFuncionarioConsultar_Load);
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskPesquisa;
        private System.Windows.Forms.GroupBox gpbFiltros;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.RadioButton rbtCPF;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.RadioButton rbtCodigo;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Label lblTitulo;
    }
}