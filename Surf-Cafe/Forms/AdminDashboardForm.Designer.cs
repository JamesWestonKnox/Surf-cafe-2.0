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
            pnlMenuButtons = new Panel();
            btnReports = new Button();
            btnEmployees = new Button();
            btnInventory = new Button();
            btnMenu = new Button();
            btnOrders = new Button();
            btnCollapse = new Button();
            btnLogout = new Button();
            pnlLogo = new Panel();
            pbLogo = new PictureBox();
            pnlHeader = new Panel();
            pnlContent = new Panel();
            pnlMainHeading = new Panel();
            lblMainHeading = new Label();
            lblSubHeading = new Label();
            pnlSubHeading = new Panel();
            pnlActions = new Panel();
            pnlSidebar.SuspendLayout();
            pnlMenuButtons.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlHeader.SuspendLayout();
            pnlMainHeading.SuspendLayout();
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
            pnlSidebar.Size = new Size(234, 634);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += panel1_Paint;
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
            pnlMenuButtons.Size = new Size(234, 364);
            pnlMenuButtons.TabIndex = 8;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.Location = new Point(0, 295);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(234, 59);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.Location = new Point(0, 236);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(234, 59);
            btnEmployees.TabIndex = 4;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.Dock = DockStyle.Top;
            btnInventory.Location = new Point(0, 177);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(234, 59);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.Location = new Point(0, 118);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(234, 59);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.Location = new Point(0, 59);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(234, 59);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnCollapse
            // 
            btnCollapse.Dock = DockStyle.Top;
            btnCollapse.ImageAlign = ContentAlignment.MiddleRight;
            btnCollapse.Location = new Point(0, 0);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(234, 59);
            btnCollapse.TabIndex = 0;
            btnCollapse.Text = "Collapse";
            btnCollapse.TextAlign = ContentAlignment.MiddleLeft;
            btnCollapse.UseVisualStyleBackColor = true;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Location = new Point(0, 589);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(234, 45);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
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
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pnlActions);
            pnlHeader.Controls.Add(lblSubHeading);
            pnlHeader.Controls.Add(pnlMainHeading);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(234, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(785, 131);
            pnlHeader.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(234, 131);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(785, 503);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // pnlMainHeading
            // 
            pnlMainHeading.Controls.Add(lblMainHeading);
            pnlMainHeading.Dock = DockStyle.Top;
            pnlMainHeading.Location = new Point(0, 0);
            pnlMainHeading.Name = "pnlMainHeading";
            pnlMainHeading.Size = new Size(785, 68);
            pnlMainHeading.TabIndex = 0;
            // 
            // lblMainHeading
            // 
            lblMainHeading.Dock = DockStyle.Top;
            lblMainHeading.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainHeading.Location = new Point(0, 0);
            lblMainHeading.Name = "lblMainHeading";
            lblMainHeading.Size = new Size(785, 68);
            lblMainHeading.TabIndex = 0;
            lblMainHeading.Text = "Admin Dashboard";
            lblMainHeading.Click += lblMainHeading_Click;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.Location = new Point(0, 71);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(415, 50);
            lblSubHeading.TabIndex = 0;
            lblSubHeading.Text = "Subheading >Eg Orders";
            lblSubHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSubHeading
            // 
            pnlSubHeading.Location = new Point(234, 71);
            pnlSubHeading.Name = "pnlSubHeading";
            pnlSubHeading.Size = new Size(785, 60);
            pnlSubHeading.TabIndex = 1;
            // 
            // pnlActions
            // 
            pnlActions.Dock = DockStyle.Right;
            pnlActions.Location = new Point(478, 68);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(307, 63);
            pnlActions.TabIndex = 1;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 634);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlMenuButtons.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMainHeading.ResumeLayout(false);
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
        private Panel pnlMainHeading;
        private Label lblMainHeading;
        private Label lblSubHeading;
        private Panel pnlSubHeading;
        private Panel pnlActions;
    }
}