using System.ComponentModel;

namespace Surf_Cafe.Forms
{
    partial class EmployeeLogin
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(354, 255);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(354, 284);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password";
            txtPassword.TextChanged += txtPassword_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 207);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 2;
            label1.Text = "     Please Enter your \r\nUsername and Pasword";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Location = new Point(327, 313);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.Location = new Point(408, 313);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // EmployeeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "EmployeeLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeLogin";
            Load += EmployeeLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private TextBox txtUsername;


        private TextBox txtPassword;


        private Label label1;


        private Button btnCancel;

        private Button btnLogin;
    }
}