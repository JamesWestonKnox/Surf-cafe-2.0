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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            btnPay = new Button();
            btnLoyalty = new Button();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            label1 = new Label();
            tbOrderTotal = new TextBox();
            tbSubTotal = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbVatAmount = new TextBox();
            dataGridView1 = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            IncreaseQty = new DataGridViewButtonColumn();
            DecreaseQty = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(22, 78, 99);
            btnPay.Dock = DockStyle.Bottom;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPay.ForeColor = SystemColors.Window;
            btnPay.Location = new Point(0, 577);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(369, 39);
            btnPay.TabIndex = 2;
            btnPay.Text = "Payment";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnLoyalty
            // 
            btnLoyalty.BackColor = Color.FromArgb(22, 78, 99);
            btnLoyalty.Dock = DockStyle.Bottom;
            btnLoyalty.FlatAppearance.BorderSize = 0;
            btnLoyalty.FlatStyle = FlatStyle.Flat;
            btnLoyalty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoyalty.ForeColor = SystemColors.Window;
            btnLoyalty.Location = new Point(0, 538);
            btnLoyalty.Name = "btnLoyalty";
            btnLoyalty.Size = new Size(369, 39);
            btnLoyalty.TabIndex = 0;
            btnLoyalty.Text = "Loyalty Points";
            btnLoyalty.UseVisualStyleBackColor = false;
            btnLoyalty.Click += btnLoyalty_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
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
            splitContainer1.Panel2.BackColor = SystemColors.Window;
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(btnLoyalty);
            splitContainer1.Panel2.Controls.Add(btnPay);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1189, 616);
            splitContainer1.SplitterDistance = 816;
            splitContainer1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbOrderTotal);
            panel1.Controls.Add(tbSubTotal);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbVatAmount);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 88);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(22, 78, 99);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(0, 61);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 5;
            label1.Text = "Order Total:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click_2;
            // 
            // tbOrderTotal
            // 
            tbOrderTotal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbOrderTotal.BackColor = SystemColors.Window;
            tbOrderTotal.Cursor = Cursors.No;
            tbOrderTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbOrderTotal.Location = new Point(91, 60);
            tbOrderTotal.Name = "tbOrderTotal";
            tbOrderTotal.ReadOnly = true;
            tbOrderTotal.Size = new Size(278, 29);
            tbOrderTotal.TabIndex = 10;
            // 
            // tbSubTotal
            // 
            tbSubTotal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSubTotal.BackColor = SystemColors.Window;
            tbSubTotal.Cursor = Cursors.No;
            tbSubTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSubTotal.Location = new Point(91, 4);
            tbSubTotal.Name = "tbSubTotal";
            tbSubTotal.ReadOnly = true;
            tbSubTotal.Size = new Size(278, 29);
            tbSubTotal.TabIndex = 8;
            tbSubTotal.TextChanged += tbSubTotal_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(22, 78, 99);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(0, 3);
            label3.Name = "label3";
            label3.Size = new Size(92, 29);
            label3.TabIndex = 7;
            label3.Text = "Sub-total:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(22, 78, 99);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(0, 32);
            label2.Name = "label2";
            label2.Size = new Size(92, 29);
            label2.TabIndex = 6;
            label2.Text = "VAT:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // tbVatAmount
            // 
            tbVatAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbVatAmount.BackColor = SystemColors.Window;
            tbVatAmount.Cursor = Cursors.No;
            tbVatAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbVatAmount.Location = new Point(91, 33);
            tbVatAmount.Name = "tbVatAmount";
            tbVatAmount.ReadOnly = true;
            tbVatAmount.Size = new Size(278, 29);
            tbVatAmount.TabIndex = 9;
            tbVatAmount.TextChanged += tbVatAmount_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 78, 99);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Product, Quantity, Price, IncreaseQty, DecreaseQty, Delete });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(369, 538);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Product
            // 
            Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Product.DefaultCellStyle = dataGridViewCellStyle2;
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Resizable = DataGridViewTriState.False;
            Product.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Resizable = DataGridViewTriState.False;
            Quantity.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            Price.DefaultCellStyle = dataGridViewCellStyle4;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Resizable = DataGridViewTriState.False;
            Price.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // IncreaseQty
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(22, 78, 99);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(22, 78, 99);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            IncreaseQty.DefaultCellStyle = dataGridViewCellStyle5;
            IncreaseQty.FillWeight = 50F;
            IncreaseQty.FlatStyle = FlatStyle.Flat;
            IncreaseQty.HeaderText = "+";
            IncreaseQty.Name = "IncreaseQty";
            IncreaseQty.Resizable = DataGridViewTriState.False;
            IncreaseQty.Text = "+";
            IncreaseQty.UseColumnTextForButtonValue = true;
            // 
            // DecreaseQty
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(22, 78, 99);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(22, 78, 99);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            DecreaseQty.DefaultCellStyle = dataGridViewCellStyle6;
            DecreaseQty.FillWeight = 50F;
            DecreaseQty.FlatStyle = FlatStyle.Flat;
            DecreaseQty.HeaderText = "-";
            DecreaseQty.Name = "DecreaseQty";
            DecreaseQty.Resizable = DataGridViewTriState.False;
            DecreaseQty.Text = "-";
            DecreaseQty.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(22, 78, 99);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(22, 78, 99);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            Delete.DefaultCellStyle = dataGridViewCellStyle7;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.False;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnPay;
        private Button btnLoyalty;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox tbOrderTotal;
        private TextBox tbVatAmount;
        private TextBox tbSubTotal;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn IncreaseQty;
        private DataGridViewButtonColumn DecreaseQty;
        private DataGridViewButtonColumn Delete;
    }
}
