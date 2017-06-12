namespace ClinicaMedica.View
{
    partial class FrmFuncaoConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncaoConsultar));
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.dgvFuncoes = new System.Windows.Forms.DataGridView();
            this.IdFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBFuncaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.TB_FuncaoTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_FuncaoTableAdapter();
            this.ttpFuncao = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBFuncaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaMedicaBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(13, 58);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisa.TabIndex = 1;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(82, 55);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(440, 20);
            this.txbPesquisa.TabIndex = 2;
            this.ttpFuncao.SetToolTip(this.txbPesquisa, "Insira o nome da função para pesquisar.");
            this.txbPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPesquisa_KeyUp);
            // 
            // dgvFuncoes
            // 
            this.dgvFuncoes.AllowUserToAddRows = false;
            this.dgvFuncoes.AllowUserToDeleteRows = false;
            this.dgvFuncoes.AutoGenerateColumns = false;
            this.dgvFuncoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFuncao,
            this.Nome,
            this.Descricao});
            this.dgvFuncoes.DataSource = this.TBFuncaoBindingSource;
            this.dgvFuncoes.Location = new System.Drawing.Point(12, 95);
            this.dgvFuncoes.MultiSelect = false;
            this.dgvFuncoes.Name = "dgvFuncoes";
            this.dgvFuncoes.ReadOnly = true;
            this.dgvFuncoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncoes.Size = new System.Drawing.Size(510, 250);
            this.dgvFuncoes.TabIndex = 3;
            this.ttpFuncao.SetToolTip(this.dgvFuncoes, "Dê um duplo clique na função que deseja alterar ou excluir.");
            this.dgvFuncoes.DoubleClick += new System.EventHandler(this.dgvFuncoes_DoubleClick);
            // 
            // IdFuncao
            // 
            this.IdFuncao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdFuncao.DataPropertyName = "IdFuncao";
            this.IdFuncao.HeaderText = "Código";
            this.IdFuncao.Name = "IdFuncao";
            this.IdFuncao.ReadOnly = true;
            this.IdFuncao.Width = 65;
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
            // TBFuncaoBindingSource
            // 
            this.TBFuncaoBindingSource.DataMember = "TB_Funcao";
            this.TBFuncaoBindingSource.DataSource = this.ClinicaMedicaBDDataSet;
            // 
            // ClinicaMedicaBDDataSet
            // 
            this.ClinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.ClinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(510, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consulta de Funções";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_FuncaoTableAdapter
            // 
            this.TB_FuncaoTableAdapter.ClearBeforeFill = true;
            // 
            // ttpFuncao
            // 
            this.ttpFuncao.AutoPopDelay = 5000;
            this.ttpFuncao.InitialDelay = 30;
            this.ttpFuncao.IsBalloon = true;
            this.ttpFuncao.ReshowDelay = 30;
            // 
            // FrmFuncaoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 366);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.dgvFuncoes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFuncaoConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Funções";
            this.Activated += new System.EventHandler(this.FrmFuncaoConsultar_Activated);
            this.Load += new System.EventHandler(this.FrmFuncaoConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBFuncaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaMedicaBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.DataGridView dgvFuncoes;
        private System.Windows.Forms.Label lblTitulo;
        private ClinicaMedicaBDDataSet ClinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource TBFuncaoBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_FuncaoTableAdapter TB_FuncaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.ToolTip ttpFuncao;
    }
}