namespace Surf_Cafe.Forms
{
    partial class EditProductForm
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
            lblName = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            btnCancel = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(89, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 40);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 87);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Item name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 149);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 210);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "Description";
            // 
            // txtName
            // 
            txtName.Location = new Point(42, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 23);
            txtName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(42, 167);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(239, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(42, 228);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(239, 23);
            txtDescription.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(44, 301);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(127, 301);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(208, 301);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 360);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblName);
            Name = "EditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnSave;
    }
}