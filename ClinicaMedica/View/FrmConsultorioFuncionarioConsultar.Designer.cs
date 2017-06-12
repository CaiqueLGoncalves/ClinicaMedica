namespace ClinicaMedica.View
{
    partial class FrmConsultorioFuncionarioConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultorioFuncionarioConsultar));
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.chkFuncionariosInativos = new System.Windows.Forms.CheckBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.rbtFuncionario = new System.Windows.Forms.RadioButton();
            this.rbtConsultorio = new System.Windows.Forms.RadioButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dgvQuadroFuncionarios = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.btnInativar = new System.Windows.Forms.Button();
            this.gpbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuadroFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.chkFuncionariosInativos);
            this.gpbFiltros.Controls.Add(this.lblFiltros);
            this.gpbFiltros.Controls.Add(this.rbtFuncionario);
            this.gpbFiltros.Controls.Add(this.rbtConsultorio);
            this.gpbFiltros.Location = new System.Drawing.Point(12, 87);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(760, 50);
            this.gpbFiltros.TabIndex = 3;
            this.gpbFiltros.TabStop = false;
            // 
            // chkFuncionariosInativos
            // 
            this.chkFuncionariosInativos.AutoSize = true;
            this.chkFuncionariosInativos.Location = new System.Drawing.Point(600, 20);
            this.chkFuncionariosInativos.Name = "chkFuncionariosInativos";
            this.chkFuncionariosInativos.Size = new System.Drawing.Size(154, 17);
            this.chkFuncionariosInativos.TabIndex = 3;
            this.chkFuncionariosInativos.Text = "Exibir Funcionários Inativos";
            this.chkFuncionariosInativos.UseVisualStyleBackColor = true;
            this.chkFuncionariosInativos.CheckedChanged += new System.EventHandler(this.chkFuncionariosInativos_CheckedChanged);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(6, 21);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(37, 13);
            this.lblFiltros.TabIndex = 0;
            this.lblFiltros.Text = "Filtros:";
            // 
            // rbtFuncionario
            // 
            this.rbtFuncionario.AutoSize = true;
            this.rbtFuncionario.Location = new System.Drawing.Point(153, 19);
            this.rbtFuncionario.Name = "rbtFuncionario";
            this.rbtFuncionario.Size = new System.Drawing.Size(80, 17);
            this.rbtFuncionario.TabIndex = 2;
            this.rbtFuncionario.Text = "Funcionário";
            this.rbtFuncionario.UseVisualStyleBackColor = true;
            this.rbtFuncionario.CheckedChanged += new System.EventHandler(this.rbtFuncionario_CheckedChanged);
            // 
            // rbtConsultorio
            // 
            this.rbtConsultorio.AutoSize = true;
            this.rbtConsultorio.Checked = true;
            this.rbtConsultorio.Location = new System.Drawing.Point(70, 19);
            this.rbtConsultorio.Name = "rbtConsultorio";
            this.rbtConsultorio.Size = new System.Drawing.Size(77, 17);
            this.rbtConsultorio.TabIndex = 1;
            this.rbtConsultorio.TabStop = true;
            this.rbtConsultorio.Text = "Consultório";
            this.rbtConsultorio.UseVisualStyleBackColor = true;
            this.rbtConsultorio.CheckedChanged += new System.EventHandler(this.rbtConsultorio_CheckedChanged);
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
            // dgvQuadroFuncionarios
            // 
            this.dgvQuadroFuncionarios.AllowUserToAddRows = false;
            this.dgvQuadroFuncionarios.AllowUserToDeleteRows = false;
            this.dgvQuadroFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQuadroFuncionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuadroFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuadroFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuadroFuncionarios.Location = new System.Drawing.Point(12, 154);
            this.dgvQuadroFuncionarios.MultiSelect = false;
            this.dgvQuadroFuncionarios.Name = "dgvQuadroFuncionarios";
            this.dgvQuadroFuncionarios.ReadOnly = true;
            this.dgvQuadroFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuadroFuncionarios.Size = new System.Drawing.Size(630, 385);
            this.dgvQuadroFuncionarios.TabIndex = 4;
            this.dgvQuadroFuncionarios.Click += new System.EventHandler(this.dgvQuadroFuncionarios_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Quadro de Funcionários";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(82, 55);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(690, 20);
            this.txbPesquisa.TabIndex = 2;
            this.txbPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPesquisa_KeyUp);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Enabled = false;
            this.btnAtivar.Location = new System.Drawing.Point(672, 154);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(100, 30);
            this.btnAtivar.TabIndex = 5;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // btnInativar
            // 
            this.btnInativar.Location = new System.Drawing.Point(672, 200);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(100, 30);
            this.btnInativar.TabIndex = 6;
            this.btnInativar.Text = "Inativar";
            this.btnInativar.UseVisualStyleBackColor = true;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // FrmConsultorioFuncionarioConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnInativar);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.gpbFiltros);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.dgvQuadroFuncionarios);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultorioFuncionarioConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadro de Funcionários: Consulta";
            this.Activated += new System.EventHandler(this.FrmConsultorioFuncionarioConsultar_Activated);
            this.Load += new System.EventHandler(this.FrmConsultorioFuncionarioConsultar_Load);
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuadroFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbFiltros;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.RadioButton rbtFuncionario;
        private System.Windows.Forms.RadioButton rbtConsultorio;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dgvQuadroFuncionarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.CheckBox chkFuncionariosInativos;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Button btnInativar;
    }
}