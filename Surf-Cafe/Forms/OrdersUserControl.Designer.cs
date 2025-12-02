namespace Surf_Cafe.Forms
{
    partial class OrdersUserControl
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
            flpOrders = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpOrders
            // 
            flpOrders.BackColor = SystemColors.Window;
            flpOrders.Dock = DockStyle.Fill;
            flpOrders.Location = new Point(0, 0);
            flpOrders.Name = "flpOrders";
            flpOrders.Size = new Size(765, 545);
            flpOrders.TabIndex = 0;
            flpOrders.Paint += flpOrders_Paint;
            // 
            // OrdersUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpOrders);
            Name = "OrdersUserControl";
            Size = new Size(765, 545);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpOrders;
    }
}
