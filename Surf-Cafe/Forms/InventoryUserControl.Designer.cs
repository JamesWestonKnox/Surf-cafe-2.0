namespace Surf_Cafe.Forms
{
    partial class InventoryUserControl
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
            dgvStock = new DataGridView();
            StockItemID = new DataGridViewTextBoxColumn();
            StockItemName = new DataGridViewTextBoxColumn();
            StartOfDayQuantity = new DataGridViewTextBoxColumn();
            EndOfDayQuantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Threshold = new DataGridViewTextBoxColumn();
            LastUpdated = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToResizeColumns = false;
            dgvStock.AllowUserToResizeRows = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BackgroundColor = SystemColors.ControlLightLight;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Columns.AddRange(new DataGridViewColumn[] { StockItemID, StockItemName, StartOfDayQuantity, EndOfDayQuantity, Unit, Threshold, LastUpdated });
            dgvStock.Dock = DockStyle.Fill;
            dgvStock.Location = new Point(0, 0);
            dgvStock.Name = "dgvStock";
            dgvStock.Size = new Size(840, 554);
            dgvStock.TabIndex = 0;
            // 
            // StockItemID
            // 
            StockItemID.HeaderText = "ID";
            StockItemID.Name = "StockItemID";
            StockItemID.ReadOnly = true;
            StockItemID.SortMode = DataGridViewColumnSortMode.NotSortable;
            StockItemID.Visible = false;
            // 
            // StockItemName
            // 
            StockItemName.HeaderText = "Item Name";
            StockItemName.Name = "StockItemName";
            StockItemName.ReadOnly = true;
            StockItemName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // StartOfDayQuantity
            // 
            StartOfDayQuantity.HeaderText = "Start Of Day Qty";
            StartOfDayQuantity.Name = "StartOfDayQuantity";
            StartOfDayQuantity.ReadOnly = true;
            StartOfDayQuantity.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // EndOfDayQuantity
            // 
            EndOfDayQuantity.HeaderText = "End Of Day Qty";
            EndOfDayQuantity.Name = "EndOfDayQuantity";
            EndOfDayQuantity.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Unit
            // 
            Unit.HeaderText = "Unit";
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            Unit.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Threshold
            // 
            Threshold.HeaderText = "Threshold";
            Threshold.Name = "Threshold";
            Threshold.ReadOnly = true;
            Threshold.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // LastUpdated
            // 
            LastUpdated.HeaderText = "Last Updated";
            LastUpdated.Name = "LastUpdated";
            LastUpdated.ReadOnly = true;
            LastUpdated.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // InventoryUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvStock);
            Name = "InventoryUserControl";
            Size = new Size(840, 554);
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStock;
        private DataGridViewTextBoxColumn StockItemID;
        private DataGridViewTextBoxColumn StockItemName;
        private DataGridViewTextBoxColumn StartOfDayQuantity;
        private DataGridViewTextBoxColumn EndOfDayQuantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Threshold;
        private DataGridViewTextBoxColumn LastUpdated;
    }
}
