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
            btnLogout = new Button();
            pnlMenuButtons = new Panel();
            btnMenu = new Button();
            btnOrders = new Button();
            btnCollapse = new Button();
            pnlLogo = new Panel();
            pnlSubHeading = new Panel();
            pbLogo = new PictureBox();
            pnlHeader = new Panel();
            pnlActions = new Panel();
            btnAddOrder = new Button();
            btnAddCategory = new Button();
            btnSaveChanges = new Button();
            btnBack = new Button();
            btnAddItem = new Button();
            lblSubHeading = new Label();
            pnlMainHeading = new Panel();
            lblMainHeading = new Label();
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
            pnlSidebar.BackColor = Color.FromArgb(22, 78, 99);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(pnlMenuButtons);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(234, 579);
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
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleRight;
            btnLogout.Location = new Point(0, 534);
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
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(22, 78, 99);
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = SystemColors.Window;
            btnMenu.Image = Properties.Resources.restaurant1;
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
            btnCollapse.Image = Properties.Resources.menu1;
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
            pnlHeader.Size = new Size(747, 131);
            pnlHeader.TabIndex = 1;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.FromArgb(14, 116, 144);
            pnlActions.Controls.Add(btnAddOrder);
            pnlActions.Controls.Add(btnAddCategory);
            pnlActions.Controls.Add(btnSaveChanges);
            pnlActions.Controls.Add(btnBack);
            pnlActions.Controls.Add(btnAddItem);
            pnlActions.Dock = DockStyle.Right;
            pnlActions.Location = new Point(238, 68);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(509, 63);
            pnlActions.TabIndex = 1;
            // 
            // btnAddOrder
            // 
            btnAddOrder.AutoSize = true;
            btnAddOrder.BackColor = Color.FromArgb(22, 78, 99);
            btnAddOrder.FlatAppearance.BorderSize = 0;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.ForeColor = SystemColors.Window;
            btnAddOrder.Location = new Point(344, 5);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(153, 52);
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "+ New Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Visible = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.FromArgb(22, 78, 99);
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.ForeColor = SystemColors.Window;
            btnAddCategory.Location = new Point(344, 5);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(153, 52);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "+ Add Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Visible = false;
            btnAddCategory.Click += btnAddCategory_Click;
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
            pnlMainHeading.Size = new Size(747, 68);
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
            lblMainHeading.Size = new Size(747, 68);
            lblMainHeading.TabIndex = 0;
            lblMainHeading.Text = "Employee Dashboard";
            lblMainHeading.Click += lblMainHeading_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(234, 131);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(747, 448);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // EmployeeDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 579);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeDashboardForm";
            Text = "EmployeeDashboard";
            Load += EmployeeDashboardForm_Load;
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
    }
}