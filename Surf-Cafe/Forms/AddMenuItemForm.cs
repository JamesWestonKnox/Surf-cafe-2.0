using Surf_Cafe.Database;
using Surf_Cafe.Models;
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
    public partial class AddMenuItemForm : Form
    {
        private int _categoryID;
        private string _categoryName;

        public event Action ItemAdded;
        public AddMenuItemForm(int categoryID, string categoryName)
        {
            InitializeComponent();
            _categoryID = categoryID;
            _categoryName = categoryName;
            txtCategory.Text = categoryName;
        }

        /// <summary>
        /// Adds a new menu item within a specific menu category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Input validaition to ensure the required input is filled in and in a valid format
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the item name");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out var price))
            {
                MessageBox.Show("Invalid price. Enter a valid price");
                return;
            }

            using var db = new DBContext();

            //Creating the new menuItem
            var newItem = new MenuItem
            {
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Price = price,
                CategoryID = _categoryID,
                IsAvailable = true
            };

            //Adding and saving it to the database
            db.MenuItems.Add(newItem);
            db.SaveChanges();

            ItemAdded?.Invoke();
            MessageBox.Show($"Successfully added {newItem.Name} to {_categoryName}");
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
