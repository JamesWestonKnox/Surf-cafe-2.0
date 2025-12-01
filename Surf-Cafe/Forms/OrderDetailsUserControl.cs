using Microsoft.EntityFrameworkCore;
using Surf_Cafe.Database;
using Surf_Cafe.Models;

namespace Surf_Cafe.Forms
{
    public partial class OrderDetailsUserControl : UserControl
    {
        private Order _order;
        public OrderDetailsUserControl(Order order)
        {
            InitializeComponent();
            _order = order;
            PopulateDataGridView();
            LoadMenu();
        }

        /// <summary>
        /// Method to pull up existing menu categories on the order details page
        /// </summary>
        private void LoadMenu()
        {
            var categoriesUC = new CategoriesUserControl();
            categoriesUC.Dock = DockStyle.Fill;

            // Call method to load products when a category card is clicked
            categoriesUC.CategorySelected += (categoryID, categoryName) =>
            {
                LoadProducts(categoryID, categoryName);
            };

            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel1.Controls.Add(categoriesUC);
        }

        /// <summary>
        /// Method to load all products withing a category
        /// </summary>
        /// <param name="categoryID"></param>
        /// <param name="categoryName"></param>
        private void LoadProducts(int categoryID, string categoryName)
        {
            var productsUC = new ProductsInCategoryUserControl(categoryID, categoryName, AddProductToOrder);
            productsUC.Dock = DockStyle.Fill;

            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel1.Controls.Add(productsUC);
        }

        /// <summary>
        /// Method that adds selected product to and order, if product is already found it increases the quantity.
        /// </summary>
        /// <param name="productID"></param>
        private void AddProductToOrder(int productID)
        {
            using var db = new DBContext();

            var product = db.MenuItems.FirstOrDefault(p => p.MenuItemID == productID);
            var orderItem = db.OrderItems.FirstOrDefault(i => i.OrderID == _order.OrderID && i.MenuItemID == productID);

            // If product and orderitem are found increase quantity by 1 and calculate subtotal
            if (product != null && orderItem != null)
            {
                orderItem.Quantity += 1;
                orderItem.ItemSubTotal = orderItem.Quantity * product.Price;
            }
            // if no order item found, then adds new item to order table in database
            else if (product != null)
            {
                orderItem = new OrderItem
                {
                    OrderID = _order.OrderID,
                    MenuItemID = product.MenuItemID,
                    Quantity = 1,
                    ItemSubTotal = product.Price
                };
                db.OrderItems.Add(orderItem);
            }
            // returns if product is null
            else if (product == null)
            {
                return;
            }

            db.SaveChanges();
            // calls method to populate the grid to display order items
            PopulateDataGridView();

        }

        /// <summary>
        /// Method that fetches all order items and displays them in the datagridview
        /// </summary>
        private void PopulateDataGridView()
        {
            dataGridView1.Rows.Clear();
            using var db = new DBContext();
            // fetches all order items in order table
            var orderItems = db.OrderItems.Where(oi => oi.OrderID == _order.OrderID).Include(oi => oi.MenuItem).ToList();

            // adds new row for each order item
            foreach (var item in orderItems)
            {
                dataGridView1.Rows.Add(item.MenuItem.Name, item.Quantity, item.ItemSubTotal);
            }
        }
        private void OrderDetailsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void flpOrderSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnLoyalty_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
