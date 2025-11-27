using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Surf_Cafe.Models;

//-------------------------------------------------------- START OF FILE --------------------------------------------------------//

namespace Surf_Cafe.Forms
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        //------------------------ Login Button Logic  -----------------------//

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User authenticatedUser = Authentication.AuthenticationUser(username, password, UserRole.Staff);
            if (authenticatedUser != null)
            {
                MessageBox.Show($"Login successful, {authenticatedUser.Username}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                EmployeeDashboardForm employeeDashboard = new EmployeeDashboardForm();
                employeeDashboard.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------ Unused Event Handlers  -----------------------//

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        //------------------------ Cancel Button Logic  -----------------------//

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
