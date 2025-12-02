namespace Surf_Cafe.Forms
{
    partial class CategoryCard
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
            lblCategoryName = new Label();
            SuspendLayout();
            // 
            // lblCategoryName
            // 
            lblCategoryName.Anchor = AnchorStyles.None;
            lblCategoryName.AutoSize = true;
            lblCategoryName.BackColor = Color.FromArgb(22, 78, 99);
            lblCategoryName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryName.ForeColor = SystemColors.Window;
            lblCategoryName.Location = new Point(87, 78);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(100, 40);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "label1";
            // 
            // CategoryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 78, 99);
            Controls.Add(lblCategoryName);
            Name = "CategoryCard";
            Size = new Size(414, 212);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryName;
    }
}
