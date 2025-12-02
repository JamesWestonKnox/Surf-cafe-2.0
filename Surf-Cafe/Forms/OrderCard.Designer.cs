namespace Surf_Cafe.Forms
{
    partial class OrderCard
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
            lblOrderName = new Label();
            lblDateCreated = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblOrderName
            // 
            lblOrderName.AutoSize = true;
            lblOrderName.ForeColor = SystemColors.Window;
            lblOrderName.Location = new Point(40, 22);
            lblOrderName.Margin = new Padding(6, 0, 6, 0);
            lblOrderName.Name = "lblOrderName";
            lblOrderName.Size = new Size(72, 30);
            lblOrderName.TabIndex = 0;
            lblOrderName.Text = "label1";
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.ForeColor = SystemColors.Window;
            lblDateCreated.Location = new Point(40, 110);
            lblDateCreated.Margin = new Padding(6, 0, 6, 0);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(72, 30);
            lblDateCreated.TabIndex = 1;
            lblDateCreated.Text = "label2";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = SystemColors.Window;
            lblTotal.Location = new Point(40, 64);
            lblTotal.Margin = new Padding(6, 0, 6, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(72, 30);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "label1";
            // 
            // OrderCard
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 78, 99);
            Controls.Add(lblTotal);
            Controls.Add(lblDateCreated);
            Controls.Add(lblOrderName);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "OrderCard";
            Size = new Size(231, 179);
            Load += OrderCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderName;
        private Label lblDateCreated;
        private Label lblTotal;
    }
}
