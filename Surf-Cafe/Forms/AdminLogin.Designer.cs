using System.ComponentModel;

namespace Surf_Cafe.Forms
{
    partial class AdminLogin
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AdminLogin));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            LoginBtn = new Button();
            pictureBox1 = new PictureBox();
            CancelBtn = new Button();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(351, 258);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(100, 29);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(351, 293);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(100, 29);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(22, 78, 99);
            LoginBtn.BackgroundImageLayout = ImageLayout.None;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.ForeColor = SystemColors.Window;
            LoginBtn.Location = new Point(409, 356);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 37);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(14, 116, 144);
            pictureBox1.Image = Properties.Resources.Surf_Cafe_logo;
            pictureBox1.Location = new Point(219, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(22, 78, 99);
            CancelBtn.BackgroundImageLayout = ImageLayout.None;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.ForeColor = SystemColors.Window;
            CancelBtn.Location = new Point(317, 356);
            CancelBtn.Margin = new Padding(0);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 37);
            CancelBtn.TabIndex = 2;
            CancelBtn.TabStop = false;
            CancelBtn.Text = "Exit";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += button1_Click;
            // 
            // AdminLogin
            // 
            AcceptButton = LoginBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 116, 144);
            CancelButton = CancelBtn;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            Controls.Add(CancelBtn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += AdminLogin_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private TextBox txtUsername;


        private TextBox txtPassword;


        private Button LoginBtn;
        #endregion

        private PictureBox pictureBox1;
        private Button CancelBtn;
    }
}