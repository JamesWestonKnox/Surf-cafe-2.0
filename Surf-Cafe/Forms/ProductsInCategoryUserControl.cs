using Surf_Cafe.Database;
using System.Data;

namespace Surf_Cafe.Forms
{
    public partial class ProductsInCategoryUserControl : UserControl
    {
        private int CategoryID;
        private string CategoryName;
        public event Action<int> ProductClicked;
        public ProductsInCategoryUserControl(int categoryID, string categoryName, Action<int> productClicked = null)
        {
            InitializeComponent();
            CategoryID = categoryID;
            CategoryName = categoryName;
            ProductClicked = productClicked;
            LoadProducts();
        }

        /// <summary>
        /// Loads all products as cards onto the flow layout panel
        /// </summary>
        public void LoadProducts()
        {
            flpProducts.Controls.Clear();

            //Opening the database connection
            using var db = new DBContext();

            //Finding the specific products within the selected category
            var products = db.MenuItems.Where(p => p.CategoryID == CategoryID).ToList();

            //Creating a new product card for each product
            foreach (var product in products)
            {
                var card = new ProductCard
                {
                    ProductID = product.MenuItemID,
                    ProductName = product.Name,
                    Price = product.Price,
                    Width = 300,
                    Height = 100,
                    Margin = new Padding(10)
                };

                //Making the product card clickable and calling the events
                card.ProductClicked += (id) =>
                {
                    if (ProductClicked != null)
                    {
                        ProductClicked.Invoke(product.MenuItemID);
                    }
                    else
                    {
                        OpenEditProductForm(id);
                    }
                };

                //Adding the card to the flow layout panel
                flpProducts.Controls.Add(card);
            }
        }

        //Opening the EditProductForm and refreshing products
        private void OpenEditProductForm(int productID)
        {
            using var editForm = new EditProductForm(productID);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }
    }
}
