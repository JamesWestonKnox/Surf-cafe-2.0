namespace Surf_Cafe.Forms
{
    partial class LoginUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblUser = new Label();
            txtPasscode = new TextBox();
            btnCancel = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 72);
            label1.Name = "label1";
            label1.Size = new Size(281, 40);
            label1.TabIndex = 0;
            label1.Text = "Enter passcode for:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(374, 72);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(340, 40);
            lblUser.TabIndex = 1;
            lblUser.Text = "(Set to account chosen)";
            // 
            // txtPasscode
            // 
            txtPasscode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasscode.Location = new Point(205, 128);
            txtPasscode.Name = "txtPasscode";
            txtPasscode.PasswordChar = '*';
            txtPasscode.PlaceholderText = "E.g. 0000";
            txtPasscode.Size = new Size(284, 29);
            txtPasscode.TabIndex = 2;
            txtPasscode.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(205, 189);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 42);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(360, 189);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // LoginUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            Controls.Add(txtPasscode);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Name = "LoginUserControl";
            Size = new Size(778, 365);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUser;
        private TextBox txtPasscode;
        private Button btnCancel;
        private Button btnLogin;
    }
}
