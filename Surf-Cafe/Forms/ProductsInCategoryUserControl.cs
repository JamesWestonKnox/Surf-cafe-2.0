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

        public void LoadProducts()
        {
            flpProducts.Controls.Clear();
            using var db = new DBContext();
            var products = db.MenuItems.Where(p => p.CategoryID == CategoryID).ToList();

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
                flpProducts.Controls.Add(card);
            }
        }
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
