namespace ClinicaMedica.View
{
    partial class FrmProdutoCadastrar
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.tBFuncaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_FuncaoTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_FuncaoTableAdapter();
            this.tBProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_ProdutoTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_ProdutoTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tBProdutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFuncaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBProdutoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(71, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(71, 99);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(71, 126);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(185, 64);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 3;
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(185, 99);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(100, 20);
            this.txbDescricao.TabIndex = 4;
            // 
            // clinicaMedicaBDDataSet
            // 
            this.clinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.clinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBFuncaoBindingSource
            // 
            this.tBFuncaoBindingSource.DataMember = "TB_Funcao";
            this.tBFuncaoBindingSource.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // tB_FuncaoTableAdapter
            // 
            this.tB_FuncaoTableAdapter.ClearBeforeFill = true;
            // 
            // tBProdutoBindingSource
            // 
            this.tBProdutoBindingSource.DataMember = "TB_Produto";
            this.tBProdutoBindingSource.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // tB_ProdutoTableAdapter
            // 
            this.tB_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tBProdutoBindingSource1;
            this.comboBox1.DisplayMember = "Tipo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // tBProdutoBindingSource1
            // 
            this.tBProdutoBindingSource1.DataMember = "TB_Produto";
            this.tBProdutoBindingSource1.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(185, 191);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // FrmProdutoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 311);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmProdutoCadastrar";
            this.Text = "FrmProdutoCadastrar";
            this.Load += new System.EventHandler(this.FrmProdutoCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFuncaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBProdutoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbDescricao;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource tBFuncaoBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_FuncaoTableAdapter tB_FuncaoTableAdapter;
        private System.Windows.Forms.BindingSource tBProdutoBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_ProdutoTableAdapter tB_ProdutoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tBProdutoBindingSource1;
        private System.Windows.Forms.Button btnCadastrar;
    }
}