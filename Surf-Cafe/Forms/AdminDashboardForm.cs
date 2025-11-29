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

        /// <summary>
        /// Method to hide all action buttons in the action button panel
        /// </summary>
        private void HideButtons()
        {
            foreach (Control ctrl in pnlActions.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Visible = false;
                }
            }
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
            HideButtons();
            lblSubHeading.Text = "Orders";
            OrdersUserControl orders = new OrdersUserControl();
            LoadUserControl(orders);
            btnAddOrder.Visible = true;


        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            HideButtons();
            lblSubHeading.Text = "Inventory Management";
            InventoryUserControl inventory = new InventoryUserControl();
            LoadUserControl(inventory);
            btnGenerateReport.Visible = true;
            btnSaveChanges.Visible = true;
            btnAddStock.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            HideButtons();
            lblSubHeading.Text = "Categories";
            CategoriesUserControl categories = new CategoriesUserControl();
            LoadUserControl(categories);
            btnAddCategory.Visible = true;

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            HideButtons();
            lblSubHeading.Text = "Reports";
            ReportsUserControl reports = new ReportsUserControl();
            LoadUserControl(reports);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            HideButtons();
            lblSubHeading.Text = "Employee Management";
            EmployeesManagementUserControl employees = new EmployeesManagementUserControl();
            LoadUserControl(employees);
            btnAddEmployee.Visible = true;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.ShowDialog();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm form = new AddCategoryForm();
            form.ShowDialog();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm form = new NewOrderForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (pnlContent.Controls[0] is OrdersUserControl ordersControl)
                {
                    ordersControl.AddOrderCard(form.newOrder);
                }
            }
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSubHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
