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
            pnlContent = new Panel();
            flpOrderSummary = new FlowLayoutPanel();
            btnLoyalty = new Button();
            btnPay = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(26, 18);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(615, 535);
            pnlContent.TabIndex = 0;
            // 
            // flpOrderSummary
            // 
            flpOrderSummary.Location = new Point(680, 36);
            flpOrderSummary.Name = "flpOrderSummary";
            flpOrderSummary.Size = new Size(385, 455);
            flpOrderSummary.TabIndex = 1;
            // 
            // btnLoyalty
            // 
            btnLoyalty.Location = new Point(688, 519);
            btnLoyalty.Name = "btnLoyalty";
            btnLoyalty.Size = new Size(94, 23);
            btnLoyalty.TabIndex = 0;
            btnLoyalty.Text = "Loyalty";
            btnLoyalty.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(788, 519);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(84, 23);
            btnPay.TabIndex = 2;
            btnPay.Text = "Payment";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(895, 519);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // OrderDetailsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(btnPay);
            Controls.Add(btnSave);
            Controls.Add(btnLoyalty);
            Controls.Add(flpOrderSummary);
            Controls.Add(pnlContent);
            Name = "OrderDetailsUserControl";
            Size = new Size(1068, 556);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private FlowLayoutPanel flpOrderSummary;
        private Button btnLoyalty;
        private Button btnPay;
        private Button btnSave;
    }
}
