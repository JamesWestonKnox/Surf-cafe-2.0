namespace Surf_Cafe.Forms
{
    partial class LoyaltyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoyaltyForm));
            label3 = new Label();
            label1 = new Label();
            tbEmail = new TextBox();
            btnBack = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(41, 34);
            label3.Name = "label3";
            label3.Size = new Size(274, 40);
            label3.TabIndex = 8;
            label3.Text = "Add Loyalty Points";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(41, 96);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 9;
            label1.Text = "Customer Email:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(41, 124);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(274, 23);
            tbEmail.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(22, 78, 99);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Window;
            btnBack.Location = new Point(41, 162);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 33);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(22, 78, 99);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Window;
            btnAdd.Location = new Point(200, 162);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 33);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // LoyaltyForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 116, 144);
            CancelButton = btnBack;
            ClientSize = new Size(356, 223);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(tbEmail);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoyaltyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loyalty Points";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox tbEmail;
        private Button btnBack;
        private Button btnAdd;
    }
}