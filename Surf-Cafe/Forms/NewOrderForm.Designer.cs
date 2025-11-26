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
            label2.Location = new Point(82, 84);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 1;
            label2.Text = "Order Name:";
            // 
            // txtOrderName
            // 
            txtOrderName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderName.Location = new Point(82, 117);
            txtOrderName.Name = "txtOrderName";
            txtOrderName.PlaceholderText = "E.g. ...";
            txtOrderName.Size = new Size(252, 29);
            txtOrderName.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 15.75F);
            btnCancel.Location = new Point(82, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 42);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Font = new Font("Segoe UI", 15.75F);
            btnSaveOrder.Location = new Point(227, 172);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(107, 42);
            btnSaveOrder.TabIndex = 4;
            btnSaveOrder.Text = "Save";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // NewOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 274);
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