using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Surf_Cafe.Forms
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            bool flag = username == "employee" && password == "emp123";
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


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            base.Close();
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
