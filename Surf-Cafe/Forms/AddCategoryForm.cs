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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(name)) {
                MessageBox.Show("Please enter a valid category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var db = new DBContext();

            if(db.Categories.Any(c => c.CategoryName == name))
            {
                MessageBox.Show("Category Already Exists");
                return;
            }

            var category = new Category
            {
                CategoryName = name
            };

            db.Categories.Add(category);
            db.SaveChanges();

            CategoryAdded?.Invoke();

            MessageBox.Show("Category successfully created!");

            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}
