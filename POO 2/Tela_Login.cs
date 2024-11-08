using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_2
{
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtBx_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtBx_login.Text == "admin" && txtBx_senha.Text == "admin")
            {
                txtBx_login.Text = "";
                txtBx_senha.Text = "";

                Form Tela_principal = new Tela_Principal();
                Tela_principal.ShowDialog();

                
                
            }
            
        }
    }
}
