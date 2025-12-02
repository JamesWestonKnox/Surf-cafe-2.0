namespace Surf_Cafe.Forms
{
    partial class AddCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm));
            label1 = new Label();
            txtCategoryName = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(50, 27);
            label1.Name = "label1";
            label1.Size = new Size(329, 40);
            label1.TabIndex = 0;
            label1.Text = "Create a new Category";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryName.Location = new Point(62, 116);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(280, 29);
            txtCategoryName.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(22, 78, 99);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15.75F);
            btnCancel.ForeColor = SystemColors.Window;
            btnCancel.Location = new Point(62, 173);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 37);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(22, 78, 99);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15.75F);
            btnSave.ForeColor = SystemColors.Window;
            btnSave.Location = new Point(224, 173);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 37);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(57, 83);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 4;
            label2.Text = "Category Name:";
            // 
            // AddCategoryForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 116, 144);
            CancelButton = btnCancel;
            ClientSize = new Size(418, 241);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtCategoryName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryName;
        private Button btnCancel;
        private Button btnSave;
        private Label label2;
    }
}