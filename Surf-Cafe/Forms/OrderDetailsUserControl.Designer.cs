namespace Surf_Cafe.Forms
{
    partial class OrderDetailsUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnSave = new Button();
            btnPay = new Button();
            btnLoyalty = new Button();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            ProductColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 499);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(369, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            btnPay.Dock = DockStyle.Bottom;
            btnPay.Location = new Point(0, 577);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(369, 39);
            btnPay.TabIndex = 2;
            btnPay.Text = "Payment";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnLoyalty
            // 
            btnLoyalty.Dock = DockStyle.Bottom;
            btnLoyalty.Location = new Point(0, 538);
            btnLoyalty.Name = "btnLoyalty";
            btnLoyalty.Size = new Size(369, 39);
            btnLoyalty.TabIndex = 0;
            btnLoyalty.Text = "Loyalty";
            btnLoyalty.UseVisualStyleBackColor = true;
            btnLoyalty.Click += btnLoyalty_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.HighlightText;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Info;
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(btnSave);
            splitContainer1.Panel2.Controls.Add(btnLoyalty);
            splitContainer1.Panel2.Controls.Add(btnPay);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1189, 616);
            splitContainer1.SplitterDistance = 816;
            splitContainer1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Gray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductColumn, QuantityColumn, PriceColumn });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(369, 499);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductColumn
            // 
            ProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            ProductColumn.DefaultCellStyle = dataGridViewCellStyle2;
            ProductColumn.HeaderText = "Product";
            ProductColumn.Name = "ProductColumn";
            ProductColumn.Resizable = DataGridViewTriState.False;
            ProductColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // QuantityColumn
            // 
            QuantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuantityColumn.HeaderText = "Quantity";
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.Resizable = DataGridViewTriState.False;
            QuantityColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PriceColumn
            // 
            PriceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PriceColumn.HeaderText = "Price";
            PriceColumn.Name = "PriceColumn";
            PriceColumn.Resizable = DataGridViewTriState.False;
            PriceColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderDetailsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(splitContainer1);
            Name = "OrderDetailsUserControl";
            Size = new Size(1189, 616);
            Load += OrderDetailsUserControl_Load;
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnPay;
        private Button btnLoyalty;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewTextBoxColumn PriceColumn;
    }
}
