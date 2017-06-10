namespace ClinicaMedica.View
{
    partial class FrmEspecialidadeConsultar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.IdEspecialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBEspecialidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.TB_EspecialidadeTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_EspecialidadeTableAdapter();
            this.ttpEspecialidade = new System.Windows.Forms.ToolTip(this.components);
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBEspecialidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaMedicaBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(510, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consulta de Especialidades";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.AutoGenerateColumns = false;
            this.dgvEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspecialidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEspecialidade,
            this.Nome,
            this.Descricao});
            this.dgvEspecialidades.DataSource = this.TBEspecialidadeBindingSource;
            this.dgvEspecialidades.Location = new System.Drawing.Point(12, 95);
            this.dgvEspecialidades.MultiSelect = false;
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(510, 250);
            this.dgvEspecialidades.TabIndex = 1;
            this.ttpEspecialidade.SetToolTip(this.dgvEspecialidades, "Dê um duplo clique na especialidade que deseja alterar ou excluir.");
            // 
            // IdEspecialidade
            // 
            this.IdEspecialidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdEspecialidade.DataPropertyName = "IdEspecialidade";
            this.IdEspecialidade.HeaderText = "Código";
            this.IdEspecialidade.Name = "IdEspecialidade";
            this.IdEspecialidade.ReadOnly = true;
            this.IdEspecialidade.Width = 65;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 60;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // TBEspecialidadeBindingSource
            // 
            this.TBEspecialidadeBindingSource.DataMember = "TB_Especialidade";
            this.TBEspecialidadeBindingSource.DataSource = this.ClinicaMedicaBDDataSet;
            this.TBEspecialidadeBindingSource.Filter = "";
            // 
            // ClinicaMedicaBDDataSet
            // 
            this.ClinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.ClinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TB_EspecialidadeTableAdapter
            // 
            this.TB_EspecialidadeTableAdapter.ClearBeforeFill = true;
            // 
            // ttpEspecialidade
            // 
            this.ttpEspecialidade.AutoPopDelay = 5000;
            this.ttpEspecialidade.InitialDelay = 500;
            this.ttpEspecialidade.IsBalloon = true;
            this.ttpEspecialidade.ReshowDelay = 100;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(82, 55);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(440, 20);
            this.txbPesquisa.TabIndex = 2;
            this.ttpEspecialidade.SetToolTip(this.txbPesquisa, "Insira o nome da especialidade para pesquisar.");
            this.txbPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPesquisa_KeyUp);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(13, 58);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisa.TabIndex = 3;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // FrmEspecialidadeConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 366);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.dgvEspecialidades);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEspecialidadeConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Especialidades";
            this.Activated += new System.EventHandler(this.FrmEspecialidadeConsultar_Activated);
            this.Load += new System.EventHandler(this.FrmEspecialidadeConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBEspecialidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaMedicaBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private ClinicaMedicaBDDataSet ClinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource TBEspecialidadeBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_EspecialidadeTableAdapter TB_EspecialidadeTableAdapter;
        private System.Windows.Forms.ToolTip ttpEspecialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEspecialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
    }
}