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
            GetOrderTotals();
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
            // Recalculate totals
            GetOrderTotals();
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

        /// <summary>
        /// On click method for Increase, Decrease and delete buttons for order items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // prevents index out of range errors from header clicks
            if (e.RowIndex < 0) return;

            // fetches column and product names
            var columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            string productName = dataGridView1.Rows[e.RowIndex].Cells["Product"].Value.ToString();

            using var db = new DBContext();

            // fetches product and order item.
            var product = db.MenuItems.FirstOrDefault(p => p.Name == productName);
            var orderItem = db.OrderItems.FirstOrDefault(i => i.OrderID == _order.OrderID && i.MenuItemID == product.MenuItemID);

            // ensures product and order item are not null
            if (product != null && orderItem != null)
            {
                // if column is increase, quantity gets 1 added and subtotal gets recalculated
                if (columnName == "IncreaseQty")
                {
                    orderItem.Quantity += 1;
                    orderItem.ItemSubTotal = orderItem.Quantity * product.Price;
                }
                // if column is decrease and quantity is more than 1, quantity gets 1 subtracted and subtotal gets recalculated
                else if (columnName == "DecreaseQty" && orderItem.Quantity > 1)
                {
                    orderItem.Quantity -= 1;
                    orderItem.ItemSubTotal = orderItem.Quantity * product.Price;
                }
                // if column is delete order item gets removed
                else if (columnName == "Delete")
                {
                    db.OrderItems.Remove(orderItem);
                }
            }
            else
            {
                return;
            }
            // saves database changes
            db.SaveChanges();
            // Recalculate totals
            GetOrderTotals();
            // repopulates data grid view
            PopulateDataGridView();
        }

        /// <summary>
        /// Method that fetches all order items into a list and calcualtes totals, then populates order model and total text boxes.
        /// </summary>
        private void GetOrderTotals()
        {
            using var db = new DBContext();

            var orderItems = db.OrderItems.Where(i => i.OrderID == _order.OrderID).Include(i => i.MenuItem).ToList();
            var order = db.Orders.First(o => o.OrderID == _order.OrderID);

            decimal subTotal = orderItems.Sum(i => i.ItemSubTotal);
            decimal vatAmount = subTotal * 0.15m;
            decimal orderTotal = subTotal + vatAmount;

            order.VATAmount = vatAmount;
            order.OrderTotal = orderTotal;

            db.SaveChanges();

            tbSubTotal.Text = $"   R {subTotal:0.00}";
            tbVatAmount.Text = $"   R {vatAmount:0.00}";
            tbOrderTotal.Text = $"   R {orderTotal:0.00}";
        }
        private void OrderDetailsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.ShowDialog();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbVatAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
