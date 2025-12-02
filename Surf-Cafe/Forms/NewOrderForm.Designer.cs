namespace Surf_Cafe.Forms
{
    partial class NewOrderForm
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
            txtOrderName = new TextBox();
            btnCancel = new Button();
            btnSaveOrder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(133, 20);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 0;
            label1.Text = "New Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(82, 84);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 1;
            label2.Text = "Order Name:";
            // 
            // txtOrderName
            // 
            txtOrderName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderName.Location = new Point(82, 117);
            txtOrderName.Name = "txtOrderName";
            txtOrderName.Size = new Size(252, 33);
            txtOrderName.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(22, 78, 99);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 15.75F);
            btnCancel.ForeColor = SystemColors.Window;
            btnCancel.Location = new Point(82, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 42);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.BackColor = Color.FromArgb(22, 78, 99);
            btnSaveOrder.FlatAppearance.BorderSize = 0;
            btnSaveOrder.FlatStyle = FlatStyle.Flat;
            btnSaveOrder.Font = new Font("Segoe UI", 15.75F);
            btnSaveOrder.ForeColor = SystemColors.Window;
            btnSaveOrder.Location = new Point(227, 172);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(107, 42);
            btnSaveOrder.TabIndex = 4;
            btnSaveOrder.Text = "Save";
            btnSaveOrder.UseVisualStyleBackColor = false;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // NewOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 116, 144);
            ClientSize = new Size(407, 243);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnCancel);
            Controls.Add(txtOrderName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewOrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOrderName;
        private Button btnCancel;
        private Button btnSaveOrder;
    }
}