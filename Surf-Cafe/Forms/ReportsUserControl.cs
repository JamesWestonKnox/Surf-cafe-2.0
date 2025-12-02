using iText.Bouncycastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surf_Cafe.Forms
{
    public partial class ReportsUserControl : UserControl
    {
        public ReportsUserControl()
        {
            InitializeComponent();
            LoadReports();
        }

        /// <summary>
        /// Loads all reports generated in the system
        /// </summary>
        private void LoadReports()
        {
            dgvReports.Rows.Clear();

            //Creating the path where the reports are stored
            string folder = Path.Combine(Application.StartupPath, "Reports");

            if (!Directory.Exists(folder))
            {
                return;
            }
            
            //Retreiving the files from the folder
            var files = Directory.GetFiles(folder, "*.pdf");

            //Displaying each report in the data grid view
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                dgvReports.Rows.Add(info.Name, info.LastWriteTime);
            }
        }


        /// <summary>
        /// Opens the specific report when the user clicks open in the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReports_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvReports.Columns[e.ColumnIndex].Name == "Open")
            {
                //Getting the exact path and file name so that it can be opened
                string fileName = dgvReports.Rows[e.RowIndex].Cells[0].Value.ToString();
                string path = Path.Combine(Application.StartupPath, "Reports", fileName);

                if (File.Exists(path))
                {
                    //Opening the report as a pdf
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("Report not found");
                }
            }
        }
    }
}
