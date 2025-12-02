namespace Surf_Cafe.Forms
{
    partial class ProductCard
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
            lblProductName = new Label();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = SystemColors.Window;
            lblProductName.Location = new Point(65, 65);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 40);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "label1";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 78, 99);
            Controls.Add(lblProductName);
            ForeColor = SystemColors.Window;
            Name = "ProductCard";
            Size = new Size(301, 180);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
    }
}
