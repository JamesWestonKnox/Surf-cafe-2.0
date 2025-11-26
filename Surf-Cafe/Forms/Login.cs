using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Surf_Cafe.Forms;

namespace Surf_Cafe
{

    public partial class Login : Form
    {

        public Login()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Hide();
            AdminLogin adminLoginForm = new AdminLogin();
            adminLoginForm.ShowDialog();
            base.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            base.Hide();
            EmployeeLogin employeeLoginForm = new EmployeeLogin();
            employeeLoginForm.ShowDialog();
            base.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }


       
    }
}
