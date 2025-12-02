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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            btnLoyalty.Text = "Loyalty Points";
            btnLoyalty.UseVisualStyleBackColor = true;
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
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 57);
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
            tbOrderTotal.Location = new Point(91, 56);
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
            tbSubTotal.Location = new Point(91, 0);
            tbSubTotal.Name = "tbSubTotal";
            tbSubTotal.ReadOnly = true;
            tbSubTotal.Size = new Size(278, 29);
            tbSubTotal.TabIndex = 8;
            tbSubTotal.TextChanged += tbSubTotal_TextChanged;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 29);
            label3.TabIndex = 7;
            label3.Text = "SubTotal:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 28);
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
            tbVatAmount.Location = new Point(91, 28);
            tbVatAmount.Name = "tbVatAmount";
            tbVatAmount.ReadOnly = true;
            tbVatAmount.Size = new Size(278, 29);
            tbVatAmount.TabIndex = 9;
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
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Product, Quantity, Price, IncreaseQty, DecreaseQty, Delete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
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
            IncreaseQty.FillWeight = 50F;
            IncreaseQty.HeaderText = "+";
            IncreaseQty.Name = "IncreaseQty";
            IncreaseQty.Resizable = DataGridViewTriState.False;
            IncreaseQty.Text = "+";
            IncreaseQty.UseColumnTextForButtonValue = true;
            // 
            // DecreaseQty
            // 
            DecreaseQty.FillWeight = 50F;
            DecreaseQty.HeaderText = "-";
            DecreaseQty.Name = "DecreaseQty";
            DecreaseQty.Resizable = DataGridViewTriState.False;
            DecreaseQty.Text = "-";
            DecreaseQty.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
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
