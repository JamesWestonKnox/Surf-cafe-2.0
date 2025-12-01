using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Surf_Cafe.Models;
using Surf_Cafe.Forms;
using Surf_Cafe.Database;

namespace Surf_Cafe.Forms
{
    public partial class EditEmployeeForm : Form
    {
        private readonly int _userID;
        private User _user;

        public EditEmployeeForm(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            using (var db = new DBContext())
            {
                _user = db.Users.FirstOrDefault(u => u.UserID == _userID);

                if (_user == null)
                {
                    MessageBox.Show("Employee not found");
                    Close();
                    return;
                }

                lblEmployee.Text = _user.Username;
                txtUsername.Text = _user.Username;

                cmbRole.DataSource = Enum.GetValues(typeof(UserRole));
                cmbRole.SelectedIndex = Array.IndexOf(Enum.GetValues(typeof(UserRole)), _user.Role);

                txtPassword.PlaceholderText = "Leave blank to keep original password";

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new DBContext())
            {
                var user = db.Users.FirstOrDefault(_user => _user.UserID == _userID);
                if (user == null)
                {
                    return;
                }

                user.Username = txtUsername.Text.Trim();
                user.Role = (UserRole)cmbRole.SelectedItem;

                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    user.PasscodeHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                }

                db.SaveChanges();

                MessageBox.Show("Employee details updated sucessfully");
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this employee", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            using (var db = new DBContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserID == _userID);
                if (user == null)
                {
                    return;
                }
                db.Users.Remove(user);
                db.SaveChanges();
            }

            MessageBox.Show("Employee Successfully deleted");
            this.DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
