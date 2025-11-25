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
            pnlSubHeading = new Panel();
            pbLogo = new PictureBox();
            pnlHeader = new Panel();
            pnlActions = new Panel();
            btnAddStock = new Button();
            btnAddOrder = new Button();
            btnAddCategory = new Button();
            btnAddEmployee = new Button();
            btnSaveChanges = new Button();
            lblSubHeading = new Label();
            pnlMainHeading = new Panel();
            lblMainHeading = new Label();
            btnGenerateReport = new Button();
            pnlContent = new Panel();
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
            pnlSidebar.Controls.Add(pnlMenuButtons);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(234, 634);
            pnlSidebar.TabIndex = 0;
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
            btnReports.Click += btnReports_Click;
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
            btnEmployees.Click += btnEmployees_Click;
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
            btnInventory.Click += btnInventory_Click;
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
            btnMenu.Click += btnMenu_Click;
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
            btnOrders.Click += btnOrders_Click;
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
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pnlActions);
            pnlHeader.Controls.Add(lblSubHeading);
            pnlHeader.Controls.Add(pnlMainHeading);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(234, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(994, 131);
            pnlHeader.TabIndex = 1;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnGenerateReport);
            pnlActions.Controls.Add(btnAddStock);
            pnlActions.Controls.Add(btnAddOrder);
            pnlActions.Controls.Add(btnAddCategory);
            pnlActions.Controls.Add(btnAddEmployee);
            pnlActions.Controls.Add(btnSaveChanges);
            pnlActions.Dock = DockStyle.Right;
            pnlActions.Location = new Point(485, 68);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(509, 63);
            pnlActions.TabIndex = 1;
            // 
            // btnAddStock
            // 
            btnAddStock.Location = new Point(13, 6);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(153, 52);
            btnAddStock.TabIndex = 2;
            btnAddStock.Text = "+ Add Stock";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Visible = false;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.AutoSize = true;
            btnAddOrder.Location = new Point(344, 6);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(153, 52);
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "+ New Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Visible = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(344, 6);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(153, 52);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "+ Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Visible = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(344, 6);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(153, 52);
            btnAddEmployee.TabIndex = 5;
            btnAddEmployee.Text = "+ Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Visible = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(178, 6);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(153, 52);
            btnSaveChanges.TabIndex = 3;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Visible = false;
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
            // pnlMainHeading
            // 
            pnlMainHeading.Controls.Add(lblMainHeading);
            pnlMainHeading.Dock = DockStyle.Top;
            pnlMainHeading.Location = new Point(0, 0);
            pnlMainHeading.Name = "pnlMainHeading";
            pnlMainHeading.Size = new Size(994, 68);
            pnlMainHeading.TabIndex = 0;
            // 
            // lblMainHeading
            // 
            lblMainHeading.Dock = DockStyle.Top;
            lblMainHeading.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainHeading.Location = new Point(0, 0);
            lblMainHeading.Name = "lblMainHeading";
            lblMainHeading.Size = new Size(994, 68);
            lblMainHeading.TabIndex = 0;
            lblMainHeading.Text = "Admin Dashboard";
            lblMainHeading.Click += lblMainHeading_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(344, 6);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(153, 52);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Visible = false;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(234, 131);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(994, 503);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 634);
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
        private Button btnAddOrder;
        private Button btnAddEmployee;
        private Button btnGenerateReport;
        private Button btnSaveChanges;
        private Button btnAddStock;
        private Button btnAddCategory;
    }
}