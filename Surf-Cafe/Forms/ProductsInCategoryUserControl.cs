using Surf_Cafe.Database;
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
    public partial class ProductsInCategoryUserControl : UserControl
    {
        private int CategoryID;
        private string CategoryName;
        public ProductsInCategoryUserControl(int categoryID, string categoryName)
        {
            InitializeComponent();
            CategoryID = categoryID;
            CategoryName = categoryName;
            LoadProducts();
        }

        public void LoadProducts() 
        {
            flpProducts.Controls.Clear();
            using var db = new DBContext();
            var products = db.MenuItems.Where(p => p.CategoryID == CategoryID).ToList();

            foreach(var product in products)
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

                flpProducts.Controls.Add(card); 
            }
        }
    }
}
