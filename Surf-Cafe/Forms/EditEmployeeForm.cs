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

        //Prepopulating textboxes and loading the EditEmployee popup form
        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            using (var db = new DBContext())
            {
                //Retrieving the data for that specific user
                _user = db.Users.FirstOrDefault(u => u.UserID == _userID);

                //validation if user is not found in database
                if (_user == null)
                {
                    MessageBox.Show("Employee not found");
                    Close();
                    return;
                }

                //Setting the textboxes to the employee details so the admin can change them
                lblEmployee.Text = _user.Username;
                txtUsername.Text = _user.Username;
                cmbRole.DataSource = Enum.GetValues(typeof(UserRole));
                cmbRole.SelectedIndex = Array.IndexOf(Enum.GetValues(typeof(UserRole)), _user.Role);
                txtPassword.PlaceholderText = "Leave blank to keep original password";

            }

        }

        /// <summary>
        /// Saves any changes made to the employee details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Opening database connection
            using (var db = new DBContext())
            {
                //Finding the specific user the admin is editing
                var user = db.Users.FirstOrDefault(_user => _user.UserID == _userID);
                if (user == null)
                {
                    return;
                }
                
                //Retrieving the input from the textboxes and combo box
                user.Username = txtUsername.Text.Trim();
                user.Role = (UserRole)cmbRole.SelectedItem;

                //Checking if the password is left blank... if so then it will keep the same password
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    user.PasscodeHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);
                }

                //Saving changes to the database
                db.SaveChanges();

                MessageBox.Show("Employee details updated sucessfully");
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Deletes employee from the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Prompting the user if they are sure they want to delete the employee
            var confirm = MessageBox.Show("Are you sure you want to delete this employee", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            //Opening database connection
            using (var db = new DBContext())
            {
                //Finding that specific user
                var user = db.Users.FirstOrDefault(u => u.UserID == _userID);
                if (user == null)
                {
                    return;
                }
                //Removing the user from the database and saving it
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
