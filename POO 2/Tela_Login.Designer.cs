namespace POO_2
{
    partial class Tela_Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtBx_login = new System.Windows.Forms.TextBox();
            this.txtBx_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(325, 310);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(150, 22);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtBx_login
            // 
            this.txtBx_login.Location = new System.Drawing.Point(325, 162);
            this.txtBx_login.Name = "txtBx_login";
            this.txtBx_login.Size = new System.Drawing.Size(150, 22);
            this.txtBx_login.TabIndex = 2;
            this.txtBx_login.TextChanged += new System.EventHandler(this.txtBx_login_TextChanged);
            // 
            // txtBx_senha
            // 
            this.txtBx_senha.Location = new System.Drawing.Point(325, 231);
            this.txtBx_senha.Name = "txtBx_senha";
            this.txtBx_senha.Size = new System.Drawing.Size(150, 22);
            this.txtBx_senha.TabIndex = 3;
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(778, 449);
            this.Controls.Add(this.txtBx_senha);
            this.Controls.Add(this.txtBx_login);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Tela_Login";
            this.Text = "Tela_Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txtBx_login;
        private System.Windows.Forms.TextBox txtBx_senha;
    }
}

