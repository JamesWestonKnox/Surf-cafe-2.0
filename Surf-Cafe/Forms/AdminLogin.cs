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
            Application.Exit();
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
            User authenticatedUser = Authentication.AuthenticationUser(username, password);
            if (authenticatedUser != null && authenticatedUser.Role == UserRole.Admin)
            {

                AdminDashboardForm adminDashboardForm = new AdminDashboardForm(authenticatedUser);
                this.Hide();
                adminDashboardForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    this.txtUsername.Text = "";
                    this.txtPassword.Text = "";
                };
                adminDashboardForm.Show();

            }
            else if (authenticatedUser != null && authenticatedUser.Role == UserRole.Staff)
            {
                EmployeeDashboardForm employeeDashboardForm = new EmployeeDashboardForm(authenticatedUser);
                this.Hide();
                employeeDashboardForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    this.txtUsername.Text = "";
                    this.txtPassword.Text = "";
                };
                employeeDashboardForm.Show();

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

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//-------------------------------------------------------- END OF FILE --------------------------------------------------------//