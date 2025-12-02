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
    public partial class EditProductForm : Form
    {
        private int _productID;
        public EditProductForm(int productID)
        {
            InitializeComponent();
            _productID = productID;
            LoadProductDetails();
        }

        /// <summary>
        /// Loads the details of a specific product selected
        /// </summary>
        private void LoadProductDetails()
        {
            //Opening the database connection
            using var db = new DBContext();

            //Finding the specific menu item selected
            var product = db.MenuItems.FirstOrDefault(p => p.MenuItemID == _productID);

            //If the product exists populate the fields with the data from the database
            if (product != null)
            {
                lblName.Text = product.Name;
                txtName.Text = product.Name;
                txtDescription.Text = product.Description;
                txtPrice.Text = product.Price.ToString();
            }
        }

        /// <summary>
        /// Saves the changes made in the popup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Opens the database connection
            using var db = new DBContext();

            //Finding the specific product selected
            var product = db.MenuItems.FirstOrDefault(p => p.MenuItemID == _productID);

            //If product is not null set the product details to the new inputs
            if (product != null)
            {
                product.Name = txtName.Text;
                product.Description = txtDescription.Text;

                //Validation ensuring correct input format and required fields are filled in
                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    product.Price = price;
                }
                else
                {
                    MessageBox.Show("Enter a valid price");
                    return;
                }

                //Saving changes to the database
                db.SaveChanges();
                MessageBox.Show("Product updated successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Deleting a product from the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Prompting the user if they are sure they want to delete the product
            var confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
          
            if (confirm == DialogResult.Yes)
            {
                //Opening database connection and finding the specific product
                using var db = new DBContext();
                var product = db.MenuItems.FirstOrDefault(p => p.MenuItemID == _productID);

                //Deleting the product and saving the database
                if (product != null)
                {
                    db.MenuItems.Remove(product);
                    db.SaveChanges();
                    MessageBox.Show("Product deleted successfully");
                    this.DialogResult= DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
