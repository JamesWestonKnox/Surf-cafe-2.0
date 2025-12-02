namespace Surf_Cafe.Forms
{
    partial class AddProductForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            txtStockName = new TextBox();
            txtUnit = new TextBox();
            numThreshold = new NumericUpDown();
            numStartQuant = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStartQuant).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(60, 59);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 0;
            label1.Text = "Stock Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(60, 151);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 30);
            label2.TabIndex = 1;
            label2.Text = "Starting Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(60, 234);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 2;
            label3.Text = "Unit:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(59, 325);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 30);
            label4.TabIndex = 3;
            label4.Text = "Threshold:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(22, 78, 99);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15.75F);
            btnCancel.ForeColor = SystemColors.Window;
            btnCancel.Location = new Point(60, 415);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 36);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(22, 78, 99);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 15.75F);
            btnAdd.ForeColor = SystemColors.Window;
            btnAdd.Location = new Point(214, 415);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 36);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStockName
            // 
            txtStockName.Font = new Font("Segoe UI", 12F);
            txtStockName.Location = new Point(60, 95);
            txtStockName.Margin = new Padding(5, 6, 5, 6);
            txtStockName.Name = "txtStockName";
            txtStockName.PlaceholderText = "E.g. Tomato";
            txtStockName.Size = new Size(270, 29);
            txtStockName.TabIndex = 6;
            // 
            // txtUnit
            // 
            txtUnit.Font = new Font("Segoe UI", 12F);
            txtUnit.Location = new Point(59, 267);
            txtUnit.Margin = new Padding(5, 6, 5, 6);
            txtUnit.Name = "txtUnit";
            txtUnit.PlaceholderText = "E.g. Kg";
            txtUnit.Size = new Size(271, 29);
            txtUnit.TabIndex = 7;
            // 
            // numThreshold
            // 
            numThreshold.Font = new Font("Segoe UI", 12F);
            numThreshold.Location = new Point(60, 358);
            numThreshold.Name = "numThreshold";
            numThreshold.Size = new Size(270, 29);
            numThreshold.TabIndex = 8;
            // 
            // numStartQuant
            // 
            numStartQuant.Font = new Font("Segoe UI", 12F);
            numStartQuant.Location = new Point(60, 184);
            numStartQuant.Name = "numStartQuant";
            numStartQuant.Size = new Size(270, 29);
            numStartQuant.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(99, 9);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(190, 40);
            label5.TabIndex = 10;
            label5.Text = "Add Product";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 116, 144);
            ClientSize = new Size(381, 489);
            Controls.Add(label5);
            Controls.Add(numStartQuant);
            Controls.Add(numThreshold);
            Controls.Add(txtUnit);
            Controls.Add(txtStockName);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)numThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStartQuant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtStockName;
        private TextBox txtUnit;
        private NumericUpDown numThreshold;
        private NumericUpDown numStartQuant;
        private Label label5;
    }
}