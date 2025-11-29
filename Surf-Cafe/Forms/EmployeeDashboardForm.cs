using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EmployeeDashboardForm : Form
    {
        private User _loggedInUser;
        private CategoriesUserControl categoriesUC;
        private InventoryUserControl inventoryUC;
        private object pnlActions;

        public EmployeeDashboardForm()
        {
            InitializeComponent();
        }

        private void HideButtons()
        {
            /*
            foreach (Control ctrl in pnlActions.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Visible = false;
                }
            }
            */
        }

        private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            int collapsedWidth = 50;
            int expandedWidth = 200;

            if (pnlSidebar.Width == collapsedWidth)
            {
                // Expand
                pnlSidebar.Width = expandedWidth;
                btnCollapse.Text = "Collapse";
            }
            else
            {
                // Collapse
                pnlSidebar.Width = collapsedWidth;
                btnCollapse.Text = "Open";
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            /*
             HideButtons();
            lblSubHeading.Text = "Categories";
            categoriesUC = new CategoriesUserControl();
            categoriesUC.CategorySelected += (categoryID, categoryName) =>
            {
                var productUC = new ProductsInCategoryUserControl(categoryID, categoryName);
                lblSubHeading.Text = $"Category - {categoryName}";
                LoadUserControl(productUC);
            };

            LoadUserControl(categoriesUC);
            btnAddCategory.Visible = true;
            */
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            /*
            HideButtons();
            lblSubHeading.Text = "Inventory Management";
            inventoryUC = new InventoryUserControl();
            LoadUserControl(inventoryUC);
            btnGenerateReport.Visible = true;
            btnSaveChanges.Visible = true;
            btnAddStock.Visible = true;
            */

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void lblMainHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            /*
            HideButtons();
            lblSubHeading.Text = "Orders";
            OrdersUserControl orders = new OrdersUserControl();
            LoadUserControl(orders);
            btnAddOrder.Visible = true;
            */
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            /* NewOrderForm form = new NewOrderForm(_loggedInUser.UserID);
             if (form.ShowDialog() == DialogResult.OK)
             {
                 if (pnlContent.Controls[0] is OrdersUserControl ordersControl)
                 {
                     ordersControl.AddOrderCard(form.newOrder);
                 }
             } */
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInUser = null;
            this.Close();
        }
    }
}
