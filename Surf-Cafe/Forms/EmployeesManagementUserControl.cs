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

        /// <summary>
        /// Loading all the employees onto the EmployeeManagementUserControl as cards
        /// </summary>
        public void LoadEmployees()
        {
            flpEmployees.Controls.Clear();

            //Opening database connection and retreiving all the employees as a list
            using var db = new DBContext();
            var employees = db.Users.ToList();

            //Creating a card for each employee in the list
            foreach (var employee in employees)
            {
                UserCard card = new UserCard();
                card.UserID = employee.UserID;
                card.Username = employee.Username;
                card.Role = employee.Role.ToString();
                card.UserClicked += (id) => OnUserClicked(id);

                //Adding the employee card to the flow layout panel
                flpEmployees.Controls.Add(card);
            }
        }

        /// <summary>
        /// Opens the Edit Employee form and loads the specific data relating to that employee card
        /// </summary>
        /// <param name="userID"></param>
        private void OnUserClicked(int userID)
        {
            EditEmployeeForm form = new EditEmployeeForm(userID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();

            }
        }

        /// <summary>
        /// Opens the addEmployee popup form and reloads the employees once the employee has been added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
