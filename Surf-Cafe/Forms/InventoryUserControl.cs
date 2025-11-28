using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Surf_Cafe.Database;
using Surf_Cafe.Forms;

namespace Surf_Cafe.Forms
{
    public partial class InventoryUserControl : UserControl
    {
        public InventoryUserControl()
        {
            InitializeComponent();
            SetUpDataGridView();
            LoadStockItems();
        }

        public void SetUpDataGridView()
        {
            dgvStock.Columns.Add("StockItemID", "ID");
            dgvStock.Columns.Add("StockItemName", "Item Name");
            dgvStock.Columns.Add("StartOfDayQuantity", "Start of Day Qty");
            dgvStock.Columns.Add("EndOfDayQuantity", "End of Day Qty");
            dgvStock.Columns.Add("Unit", "Unit");
            dgvStock.Columns.Add("Threshold", "Threshold");
            dgvStock.Columns.Add("LastUpdated", "Last Updated");
            dgvStock.Columns.Add("Status", "Status");

            dgvStock.Columns["StockItemID"].Visible = false;

            foreach (DataGridViewColumn col in dgvStock.Columns)
            {
                if (col.Name != "EndOfDayQuantity")
                {
                    col.ReadOnly = true;
                }
            }

            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        public void LoadStockItems()
        {
            dgvStock.Rows.Clear();

            using var db = new DBContext();
            var stockList = db.StockItems.ToList();

            foreach (var stock in stockList)
            {
                dgvStock.Rows.Add(
                    stock.StockItemID,
                    stock.StockItemName,
                    stock.StartOfDayQuantity,
                    stock.EndOfDayQuantity,
                    stock.Unit,
                    stock.Threshold,
                    stock.LastUpdated.ToString("g")
                    );
                
                var addedRow = dgvStock.Rows[dgvStock.Rows.Count - 1];

                if (stock.EndOfDayQuantity < stock.Threshold)
                {
                   addedRow.DefaultCellStyle.BackColor = Color.LightCoral;
                   addedRow.DefaultCellStyle.ForeColor = Color.White;
                }

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var db = new DBContext();

            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (row.IsNewRow) continue;

                int id = Convert.ToInt32(row.Cells["StockItemID"].Value);
                var stock = db.StockItems.Find(id);
                if(stock != null)
                {
                    stock.EndOfDayQuantity = Convert.ToInt32(row.Cells["EndOfDayQuantity"].Value);
                    stock.LastUpdated = DateTime.Now;
                }

            }

            db.SaveChanges();
            MessageBox.Show("Stock Quantities Updated!");
            LoadStockItems();


        }
    }
}
