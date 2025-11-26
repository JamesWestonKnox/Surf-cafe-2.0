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
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.CancelBtn = new Button();
            this.LoginBtn = new Button();
            this.label1 = new Label();
            base.SuspendLayout();
            this.txtUsername.Location = new Point(333, 216);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(100, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextChanged += this.textBox1_TextChanged;
            this.txtPassword.Location = new Point(333, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(100, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.CancelBtn.BackColor = Color.LightCoral;
            this.CancelBtn.Location = new Point(304, 274);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new Size(75, 37);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += this.button1_Click;
            this.LoginBtn.BackColor = SystemColors.ActiveCaption;
            this.LoginBtn.Location = new Point(385, 274);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new Size(75, 37);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += this.button2_Click;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(345, 186);
            this.label1.Name = "label1";
            this.label1.Size = new Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Login\r\n";
            this.label1.Click += this.label1_Click;
            base.AutoScaleDimensions = new SizeF(7f, 15f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(800, 450);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.LoginBtn);
            base.Controls.Add(this.CancelBtn);
            base.Controls.Add(this.txtPassword);
            base.Controls.Add(this.txtUsername);
            base.Icon = (Icon)resources.GetObject("$this.Icon");
            base.Name = "AdminLogin";
            this.Text = "AdminLogin";
            base.ResumeLayout(false);
            base.PerformLayout();
        }


        private TextBox txtUsername;


        private TextBox txtPassword;


        private Button CancelBtn;


        private Button LoginBtn;

        private Label label1;
        #endregion
    }
}