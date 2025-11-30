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

        private void LoadProductDetails()
        {
            using var db = new DBContext();
            var product = db.MenuItems.FirstOrDefault(p => p.MenuItemID == _productID);
            if (product != null)
            {
                lblName.Text = product.Name;
                txtName.Text = product.Name;
                txtDescription.Text = product.Description;
                txtPrice.Text = product.Price.ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using var db = new DBContext();
            var product = db.MenuItems.FirstOrDefault(p => p.MenuItemID == _productID);
            if (product != null)
            {
                product.Name = txtName.Text;
                product.Description = txtDescription.Text;
                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    product.Price = price;
                }
                else
                {
                    MessageBox.Show("Enter a valid price");
                    return;
                }
                db.SaveChanges();
                MessageBox.Show("Product updated successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using var db = new DBContext();
                var product = db.MenuItems.FirstOrDefault(p => p.MenuItemID == _productID);
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
