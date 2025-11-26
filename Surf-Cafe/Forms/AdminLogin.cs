using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Surf_Cafe.Forms
{
    public partial class AdminLogin : Form
    {

        public AdminLogin()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            bool flag = username == "admin" && password == "password123";
            if (flag)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                base.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
 
    }
}