namespace Surf_Cafe.Forms
{
    partial class UserCard
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
            lblUser = new Label();
            lblRole = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.Window;
            lblUser.Location = new Point(3, 0);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(30);
            lblUser.Size = new Size(292, 97);
            lblUser.TabIndex = 0;
            lblUser.Text = "Set To Username";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = SystemColors.Window;
            lblRole.Location = new Point(25, 74);
            lblRole.Margin = new Padding(3, 20, 3, 0);
            lblRole.Name = "lblRole";
            lblRole.Padding = new Padding(20);
            lblRole.Size = new Size(194, 77);
            lblRole.TabIndex = 1;
            lblRole.Text = "Set To role";
            // 
            // UserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(22, 78, 99);
            Controls.Add(lblRole);
            Controls.Add(lblUser);
            Name = "UserCard";
            Size = new Size(298, 151);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblRole;
    }
}
