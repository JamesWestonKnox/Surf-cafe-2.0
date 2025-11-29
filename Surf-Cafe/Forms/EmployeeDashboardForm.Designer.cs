namespace Surf_Cafe.Forms
{
    partial class EmployeeDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboardForm));
            pnlSidebar = new Panel();
            pnlMenuButtons = new Panel();
            btnInventory = new Button();
            btnMenu = new Button();
            btnOrders = new Button();
            btnCollapse = new Button();
            btnLogout = new Button();
            pnlLogo = new Panel();
            pnlSubHeading = new Panel();
            pbLogo = new PictureBox();
            lblMainHeading = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlMenuButtons.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(pnlMenuButtons);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(234, 579);
            pnlSidebar.TabIndex = 8;
            // 
            // pnlMenuButtons
            // 
            pnlMenuButtons.Controls.Add(btnInventory);
            pnlMenuButtons.Controls.Add(btnMenu);
            pnlMenuButtons.Controls.Add(btnOrders);
            pnlMenuButtons.Controls.Add(btnCollapse);
            pnlMenuButtons.Dock = DockStyle.Top;
            pnlMenuButtons.Location = new Point(0, 131);
            pnlMenuButtons.Name = "pnlMenuButtons";
            pnlMenuButtons.Size = new Size(234, 364);
            pnlMenuButtons.TabIndex = 8;
            // 
            // btnInventory
            // 
            btnInventory.Dock = DockStyle.Top;
            btnInventory.Location = new Point(0, 261);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(234, 100);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.Location = new Point(0, 177);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(234, 84);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.Location = new Point(0, 84);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(234, 93);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnCollapse
            // 
            btnCollapse.Dock = DockStyle.Top;
            btnCollapse.ImageAlign = ContentAlignment.MiddleRight;
            btnCollapse.Location = new Point(0, 0);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(234, 84);
            btnCollapse.TabIndex = 0;
            btnCollapse.Text = "Collapse";
            btnCollapse.UseVisualStyleBackColor = true;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Location = new Point(0, 534);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(234, 45);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pnlSubHeading);
            pnlLogo.Controls.Add(pbLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(234, 131);
            pnlLogo.TabIndex = 7;
            // 
            // pnlSubHeading
            // 
            pnlSubHeading.Location = new Point(234, 71);
            pnlSubHeading.Name = "pnlSubHeading";
            pnlSubHeading.Size = new Size(785, 60);
            pnlSubHeading.TabIndex = 1;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = SystemColors.MenuHighlight;
            pbLogo.Dock = DockStyle.Fill;
            pbLogo.Image = Properties.Resources.Surf_Cafe_logo1;
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(234, 131);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // lblMainHeading
            // 
            lblMainHeading.Dock = DockStyle.Top;
            lblMainHeading.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainHeading.Location = new Point(234, 0);
            lblMainHeading.Name = "lblMainHeading";
            lblMainHeading.Size = new Size(747, 68);
            lblMainHeading.TabIndex = 9;
            lblMainHeading.Text = "Employee Dashboard";
            lblMainHeading.Click += lblMainHeading_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(234, 68);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(747, 511);
            pnlContent.TabIndex = 10;
            // 
            // EmployeeDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 579);
            Controls.Add(pnlContent);
            Controls.Add(lblMainHeading);
            Controls.Add(pnlSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeDashboardForm";
            Text = "EmployeeDashboard";
            Load += EmployeeDashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMenuButtons.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlMenuButtons;
        private Button btnInventory;
        private Button btnMenu;
        private Button btnOrders;
        private Button btnCollapse;
        private Button btnLogout;
        private Panel pnlLogo;
        private Panel pnlSubHeading;
        private PictureBox pbLogo;
        private Label lblMainHeading;
        private Panel pnlContent;
    }
}