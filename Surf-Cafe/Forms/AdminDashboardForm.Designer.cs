namespace Surf_Cafe.Forms
{
    partial class AdminDashboardForm
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
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnEmployees = new Button();
            btnInventory = new Button();
            btnMenu = new Button();
            btnOrders = new Button();
            btnCollapse = new Button();
            pnlHeader = new Panel();
            pnlContent = new Panel();
            pnlLogo = new Panel();
            pbLogo = new PictureBox();
            pnlMenuButtons = new Panel();
            pnlSidebar.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlMenuButtons.SuspendLayout();
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
            pnlSidebar.Size = new Size(176, 517);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += panel1_Paint;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Location = new Point(0, 476);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(176, 41);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.Location = new Point(0, 205);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(176, 41);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.Location = new Point(0, 164);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(176, 41);
            btnEmployees.TabIndex = 4;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.Dock = DockStyle.Top;
            btnInventory.Location = new Point(0, 123);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(176, 41);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.Location = new Point(0, 82);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(176, 41);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.Location = new Point(0, 41);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(176, 41);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnCollapse
            // 
            btnCollapse.Dock = DockStyle.Top;
            btnCollapse.Location = new Point(0, 0);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(176, 41);
            btnCollapse.TabIndex = 0;
            btnCollapse.Text = "Collapse";
            btnCollapse.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(176, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(660, 100);
            pnlHeader.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(176, 100);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(660, 417);
            pnlContent.TabIndex = 2;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pbLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(176, 131);
            pnlLogo.TabIndex = 7;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = SystemColors.MenuHighlight;
            pbLogo.Dock = DockStyle.Fill;
            pbLogo.Image = Properties.Resources.Surf_Cafe_logo1;
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(176, 131);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnlMenuButtons
            // 
            pnlMenuButtons.Controls.Add(btnReports);
            pnlMenuButtons.Controls.Add(btnEmployees);
            pnlMenuButtons.Controls.Add(btnInventory);
            pnlMenuButtons.Controls.Add(btnMenu);
            pnlMenuButtons.Controls.Add(btnOrders);
            pnlMenuButtons.Controls.Add(btnCollapse);
            pnlMenuButtons.Dock = DockStyle.Top;
            pnlMenuButtons.Location = new Point(0, 131);
            pnlMenuButtons.Name = "pnlMenuButtons";
            pnlMenuButtons.Size = new Size(176, 250);
            pnlMenuButtons.TabIndex = 8;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 517);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlMenuButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnLogout;
        private Button btnReports;
        private Button btnEmployees;
        private Button btnInventory;
        private Button btnMenu;
        private Button btnOrders;
        private Button btnCollapse;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlMenuButtons;
        private Panel pnlLogo;
        private PictureBox pbLogo;
    }
}