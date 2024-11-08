namespace POO_2
{
    partial class Tela_Principal
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
            this.Menu_Principal = new System.Windows.Forms.MenuStrip();
            this.Menu_Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Relatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Principal
            // 
            this.Menu_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Cadastro,
            this.Menu_Consulta,
            this.Menu_Relatorio});
            this.Menu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_Principal.Name = "Menu_Principal";
            this.Menu_Principal.Size = new System.Drawing.Size(782, 30);
            this.Menu_Principal.TabIndex = 1;
            this.Menu_Principal.Text = "Menu_Principal";
            this.Menu_Principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Menu_Cadastro
            // 
            this.Menu_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.profutosToolStripMenuItem});
            this.Menu_Cadastro.Name = "Menu_Cadastro";
            this.Menu_Cadastro.Size = new System.Drawing.Size(82, 26);
            this.Menu_Cadastro.Text = "Cadastro";
            // 
            // Menu_Consulta
            // 
            this.Menu_Consulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem});
            this.Menu_Consulta.Name = "Menu_Consulta";
            this.Menu_Consulta.Size = new System.Drawing.Size(80, 26);
            this.Menu_Consulta.Text = "Consulta";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // profutosToolStripMenuItem
            // 
            this.profutosToolStripMenuItem.Name = "profutosToolStripMenuItem";
            this.profutosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.profutosToolStripMenuItem.Text = "Profutos";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // Menu_Relatorio
            // 
            this.Menu_Relatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.Menu_Relatorio.Name = "Menu_Relatorio";
            this.Menu_Relatorio.Size = new System.Drawing.Size(84, 26);
            this.Menu_Relatorio.Text = "Relatorio";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.Menu_Principal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu_Principal;
            this.Name = "Tela_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Tela_Principal";
            this.Load += new System.EventHandler(this.Tela_Principal_Load);
            this.Menu_Principal.ResumeLayout(false);
            this.Menu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Principal;
        private System.Windows.Forms.ToolStripMenuItem Menu_Cadastro;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Consulta;
        private System.Windows.Forms.ToolStripMenuItem profutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Relatorio;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
    }
}