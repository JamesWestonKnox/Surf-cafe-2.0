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
            label1 = new Label();
            textBox1 = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 27);
            label1.Name = "label1";
            label1.Size = new Size(309, 37);
            label1.TabIndex = 0;
            label1.Text = "Create a new Category";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(62, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 29);
            textBox1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 15.75F);
            btnCancel.Location = new Point(62, 173);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 37);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15.75F);
            btnSave.Location = new Point(224, 173);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 37);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 83);
            label2.Name = "label2";
            label2.Size = new Size(172, 30);
            label2.TabIndex = 4;
            label2.Text = "Category Name:";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 241);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnCancel;
        private Button btnSave;
        private Label label2;
    }
}