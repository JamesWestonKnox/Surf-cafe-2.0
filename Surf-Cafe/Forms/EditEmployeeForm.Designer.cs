namespace Surf_Cafe.Forms
{
    partial class EditEmployeeForm
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
            lblEmployee = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(121, 37);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(0, 15);
            lblEmployee.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 91);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 134);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 177);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(26, 250);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(121, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(222, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(59, 108);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(177, 23);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(59, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 8;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Staff" });
            cmbRole.Location = new Point(59, 151);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(177, 23);
            cmbRole.TabIndex = 9;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 400);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblEmployee);
            Name = "EditEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditEmployeeForm";
            Load += EditEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployee;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbRole;
    }
}