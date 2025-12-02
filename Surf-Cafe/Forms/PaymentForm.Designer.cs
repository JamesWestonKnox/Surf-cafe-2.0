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
            lblOrderName.Location = new Point(158, 54);
            lblOrderName.Name = "lblOrderName";
            lblOrderName.Size = new Size(121, 25);
            lblOrderName.TabIndex = 0;
            lblOrderName.Text = "Order Name";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Items.AddRange(new object[] { "Card", "Cash", "EFT" });
            cmbPaymentType.Location = new Point(88, 120);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(191, 23);
            cmbPaymentType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(88, 87);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 2;
            label1.Text = "Payment Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(90, 166);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Add Tip:";
            // 
            // txtTip
            // 
            txtTip.Location = new Point(90, 194);
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(189, 23);
            txtTip.TabIndex = 4;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Location = new Point(90, 268);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(189, 23);
            txtPaymentAmount.TabIndex = 5;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl.Location = new Point(90, 240);
            lbl.Name = "lbl";
            lbl.Size = new Size(143, 25);
            lbl.TabIndex = 6;
            lbl.Text = "Payment Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 9);
            label3.Name = "label3";
            label3.Size = new Size(138, 40);
            label3.TabIndex = 7;
            label3.Text = "Payment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 54);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 8;
            label4.Text = "Order -";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(204, 393);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(75, 23);
            btnPay.TabIndex = 9;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(88, 393);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // cmbDiscount
            // 
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Items.AddRange(new object[] { "Week Breakfast Special (8am - 9am)", "Weekend Lunch Special (11am - 2pm)" });
            cmbDiscount.Location = new Point(90, 342);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(189, 23);
            cmbDiscount.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(88, 314);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 12;
            label5.Text = "Apply Discount:";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "PaymentForm";
            Text = "PaymentForm";
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