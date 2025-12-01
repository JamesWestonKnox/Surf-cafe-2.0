namespace Surf_Cafe.Forms
{
    partial class OrderDetailsUserControl
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
            btnSave = new Button();
            btnPay = new Button();
            btnLoyalty = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 499);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(369, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            btnPay.Dock = DockStyle.Bottom;
            btnPay.Location = new Point(0, 577);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(369, 39);
            btnPay.TabIndex = 2;
            btnPay.Text = "Payment";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnLoyalty
            // 
            btnLoyalty.Dock = DockStyle.Bottom;
            btnLoyalty.Location = new Point(0, 538);
            btnLoyalty.Name = "btnLoyalty";
            btnLoyalty.Size = new Size(369, 39);
            btnLoyalty.TabIndex = 0;
            btnLoyalty.Text = "Loyalty";
            btnLoyalty.UseVisualStyleBackColor = true;
            btnLoyalty.Click += btnLoyalty_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.HotTrack;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Info;
            splitContainer1.Panel2.Controls.Add(btnSave);
            splitContainer1.Panel2.Controls.Add(btnLoyalty);
            splitContainer1.Panel2.Controls.Add(btnPay);
            splitContainer1.Size = new Size(1189, 616);
            splitContainer1.SplitterDistance = 816;
            splitContainer1.TabIndex = 4;
            // 
            // OrderDetailsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(splitContainer1);
            Name = "OrderDetailsUserControl";
            Size = new Size(1189, 616);
            Load += OrderDetailsUserControl_Load;
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnPay;
        private Button btnLoyalty;
        private SplitContainer splitContainer1;
    }
}
