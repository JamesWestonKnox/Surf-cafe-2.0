using System.ComponentModel;

namespace Surf_Cafe
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Login));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.MenuHighlight;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(189, 253);
            button1.Name = "button1";
            button1.Size = new Size(204, 90);
            button1.TabIndex = 0;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Location = new Point(189, 144);
            button2.Name = "button2";
            button2.Size = new Size(204, 88);
            button2.TabIndex = 1;
            button2.Text = "Employee";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 126);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 2;
            label1.Text = "PLEASE SELECT YOUR USER";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(189, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(575, 448);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
