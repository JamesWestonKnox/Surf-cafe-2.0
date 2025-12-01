using Microsoft.EntityFrameworkCore;
using Surf_Cafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Surf_Cafe.Database;

namespace Surf_Cafe.Forms
{
    public partial class AddEmployeeForm : Form
    {
        public event Action EmployeeAdded;
        public AddEmployeeForm()
        {
            InitializeComponent();
            cmbRole.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username)) 
            {
                MessageBox.Show("Please enter username");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter password");
                return;
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please select role");
                return;
            }

            UserRole userRole;
            if (!Enum.TryParse(role, true, out userRole))
            {
                MessageBox.Show("Invalid role");
                return;
            }

            using (var db = new DBContext())
            {
                if (db.Users.Any(u => u.Username == username))
                {
                    MessageBox.Show("Username already exists");
                    return;
                }

                var newUser = new User
                {
                    Username = username,
                    Role = userRole,
                    PasscodeHash = BCrypt.Net.BCrypt.HashPassword(password)
                };

                db.Users.Add(newUser);
                db.SaveChanges();
            }

            EmployeeAdded?.Invoke();

            MessageBox.Show("Employee successfully created");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
