using Microsoft.VisualBasic.ApplicationServices;
using Surf_Cafe.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surf_Cafe.Forms
{
    public partial class EmployeesManagementUserControl : UserControl
    {
        public EmployeesManagementUserControl()
        {
            InitializeComponent();
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            flpEmployees.Controls.Clear();

            using var db = new DBContext();
            var employees = db.Users.ToList();

            foreach (var employee in employees)
            {
                UserCard card = new UserCard();
                card.UserID = employee.UserID;
                card.Username = employee.Username;
                card.Role = employee.Role.ToString();
                card.UserClicked += (id) => OnUserClicked(id);
                flpEmployees.Controls.Add(card);
            }
        }

        private void OnUserClicked(int userID)
        {
            EditEmployeeForm form = new EditEmployeeForm(userID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();

            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e) 
        {
            AddEmployeeForm form = new AddEmployeeForm();

            form.EmployeeAdded += () =>
            {
                LoadEmployees();
            };

            form.ShowDialog();
        }
    }
}
