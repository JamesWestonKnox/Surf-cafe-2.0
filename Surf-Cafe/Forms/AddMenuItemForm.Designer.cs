namespace Surf_Cafe.Forms
{
    partial class AddMenuItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMenuItemForm));
            label1 = new Label();
            lblCategory = new Label();
            txtCategory = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(56, 19);
            label1.Name = "label1";
            label1.Size = new Size(232, 40);
            label1.TabIndex = 0;
            label1.Text = "Add Menu Item";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblCategory.ForeColor = SystemColors.Window;
            lblCategory.Location = new Point(56, 72);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(99, 25);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Segoe UI", 12F);
            txtCategory.Location = new Point(57, 100);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(231, 29);
            txtCategory.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(57, 162);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 29);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(57, 229);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(231, 29);
            txtPrice.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(57, 293);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(231, 29);
            txtDescription.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(22, 78, 99);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15.75F);
            btnCancel.ForeColor = SystemColors.Window;
            btnCancel.Location = new Point(57, 346);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 39);
            btnCancel.TabIndex = 6;
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
            btnSave.Location = new Point(190, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 39);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(56, 265);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 8;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(57, 201);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 9;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(57, 134);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 10;
            label4.Text = "Item Name:";
            // 
            // AddMenuItemForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 116, 144);
            CancelButton = btnCancel;
            ClientSize = new Size(339, 422);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddMenuItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCategory;
        private TextBox txtCategory;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}