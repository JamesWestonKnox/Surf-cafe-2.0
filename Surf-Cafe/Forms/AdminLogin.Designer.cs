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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            CancelBtn = new Button();
            LoginBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(351, 267);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(351, 296);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 1;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.LightCoral;
            CancelBtn.Location = new Point(322, 325);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 37);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Exit";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += button1_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.Highlight;
            LoginBtn.ForeColor = SystemColors.Window;
            LoginBtn.Location = new Point(403, 325);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 37);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 237);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Please Login\r\n";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DodgerBlue;
            pictureBox1.Image = Properties.Resources.Surf_Cafe_logo;
            pictureBox1.Location = new Point(297, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(CancelBtn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            Load += AdminLogin_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private TextBox txtUsername;


        private TextBox txtPassword;


        private Button CancelBtn;


        private Button LoginBtn;

        private Label label1;
        #endregion

        private PictureBox pictureBox1;
    }
}