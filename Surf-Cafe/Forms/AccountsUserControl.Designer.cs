namespace Surf_Cafe.Forms
{
    partial class AccountsUserControl
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
            flpAccounts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 68);
            label1.Name = "label1";
            label1.Size = new Size(318, 40);
            label1.TabIndex = 0;
            label1.Text = "Choose your Account:";
            // 
            // flpAccounts
            // 
            flpAccounts.Location = new Point(68, 122);
            flpAccounts.Name = "flpAccounts";
            flpAccounts.Size = new Size(676, 339);
            flpAccounts.TabIndex = 1;
            // 
            // AccountsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpAccounts);
            Controls.Add(label1);
            Name = "AccountsUserControl";
            Size = new Size(812, 506);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpAccounts;
    }
}
