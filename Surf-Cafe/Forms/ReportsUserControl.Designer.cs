namespace Surf_Cafe.Forms
{
    partial class ReportsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvReports = new DataGridView();
            colReportName = new DataGridViewTextBoxColumn();
            colDateCreated = new DataGridViewTextBoxColumn();
            Open = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AllowUserToResizeColumns = false;
            dgvReports.AllowUserToResizeRows = false;
            dgvReports.BackgroundColor = SystemColors.Control;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { colReportName, colDateCreated, Open });
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.Location = new Point(0, 0);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersVisible = false;
            dgvReports.Size = new Size(510, 393);
            dgvReports.TabIndex = 0;
            dgvReports.CellContentClick += dgvReports_CellContentClick_1;
            // 
            // colReportName
            // 
            colReportName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colReportName.DataPropertyName = "FileName";
            colReportName.HeaderText = "Report Name";
            colReportName.Name = "colReportName";
            colReportName.ReadOnly = true;
            // 
            // colDateCreated
            // 
            colDateCreated.HeaderText = "Date Created";
            colDateCreated.Name = "colDateCreated";
            colDateCreated.ReadOnly = true;
            colDateCreated.Width = 150;
            // 
            // Open
            // 
            Open.FlatStyle = FlatStyle.Flat;
            Open.HeaderText = "Open";
            Open.Name = "Open";
            Open.Resizable = DataGridViewTriState.True;
            Open.SortMode = DataGridViewColumnSortMode.Automatic;
            Open.Text = "Open";
            Open.UseColumnTextForButtonValue = true;
            // 
            // ReportsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvReports);
            Name = "ReportsUserControl";
            Size = new Size(510, 393);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReports;
        private DataGridViewTextBoxColumn colReportName;
        private DataGridViewTextBoxColumn colDateCreated;
        private DataGridViewButtonColumn Open;
    }
}
