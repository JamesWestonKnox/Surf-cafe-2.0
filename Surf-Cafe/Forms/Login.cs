using Surf_Cafe.Database;
using Surf_Cafe.Forms;
using Surf_Cafe.Models;

namespace Surf_Cafe
{

    //-------------------------------------------------------- START OF FILE --------------------------------------------------------//

    public partial class Login : Form
    {

        //------------------------ Constructor  -----------------------//
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
            this.Close();
        }

        //------------------------ Employee Login Button Logic  -----------------------//
        private void button2_Click(object sender, EventArgs e)
        {
            base.Hide();
            EmployeeLogin employeeLoginForm = new EmployeeLogin();
            employeeLoginForm.ShowDialog();
            base.Show();
        }

        //------------------------ Form Load logic  -----------------------//
        private void Login_Load(object sender, EventArgs e)
        {
            using (var db = new DBContext())
            {
                db.Database.EnsureCreated();

                if (!db.Users.Any())
                {
                    var admin = new User
                    {
                        Username = "Admin",
                        PasscodeHash = Authentication.HashPassword("admin25!"),
                        Role = UserRole.Admin,
                        DateRegistered = DateTime.Now
                    };

                    var emp = new User
                    {
                        Username = "Employee",
                        PasscodeHash = Authentication.HashPassword("emp25!"),
                        Role = UserRole.Staff,
                        DateRegistered = DateTime.Now
                    };

                    db.Users.Add(admin);
                    db.Users.Add(emp);
                    db.SaveChanges();
                }
            }
        }

        //------------------------ Unused Event Handlers  -----------------------//
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

    }
}

//-------------------------------------------------------- END OF FILE --------------------------------------------------------//