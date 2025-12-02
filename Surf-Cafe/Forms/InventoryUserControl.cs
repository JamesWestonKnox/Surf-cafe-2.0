using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Surf_Cafe.Database;

namespace Surf_Cafe.Forms
{
    public partial class InventoryUserControl : UserControl
    {
        public InventoryUserControl()
        {
            InitializeComponent();
            LoadStockItems();
        }

        /// <summary>
        /// Loads all the stock items into the table on the user control
        /// </summary>
        public void LoadStockItems()
        {
            dgvStock.Rows.Clear();

            //Opening the database connection and retrieving al the stock as a list
            using var db = new DBContext();
            var stockList = db.StockItems.ToList();

            //Going through the list and adding each stockItem attribute to the table
            foreach (var stock in stockList)
            {
                //Status determining if a stockItem is running low or is ok depending on the threshold
                string status = stock.EndOfDayQuantity < stock.Threshold ? "LOW" : "OK";

                //Adding each attribute of the stockItem to the table
                dgvStock.Rows.Add(
                    stock.StockItemID,
                    stock.StockItemName,
                    stock.StartOfDayQuantity,
                    stock.EndOfDayQuantity,
                    stock.Unit,
                    stock.Threshold,
                    stock.LastUpdated.ToString("g"),
                    status);

                var addedRow = dgvStock.Rows[dgvStock.Rows.Count - 1];

                //Highlighting rows in the table where the stock is running low
                if (stock.EndOfDayQuantity < stock.Threshold)
                {
                    addedRow.DefaultCellStyle.BackColor = Color.LightCoral;
                    addedRow.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Saves changes made to the StartOfDayQuantity and EndOfDayQuantity in the table
        /// </summary>
        public void SaveChanges()
        {
            //Opening the database connection
            using var db = new DBContext();

            //Going through each row of the table
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (row.IsNewRow) continue;

                //Saving the changes made to each specific stockItem
                int id = Convert.ToInt32(row.Cells["StockItemID"].Value);
                var stock = db.StockItems.Find(id);
                if (stock != null)
                {
                    stock.StartOfDayQuantity = Convert.ToInt32(row.Cells["StartOfDayQuantity"].Value);
                    stock.EndOfDayQuantity = Convert.ToInt32(row.Cells["EndOfDayQuantity"].Value);
                    stock.LastUpdated = DateTime.Now;
                }

            }

            //Saving changes to the database
            db.SaveChanges();
            MessageBox.Show("Stock Quantities Updated!");
            LoadStockItems();

        }

        /// <summary>
        /// Generates a stock report based on the stock data as a pdf
        /// 
        /// ChatGpt Assited with layout and functionality for pdf generation.
        /// 
        /// Reference:
        /// ChatGPT
        /// OpenAI, 2025. ChatGPT[Computer program]. Version GPT-5 mini.
        /// Available at: https://chat.openai.com
        /// 
        /// </summary>
        public void GenerateStockReport()
        {
            //Validation to ensure that there is stockItems in the data grid view
            if (dgvStock.Rows.Count == 0)
            {
                MessageBox.Show("No stock available to generate report");
                return;
            }

            //Ensuring the report folder exists otherwise creates a new one in the project folder
            string folder = Path.Combine(Application.StartupPath, "Reports");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //Creating a filePath that is unique for each report generated
            string filePath = Path.Combine(folder, $"StockReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

            //
            using var writer = new PdfWriter(filePath);
            using var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            //Creating the layout of the report
            //Adding Title
            document.Add(new Paragraph("Stock Report")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(18));

            //Adding time and date it's generated
            document.Add(new Paragraph($"Generated: {DateTime.Now:g}")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(12));

            //Creating the table with headings
            Table table = new Table(6, true);
            table.AddHeaderCell("Item name");
            table.AddHeaderCell("Start of day Quantity");
            table.AddHeaderCell("End of day Quantity");
            table.AddHeaderCell("Unit");
            table.AddHeaderCell("Threshold");
            table.AddHeaderCell("Status");

            //Inputting the data from the data into the report under the right headings
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
                table.AddCell(row.Cells["Status"].Value?.ToString() ?? "");

            }

            //Adding the table to the databse
            document.Add(table);
            document.Close();
            MessageBox.Show("Report generated successfully");

            //Opening the generated report after its been generated
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);

        }
    }
}
