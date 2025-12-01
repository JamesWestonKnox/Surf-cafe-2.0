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
            var productsUC = new ProductsInCategoryUserControl(categoryID, categoryName);
            productsUC.Dock = DockStyle.Fill;

            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel1.Controls.Add(productsUC);
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
