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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            pnlSidebar = new Panel();
            btnLogout = new Button();
            pnlMenuButtons = new Panel();
            btnReports = new Button();
            btnEmployees = new Button();
            btnInventory = new Button();
            btnMenu = new Button();
            btnOrders = new Button();
            btnCollapse = new Button();
            pnlLogo = new Panel();
            pnlSubHeading = new Panel();
            pbLogo = new PictureBox();
            pnlHeader = new Panel();
            pnlActions = new Panel();
            btnGenerateReport = new Button();
            btnAddEmployee = new Button();
            btnAddCategory = new Button();
            btnAddOrder = new Button();
            btnAddStock = new Button();
            btnSaveChanges = new Button();
            btnBack = new Button();
            btnAddItem = new Button();
            lblSubHeading = new Label();
            pnlMainHeading = new Panel();
            lblMainHeading = new Label();
            pnlContent = new Panel();
            btnBack1 = new Button();
            pnlSidebar.SuspendLayout();
            pnlMenuButtons.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlHeader.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlMainHeading.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(22, 78, 99);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(pnlMenuButtons);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(234, 583);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(22, 78, 99);
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.Window;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleRight;
            btnLogout.Location = new Point(0, 538);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(234, 45);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlMenuButtons
            // 
            pnlMenuButtons.BackgroundImageLayout = ImageLayout.None;
            pnlMenuButtons.Controls.Add(btnReports);
            pnlMenuButtons.Controls.Add(btnEmployees);
            pnlMenuButtons.Controls.Add(btnInventory);
            pnlMenuButtons.Controls.Add(btnMenu);
            pnlMenuButtons.Controls.Add(btnOrders);
            pnlMenuButtons.Controls.Add(btnCollapse);
            pnlMenuButtons.Dock = DockStyle.Top;
            pnlMenuButtons.Location = new Point(0, 131);
            pnlMenuButtons.Margin = new Padding(0);
            pnlMenuButtons.Name = "pnlMenuButtons";
            pnlMenuButtons.Size = new Size(234, 364);
            pnlMenuButtons.TabIndex = 8;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(22, 78, 99);
            btnReports.BackgroundImageLayout = ImageLayout.None;
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = SystemColors.Window;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleRight;
            btnReports.Location = new Point(0, 295);
            btnReports.Margin = new Padding(0);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(234, 59);
            btnReports.TabIndex = 5;
            btnReports.TabStop = false;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseMnemonic = false;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(22, 78, 99);
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployees.ForeColor = SystemColors.Window;
            btnEmployees.Image = (Image)resources.GetObject("btnEmployees.Image");
            btnEmployees.ImageAlign = ContentAlignment.MiddleRight;
            btnEmployees.Location = new Point(0, 236);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(234, 59);
            btnEmployees.TabIndex = 4;
            btnEmployees.TabStop = false;
            btnEmployees.Text = "Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(22, 78, 99);
            btnInventory.Dock = DockStyle.Top;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = SystemColors.Window;
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageAlign = ContentAlignment.MiddleRight;
            btnInventory.Location = new Point(0, 177);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(234, 59);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(22, 78, 99);
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = SystemColors.Window;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleRight;
            btnMenu.Location = new Point(0, 118);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(234, 59);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.FromArgb(22, 78, 99);
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = SystemColors.Window;
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.MiddleRight;
            btnOrders.Location = new Point(0, 59);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(234, 59);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnCollapse
            // 
            btnCollapse.BackColor = Color.FromArgb(22, 78, 99);
            btnCollapse.Dock = DockStyle.Top;
            btnCollapse.FlatAppearance.BorderSize = 0;
            btnCollapse.FlatStyle = FlatStyle.Flat;
            btnCollapse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCollapse.ForeColor = SystemColors.Window;
            btnCollapse.Image = (Image)resources.GetObject("btnCollapse.Image");
            btnCollapse.ImageAlign = ContentAlignment.MiddleRight;
            btnCollapse.Location = new Point(0, 0);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(234, 59);
            btnCollapse.TabIndex = 0;
            btnCollapse.Text = "Collapse";
            btnCollapse.TextAlign = ContentAlignment.MiddleLeft;
            btnCollapse.UseVisualStyleBackColor = false;
            btnCollapse.Click += btnCollapse_Click;
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
            pbLogo.BackColor = Color.FromArgb(22, 78, 99);
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
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(14, 116, 144);
            pnlHeader.Controls.Add(pnlActions);
            pnlHeader.Controls.Add(lblSubHeading);
            pnlHeader.Controls.Add(pnlMainHeading);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(234, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(939, 131);
            pnlHeader.TabIndex = 1;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.FromArgb(14, 116, 144);
            pnlActions.Controls.Add(btnBack1);
            pnlActions.Controls.Add(btnGenerateReport);
            pnlActions.Controls.Add(btnAddEmployee);
            pnlActions.Controls.Add(btnAddCategory);
            pnlActions.Controls.Add(btnAddOrder);
            pnlActions.Controls.Add(btnAddStock);
            pnlActions.Controls.Add(btnSaveChanges);
            pnlActions.Controls.Add(btnBack);
            pnlActions.Controls.Add(btnAddItem);
            pnlActions.Dock = DockStyle.Right;
            pnlActions.Location = new Point(430, 68);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(509, 63);
            pnlActions.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(22, 78, 99);
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.ForeColor = SystemColors.Window;
            btnGenerateReport.Location = new Point(344, 6);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(153, 52);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Visible = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(22, 78, 99);
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.ForeColor = SystemColors.Window;
            btnAddEmployee.Location = new Point(344, 6);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(153, 52);
            btnAddEmployee.TabIndex = 5;
            btnAddEmployee.Text = "+ Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Visible = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.FromArgb(22, 78, 99);
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.ForeColor = SystemColors.Window;
            btnAddCategory.Location = new Point(344, 6);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(153, 52);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "+ Add Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Visible = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.AutoSize = true;
            btnAddOrder.BackColor = Color.FromArgb(22, 78, 99);
            btnAddOrder.FlatAppearance.BorderSize = 0;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.ForeColor = SystemColors.Window;
            btnAddOrder.Location = new Point(344, 6);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(153, 52);
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "+ New Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Visible = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnAddStock
            // 
            btnAddStock.BackColor = Color.FromArgb(22, 78, 99);
            btnAddStock.BackgroundImageLayout = ImageLayout.None;
            btnAddStock.FlatAppearance.BorderSize = 0;
            btnAddStock.FlatStyle = FlatStyle.Flat;
            btnAddStock.ForeColor = SystemColors.Window;
            btnAddStock.Location = new Point(13, 6);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(153, 52);
            btnAddStock.TabIndex = 2;
            btnAddStock.Text = "+ Add Stock";
            btnAddStock.UseVisualStyleBackColor = false;
            btnAddStock.Visible = false;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(22, 78, 99);
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.ForeColor = SystemColors.Window;
            btnSaveChanges.Location = new Point(178, 6);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(153, 52);
            btnSaveChanges.TabIndex = 3;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Visible = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = Color.FromArgb(22, 78, 99);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = SystemColors.Window;
            btnBack.Location = new Point(344, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 52);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back to all Orders";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(22, 78, 99);
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.ForeColor = SystemColors.Window;
            btnAddItem.Location = new Point(344, 5);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(153, 52);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "+ Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Visible = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = SystemColors.Window;
            lblSubHeading.Location = new Point(0, 71);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(415, 50);
            lblSubHeading.TabIndex = 0;
            lblSubHeading.Text = "Subheading >Eg Orders";
            lblSubHeading.TextAlign = ContentAlignment.MiddleCenter;
            lblSubHeading.Click += lblSubHeading_Click;
            // 
            // pnlMainHeading
            // 
            pnlMainHeading.Controls.Add(lblMainHeading);
            pnlMainHeading.Dock = DockStyle.Top;
            pnlMainHeading.Location = new Point(0, 0);
            pnlMainHeading.Name = "pnlMainHeading";
            pnlMainHeading.Size = new Size(939, 68);
            pnlMainHeading.TabIndex = 0;
            // 
            // lblMainHeading
            // 
            lblMainHeading.BackColor = Color.FromArgb(14, 116, 144);
            lblMainHeading.Dock = DockStyle.Top;
            lblMainHeading.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainHeading.ForeColor = SystemColors.Window;
            lblMainHeading.Location = new Point(0, 0);
            lblMainHeading.Name = "lblMainHeading";
            lblMainHeading.Size = new Size(939, 68);
            lblMainHeading.TabIndex = 0;
            lblMainHeading.Text = "Admin Dashboard";
            lblMainHeading.Click += lblMainHeading_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(234, 131);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(939, 452);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // btnBack1
            // 
            btnBack1.BackColor = Color.FromArgb(22, 78, 99);
            btnBack1.FlatAppearance.BorderSize = 0;
            btnBack1.FlatStyle = FlatStyle.Flat;
            btnBack1.ForeColor = SystemColors.Window;
            btnBack1.Location = new Point(178, 6);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(153, 52);
            btnBack1.TabIndex = 4;
            btnBack1.Text = "Back";
            btnBack1.UseVisualStyleBackColor = false;
            btnBack1.Visible = false;
            btnBack1.Click += btnBack1_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1173, 583);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += AdminDashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMenuButtons.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
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
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlLogo;
        private PictureBox pbLogo;
        private Panel pnlMainHeading;
        private Label lblMainHeading;
        private Label lblSubHeading;
        private Panel pnlSubHeading;
        private Panel pnlActions;
        private Button btnAddOrder;
        private Button btnAddEmployee;
        private Button btnGenerateReport;
        private Button btnSaveChanges;
        private Button btnAddStock;
        private Button btnAddCategory;
        private Button btnAddItem;
        private Button btnBack;
        internal Panel pnlMenuButtons;
        private Button btnCollapse;
        private Button btnBack1;
    }
}