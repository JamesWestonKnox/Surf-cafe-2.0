namespace Surf_Cafe.Forms
{
    partial class PaymentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            lblOrderName = new Label();
            cmbPaymentType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtTip = new TextBox();
            txtPaymentAmount = new TextBox();
            lbl = new Label();
            label3 = new Label();
            label4 = new Label();
            btnPay = new Button();
            btnBack = new Button();
            cmbDiscount = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblOrderName
            // 
            lblOrderName.AutoSize = true;
            lblOrderName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderName.ForeColor = SystemColors.Window;
            lblOrderName.Location = new Point(163, 52);
            lblOrderName.Name = "lblOrderName";
            lblOrderName.Size = new Size(121, 25);
            lblOrderName.TabIndex = 0;
            lblOrderName.Text = "Order Name";
            lblOrderName.Click += lblOrderName_Click;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.ForeColor = SystemColors.WindowText;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Items.AddRange(new object[] { "Card", "Cash", "EFT" });
            cmbPaymentType.Location = new Point(80, 114);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(191, 23);
            cmbPaymentType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(80, 86);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 2;
            label1.Text = "Payment Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(80, 151);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Add Tip:";
            label2.Click += label2_Click;
            // 
            // txtTip
            // 
            txtTip.ForeColor = SystemColors.WindowText;
            txtTip.Location = new Point(80, 179);
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(189, 23);
            txtTip.TabIndex = 4;
            txtTip.TextChanged += txtTip_TextChanged;
            txtTip.KeyPress += txtTip_KeyPress;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.BackColor = SystemColors.Window;
            txtPaymentAmount.ForeColor = SystemColors.WindowText;
            txtPaymentAmount.Location = new Point(80, 318);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.ReadOnly = true;
            txtPaymentAmount.Size = new Size(189, 23);
            txtPaymentAmount.TabIndex = 5;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl.ForeColor = SystemColors.Window;
            lbl.Location = new Point(80, 290);
            lbl.Name = "lbl";
            lbl.Size = new Size(143, 25);
            lbl.TabIndex = 6;
            lbl.Text = "Payment Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(113, 9);
            label3.Name = "label3";
            label3.Size = new Size(138, 40);
            label3.TabIndex = 7;
            label3.Text = "Payment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(80, 52);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 8;
            label4.Text = "Order -";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(22, 78, 99);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPay.ForeColor = SystemColors.Window;
            btnPay.Location = new Point(194, 368);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(75, 33);
            btnPay.TabIndex = 9;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(22, 78, 99);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Window;
            btnBack.Location = new Point(80, 368);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 33);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // cmbDiscount
            // 
            cmbDiscount.ForeColor = SystemColors.WindowText;
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Items.AddRange(new object[] { "None", "10%", "15%", "20%", "50%" });
            cmbDiscount.Location = new Point(80, 246);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(189, 23);
            cmbDiscount.TabIndex = 11;
            cmbDiscount.SelectedIndexChanged += cmbDiscount_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(80, 218);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 12;
            label5.Text = "Apply Discount:";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 116, 144);
            ClientSize = new Size(365, 451);
            Controls.Add(label5);
            Controls.Add(cmbDiscount);
            Controls.Add(btnBack);
            Controls.Add(btnPay);
            Controls.Add(lblOrderName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl);
            Controls.Add(txtPaymentAmount);
            Controls.Add(txtTip);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbPaymentType);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += PaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderName;
        private ComboBox cmbPaymentType;
        private Label label1;
        private Label label2;
        private TextBox txtTip;
        private TextBox txtPaymentAmount;
        private Label lbl;
        private Label label3;
        private Label label4;
        private Button btnPay;
        private Button btnBack;
        private ComboBox cmbDiscount;
        private Label label5;
    }
}