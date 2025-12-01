using Surf_Cafe.Models;
namespace Surf_Cafe.Forms
{
    public partial class AdminDashboardForm : Form
    {
        private User _loggedInUser;
        private CategoriesUserControl categoriesUC;
        private InventoryUserControl inventoryUC;
        private int _selectedCategoryID;
        private string _selectedCategoryName;
        private OrdersUserControl ordersUC;
        private EmployeesManagementUserControl employeesManagementUC;
        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
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
        public void HideButtons()
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
            ordersUC = new OrdersUserControl();

            ordersUC.OrderSelected += (order) =>
            {
                var orderDetailsUC = new OrderDetailsUserControl(order);
                lblSubHeading.Text = $"Order - {order.OrderName}";
                LoadUserControl(orderDetailsUC);
                btnAddOrder.Visible = false;
                btnBack.Visible = true;
            };


            LoadUserControl(ordersUC);
            btnAddOrder.Visible = true;


        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            HideButtons();
            lblSubHeading.Text = "Inventory Management";
            inventoryUC = new InventoryUserControl();
            LoadUserControl(inventoryUC);
            btnGenerateReport.Visible = true;
            btnSaveChanges.Visible = true;
            btnAddStock.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            HideButtons();
            lblSubHeading.Text = "Categories";
            categoriesUC = new CategoriesUserControl();


            categoriesUC.CategorySelected += (categoryID, categoryName) =>
            {
                _selectedCategoryID = categoryID;
                _selectedCategoryName = categoryName;

                var productUC = new ProductsInCategoryUserControl(categoryID, categoryName);
                lblSubHeading.Text = $"Category - {categoryName}";
                LoadUserControl(productUC);

                btnAddCategory.Visible = false;
                btnAddItem.Visible = true;
            };


            LoadUserControl(categoriesUC);
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
            employeesManagementUC = new EmployeesManagementUserControl();
            LoadUserControl(employeesManagementUC);
            btnAddEmployee.Visible = true;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.EmployeeAdded += () =>
            {
                employeesManagementUC?.LoadEmployees();
            };

            form.ShowDialog();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.StockAdded += () =>
            {
                inventoryUC?.LoadStockItems();
            };

            form.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm form = new AddCategoryForm();
            form.CategoryAdded += () => categoriesUC.LoadCategories();
            form.ShowDialog();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm form = new NewOrderForm(_loggedInUser.UserID);
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (inventoryUC != null)
            {
                inventoryUC.SaveChanges();
            }

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSubHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInUser = null;
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddMenuItemForm form = new AddMenuItemForm(_selectedCategoryID, _selectedCategoryName);

            form.ItemAdded += () =>
            {
                if (pnlContent.Controls.Count > 0 && pnlContent.Controls[0] is ProductsInCategoryUserControl productUC)
                {
                    productUC.LoadProducts();
                }
            };

            form.ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (inventoryUC != null)
            {
                inventoryUC.GenerateStockReport();
            }
            else
            {
                MessageBox.Show("Inventory failed to load");
            }
        }
    }
}
