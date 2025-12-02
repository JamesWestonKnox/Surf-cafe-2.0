using Surf_Cafe.Models;

// -------------------------------------------------------------------------------START OF FILE--------------------------------------------------------------------------------- //

namespace Surf_Cafe.Forms
{
    // -------------------Employee Dashboard Form----------------------- \\
    public partial class EmployeeDashboardForm : Form
    {
        private User _loggedInUser;
        private CategoriesUserControl categoriesUC;
        private OrdersUserControl ordersUC;
        private int _selectedCategoryID;
        private string _selectedCategoryName;
        private InventoryUserControl inventoryUC;
        private OrderDetailsUserControl orderDetailsUC;

        // -------------------Constructor----------------------- \\
        public EmployeeDashboardForm(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
        }

        // -------------------Hide Buttons Logic----------------------- \\
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

        // -------------------Load User Control Logic----------------------- \\
        private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        // -------------------Collapse Button Logix----------------------- \\

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
                btnMenu.Text = "Inventory";
                btnLogout.Text = "Logout";
            }
            else
            {
                // Collapse
                pnlSidebar.Width = collapsedWidth;
                btnCollapse.Text = "";
                btnOrders.Text = "";
                btnMenu.Text = "";
                btnLogout.Text = "";
            }
        }

        // -------------------Menu Button Logic----------------------- \\

        private void btnMenu_Click(object sender, EventArgs e)
        {
            HideButtons();
            lblSubHeading.Text = "Inventory Management";
            inventoryUC = new InventoryUserControl();
            LoadUserControl(inventoryUC);
            btnGenerateReport.Visible = true;
            btnSaveChanges.Visible = true;
            btnAddStock.Visible = true;


        }

        // -------------------Logo Picture Box Logix----------------------- \\

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        // -------------------Form Load Event----------------------- \\
        private void EmployeeDashboardForm_Load(object sender, EventArgs e)
        {

        }
        // -------------------Main and Sub Heading Label Click Events----------------------- \\

        private void lblMainHeading_Click(object sender, EventArgs e)
        {

        }
        private void lblSubHeading_Click(object sender, EventArgs e)
        {

        }
        // -------------------Panel Paint Events----------------------- \\
        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        //  -------------------Add Item Button Logic----------------------- \\

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


        // -------------------Orders Button Logic----------------------- \\

        private void btnOrders_Click(object sender, EventArgs e)
        {
            HideButtons();
            lblSubHeading.Text = "Orders";
            ordersUC = new OrdersUserControl();

            ordersUC.OrderSelected += (order) =>
            {
                orderDetailsUC = new OrderDetailsUserControl(order);
                lblSubHeading.Text = $"Order - {order.OrderName}";
                LoadUserControl(orderDetailsUC);
                btnAddOrder.Visible = false;
                btnBack.Visible = true;
                btnBack2.Visible = true;
            };


            LoadUserControl(ordersUC);
            btnAddOrder.Visible = true;


        }

        //  -------------------Save Changes Button Click Event----------------------- \\

        // Github Co-Pilot helped me fix this error ('object' does not contain a definition for 'SaveChanges' and no accessible extension method 'SaveChanges' accepting a first argument of type 'object' could be found (are you missing a using directive or an assembly reference?))

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (inventoryUC is InventoryUserControl invUC)
            {
                invUC.SaveChanges();
            }
        }

        //  -------------------Add order Button Click Event----------------------- \\
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

        //  -------------------Add Category Button Click Event----------------------- \\
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm form = new AddCategoryForm();
            form.CategoryAdded += () => categoriesUC.LoadCategories();
            form.ShowDialog();
        }

        // -------------------Logout Button Click Event----------------------- \\
        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInUser = null;
            this.Close();
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



        private void btnBack_Click_1(object sender, EventArgs e)
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
                btnBack2.Visible = true;
            };

            LoadUserControl(ordersUC);
            btnAddOrder.Visible = true;
            btnBack2.Visible = false;

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            orderDetailsUC.LoadMenu();
        }
    }
}

// -------------------------------------------------------------------------------END OF FILE--------------------------------------------------------------------------------- //
