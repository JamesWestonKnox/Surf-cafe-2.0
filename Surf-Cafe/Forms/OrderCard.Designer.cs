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
            lblOrderName.Location = new Point(94, 49);
            lblOrderName.Name = "lblOrderName";
            lblOrderName.Size = new Size(38, 15);
            lblOrderName.TabIndex = 0;
            lblOrderName.Text = "label1";
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(94, 112);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(38, 15);
            lblDateCreated.TabIndex = 1;
            lblDateCreated.Text = "label2";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(94, 81);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "label1";
            // 
            // OrderCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTotal);
            Controls.Add(lblDateCreated);
            Controls.Add(lblOrderName);
            Name = "OrderCard";
            Size = new Size(273, 226);
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
