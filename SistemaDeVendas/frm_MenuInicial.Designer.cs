namespace SistemaDeVendas
{
    partial class frm_MenuInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MenuInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_CadProdutos = new System.Windows.Forms.Button();
            this.btn_CadCategorias = new System.Windows.Forms.Button();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.relatóriosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // btn_CadProdutos
            // 
            this.btn_CadProdutos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CadProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CadProdutos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CadProdutos.FlatAppearance.BorderSize = 2;
            this.btn_CadProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CadProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CadProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_CadProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CadProdutos.Location = new System.Drawing.Point(52, 65);
            this.btn_CadProdutos.Name = "btn_CadProdutos";
            this.btn_CadProdutos.Size = new System.Drawing.Size(90, 89);
            this.btn_CadProdutos.TabIndex = 2;
            this.btn_CadProdutos.Text = "Cadastro de Produtos";
            this.btn_CadProdutos.UseVisualStyleBackColor = false;
            this.btn_CadProdutos.Click += new System.EventHandler(this.btn_CadProdutos_Click);
            // 
            // btn_CadCategorias
            // 
            this.btn_CadCategorias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CadCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CadCategorias.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CadCategorias.FlatAppearance.BorderSize = 2;
            this.btn_CadCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CadCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CadCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_CadCategorias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CadCategorias.Location = new System.Drawing.Point(197, 65);
            this.btn_CadCategorias.Name = "btn_CadCategorias";
            this.btn_CadCategorias.Size = new System.Drawing.Size(90, 89);
            this.btn_CadCategorias.TabIndex = 3;
            this.btn_CadCategorias.Text = "Cadastro de Categorias";
            this.btn_CadCategorias.UseVisualStyleBackColor = false;
            this.btn_CadCategorias.Click += new System.EventHandler(this.btn_CadCategorias_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.relatóriosToolStripMenuItem.Text = "Vendas";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem1
            // 
            this.relatóriosToolStripMenuItem1.Name = "relatóriosToolStripMenuItem1";
            this.relatóriosToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem1.Text = "Relatórios";
            // 
            // frm_MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(410, 233);
            this.Controls.Add(this.btn_CadCategorias);
            this.Controls.Add(this.btn_CadProdutos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_MenuInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_CadProdutos;
        private System.Windows.Forms.Button btn_CadCategorias;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem1;
    }
}

