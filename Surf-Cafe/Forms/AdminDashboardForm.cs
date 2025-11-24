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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to load new user controls into our content panel in our dashboard
        /// </summary>
        /// <param name="uc"></param>
        private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }


        private void btnCollapse_Click(object sender, EventArgs e)
        {

        }

        private void lblMainHeading_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSubHeading_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            lblSubHeading.Text = "Orders";
            OrdersUserControl orders = new OrdersUserControl();
            LoadUserControl(orders);


        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            lblSubHeading.Text = "Inventory Management";
            InventoryUserControl inventory = new InventoryUserControl();
            LoadUserControl(inventory);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            lblSubHeading.Text = "Categories";
            CategoriesUserControl categories = new CategoriesUserControl();
            LoadUserControl(categories);

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            lblSubHeading.Text = "Reports";
            ReportsUserControl reports = new ReportsUserControl();
            LoadUserControl(reports);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            lblSubHeading.Text = "Employee Management";
            EmployeesManagementUserControl employees = new EmployeesManagementUserControl();
            LoadUserControl(employees);
        }
    }
}
