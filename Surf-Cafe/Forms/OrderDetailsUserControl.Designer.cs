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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BackColor = SystemColors.Control;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(821, 616);
            pnlContent.TabIndex = 0;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // flpOrderSummary
            // 
            flpOrderSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flpOrderSummary.BackColor = SystemColors.HotTrack;
            flpOrderSummary.Location = new Point(827, 0);
            flpOrderSummary.Name = "flpOrderSummary";
            flpOrderSummary.Size = new Size(362, 535);
            flpOrderSummary.TabIndex = 1;
            // 
            // btnLoyalty
            // 
            btnLoyalty.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLoyalty.Location = new Point(869, 541);
            btnLoyalty.Name = "btnLoyalty";
            btnLoyalty.Size = new Size(94, 23);
            btnLoyalty.TabIndex = 0;
            btnLoyalty.Text = "Loyalty";
            btnLoyalty.UseVisualStyleBackColor = true;
            btnLoyalty.Click += btnLoyalty_Click;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPay.Location = new Point(969, 541);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(84, 23);
            btnPay.TabIndex = 2;
            btnPay.Text = "Payment";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(1059, 541);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLoyalty);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 616);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint_1;
            // 
            // OrderDetailsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(flpOrderSummary);
            Controls.Add(pnlContent);
            Controls.Add(panel1);
            Name = "OrderDetailsUserControl";
            Size = new Size(1189, 616);
            Load += OrderDetailsUserControl_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private FlowLayoutPanel flpOrderSummary;
        private Button btnLoyalty;
        private Button btnPay;
        private Button btnSave;
        private Panel panel1;
    }
}
