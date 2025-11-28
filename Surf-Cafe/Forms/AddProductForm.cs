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
        public InventoryUserControl inventoryUserControl;
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtStockName.Text.Trim();
            string unit = txtUnit.Text.Trim();
            int startQty = (int)numStartQuant.Value;
            int threshold = (int)numThreshold.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter a valid stock name");
            }
            if (string.IsNullOrWhiteSpace(unit))
            {
                MessageBox.Show("Entere a valid unit");
            }

            using var db = new DBContext();

            var stockItem = new StockItem()
            {
                StockItemName = name,
                StartOfDayQuantity = startQty,
                EndOfDayQuantity = startQty,
                Unit = unit,
                Threshold = threshold,
                LastUpdated = DateTime.Now,
            };

            db.StockItems.Add(stockItem);
            db.SaveChanges();

            inventoryUserControl.LoadStockItems();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
