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
    public partial class AddProductForm : Form
    {
        public event Action StockAdded;
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Adds stock to the inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Retrieves the input from the textboxes and other input elements
            string name = txtStockName.Text.Trim();
            string unit = txtUnit.Text.Trim();
            int startQty = (int)numStartQuant.Value;
            int threshold = (int)numThreshold.Value;


            //Input validation to ensure all required fields are filled in
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter a valid stock name");
            }
            if (string.IsNullOrWhiteSpace(unit))
            {
                MessageBox.Show("Enter a valid unit");
            }
            
            //Opening the database connection
            using var db = new DBContext();

            //Creating the new stockItem
            var stockItem = new StockItem()
            {
                StockItemName = name,
                StartOfDayQuantity = startQty,
                EndOfDayQuantity = startQty,
                Unit = unit,
                Threshold = threshold,
                LastUpdated = DateTime.Now,
            };

            //Adding it and saving the database
            db.StockItems.Add(stockItem);
            db.SaveChanges();

            StockAdded?.Invoke();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
