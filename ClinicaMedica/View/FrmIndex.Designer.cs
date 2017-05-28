namespace ClinicaMedica.View
{
    partial class FrmIndex
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoEmEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exameEmConsultóriroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.inserirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultórioToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.exameToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // consultórioToolStripMenuItem
            // 
            this.consultórioToolStripMenuItem.Name = "consultórioToolStripMenuItem";
            this.consultórioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultórioToolStripMenuItem.Text = "Consultório";
            this.consultórioToolStripMenuItem.Click += new System.EventHandler(this.consultórioToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultórioToolStripMenuItem1});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // consultórioToolStripMenuItem1
            // 
            this.consultórioToolStripMenuItem1.Name = "consultórioToolStripMenuItem1";
            this.consultórioToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.consultórioToolStripMenuItem1.Text = "Consultório";
            this.consultórioToolStripMenuItem1.Click += new System.EventHandler(this.consultórioToolStripMenuItem1_Click);
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoEmEstoqueToolStripMenuItem,
            this.exameEmConsultóriroToolStripMenuItem});
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.inserirToolStripMenuItem.Text = "Inserir";
            // 
            // produtoEmEstoqueToolStripMenuItem
            // 
            this.produtoEmEstoqueToolStripMenuItem.Name = "produtoEmEstoqueToolStripMenuItem";
            this.produtoEmEstoqueToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.produtoEmEstoqueToolStripMenuItem.Text = "Produto em Estoque";
            this.produtoEmEstoqueToolStripMenuItem.Click += new System.EventHandler(this.produtoEmEstoqueToolStripMenuItem_Click);
            // 
            // exameToolStripMenuItem
            // 
            this.exameToolStripMenuItem.Name = "exameToolStripMenuItem";
            this.exameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exameToolStripMenuItem.Text = "Exame";
            this.exameToolStripMenuItem.Click += new System.EventHandler(this.exameToolStripMenuItem_Click);
            // 
            // exameEmConsultóriroToolStripMenuItem
            // 
            this.exameEmConsultóriroToolStripMenuItem.Name = "exameEmConsultóriroToolStripMenuItem";
            this.exameEmConsultóriroToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exameEmConsultóriroToolStripMenuItem.Text = "Exame em Consultóriro";
            this.exameEmConsultóriroToolStripMenuItem.Click += new System.EventHandler(this.exameEmConsultóriroToolStripMenuItem_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmIndex";
            this.Text = "Sistema de Consultórios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultórioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoEmEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exameEmConsultóriroToolStripMenuItem;
    }
}