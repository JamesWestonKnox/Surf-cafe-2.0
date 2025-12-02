using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Surf_Cafe.Models;
using Surf_Cafe.Database;
using System.Windows.Forms.Design;

namespace Surf_Cafe.Forms
{
    public partial class AddCategoryForm : Form
    {
        public event Action CategoryAdded;
        public AddCategoryForm()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Saves a new menu category to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text.Trim();

            //Validation to check if they have inputted a category name
            if (string.IsNullOrEmpty(name)) {
                MessageBox.Show("Please enter a valid category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var db = new DBContext();

            //Only adding the new category if it doesn't exist already
            if(db.Categories.Any(c => c.CategoryName == name))
            {
                MessageBox.Show("Category Already Exists");
                return;
            }

            var category = new Category
            {
                CategoryName = name
            };

            //Adding it and saving the database 
            db.Categories.Add(category);
            db.SaveChanges();

            CategoryAdded?.Invoke();

            MessageBox.Show("Category successfully created!");

            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}
