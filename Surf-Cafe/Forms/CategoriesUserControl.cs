using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Surf_Cafe.Database;
using Surf_Cafe.Models;

namespace Surf_Cafe.Forms
{
    public partial class CategoriesUserControl : UserControl
    {
        public event Action<int, string> CategorySelected;
        public CategoriesUserControl()
        {
            InitializeComponent();
            LoadCategories();
        }

        public void LoadCategories()
        {
            flpCategories.Controls.Clear();

            using var db = new DBContext();
            var categories = db.Categories.ToList();

            foreach (var category in categories)
            {
                var card = new CategoryCard
                {
                    CategoryName = category.CategoryName,
                    Width = 300,
                    Height = 100,
                    Margin = new Padding(10)
                };

                card.CategoryClicked += Card_CategoryClicked;

                flpCategories.Controls.Add(card);
            }
        }

        private void Card_CategoryClicked(int categoryID, string categoryName)
        {
           CategorySelected?.Invoke(categoryID, categoryName);
        }
    }
}
