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
    public partial class CategoryCard : UserControl
    {
        private string categoryName;
        public int categoryID {  get; set; }

        
        public string CategoryName
        {
            get => categoryName;
            set {  categoryName = value; 
                    lblCategoryName.Text = value;
                }
        }

        public event Action<int, string> CategoryClicked;

        public CategoryCard()
        {
            InitializeComponent();
            this.Click += CategoryCard_Click;
            lblCategoryName.Click += CategoryCard_Click;
        }

        private void CategoryCard_Click(object sender, EventArgs e)
        {
            CategoryClicked?.Invoke(categoryID, categoryName);
        }

    }
}
