using System;
using System.Windows.Forms;
using Surf_Cafe.Models;

//-------------------------------------------------------- START OF FILE --------------------------------------------------------//

namespace Surf_Cafe.Forms
{
    public partial class AdminLogin : Form
    {

        public AdminLogin()
        {
            this.InitializeComponent();
        }

        //------------------------ Cancel Button Logic  -----------------------//

        private void button1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        //------------------------ Login Button Loigc  -----------------------//

        private void button2_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           User authenticatedUser = Authentication.AuthenticationUser(username, password, UserRole.Admin);
            if (authenticatedUser != null)
            {
                MessageBox.Show($"Login successful, {authenticatedUser.Username}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
                adminDashboardForm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------ Unused Event Handlers  -----------------------//

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

//-------------------------------------------------------- END OF FILE --------------------------------------------------------//