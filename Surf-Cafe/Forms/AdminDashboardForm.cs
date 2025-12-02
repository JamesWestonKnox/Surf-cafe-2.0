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
                btnOrders.Text = "Orders";
                btnMenu.Text = "Menu";
                btnInventory.Text = "Inventory";
                btnEmployees.Text = "Employees";
                btnReports.Text = "Reports";
                btnLogout.Text = "Logout";
            }
            else
            {
                // Collapse
                pnlSidebar.Width = collapsedWidth;
                btnCollapse.Text = "";
                btnOrders.Text = "";
                btnMenu.Text = "";
                btnInventory.Text = "";
                btnEmployees.Text = "";
                btnReports.Text = "";
                btnLogout.Text = "";

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

        /// <summary>
        /// Opens the order user control inside the adminDashboard and loads all orders inside it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnOrders_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Opens the inventoryUserControl and loads all the stock items in a table inside the AdminDashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Opens the menuUserControl which displays the categories and menuItems inside the adminDashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Opens the reportUserControl inside the AdminDashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReports_Click(object sender, EventArgs e)
        {
            HideButtons();
            lblSubHeading.Text = "Reports";
            ReportsUserControl reports = new ReportsUserControl();
            LoadUserControl(reports);
        }

        /// <summary>
        /// Opens the EmployeeManagementUserControl inside the AdminDashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            HideButtons();
            lblSubHeading.Text = "Employee Management";
            employeesManagementUC = new EmployeesManagementUserControl();
            LoadUserControl(employeesManagementUC);
            btnAddEmployee.Visible = true;
        }

        /// <summary>
        /// Opens the addEmployee popup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.EmployeeAdded += () =>
            {
                employeesManagementUC?.LoadEmployees();
            };

            form.ShowDialog();
        }

        /// <summary>
        /// Opens the AddStock popup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.StockAdded += () =>
            {
                inventoryUC?.LoadStockItems();
            };

            form.ShowDialog();
        }

        /// <summary>
        /// Opens the AddCategory popup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm form = new AddCategoryForm();
            form.CategoryAdded += () => categoriesUC.LoadCategories();
            form.ShowDialog();
        }

        /// <summary>
        /// Opens up the NewOrder popup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Saves changes made to the start and end of day quantities within the inventory table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Logs the current user out and ends the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInUser = null;
            this.Close();
        }

        /// <summary>
        /// Opens up the AddMenuItem popup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Generates a report based on the stock inside the stock table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
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
    }
}
