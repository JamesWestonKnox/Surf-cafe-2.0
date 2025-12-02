using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using Surf_Cafe.Database;
using Surf_Cafe.Forms;
using iText.Layout;
using System.IO;

namespace Surf_Cafe.Forms
{
    public partial class InventoryUserControl : UserControl
    {
        public InventoryUserControl()
        {
            InitializeComponent();
            LoadStockItems();
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

        public void SaveChanges()
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

        public void GenerateStockReport()
        {
            if (dgvStock.Rows.Count == 0)
            {
                MessageBox.Show("No stock available to generate report");
                return;
            }

            string folder = Path.Combine(Application.StartupPath, "Reports");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string filePath = Path.Combine(folder, $"StockReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

            using var writer = new PdfWriter(filePath);
            using var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            document.Add(new Paragraph("Stock Report")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(18));
            document.Add(new Paragraph($"Generated: {DateTime.Now:g}")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(12));

            Table table = new Table(5, true);
            table.AddHeaderCell("Item name");
            table.AddHeaderCell("Start of day Quantity");
            table.AddHeaderCell("End of day Quantity");
            table.AddHeaderCell("Unit");
            table.AddHeaderCell("Threshold");
            
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                table.AddCell(row.Cells["StockItemName"].Value?.ToString() ?? "");
                table.AddCell(row.Cells["StartOfDayQuantity"].Value?.ToString() ?? "");
                table.AddCell(row.Cells["EndOfDayQuantity"].Value?.ToString() ?? "");
                table.AddCell(row.Cells["Unit"].Value?.ToString() ?? "");
                table.AddCell(row.Cells["Threshold"].Value?.ToString() ?? "");

            }
            document.Add(table);
            document.Close();
            MessageBox.Show("Report generated successfully");

            
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
            
        }
    }
}
