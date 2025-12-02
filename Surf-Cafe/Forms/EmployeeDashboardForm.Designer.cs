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
            btnMenu = new Button();
            btnOrders = new Button();
            btnCollapse = new Button();
            btnLogout = new Button();
            pnlLogo = new Panel();
            pnlSubHeading = new Panel();
            pbLogo = new PictureBox();
            btnBack = new Button();
            btnAddOrder = new Button();
            btnRemoveOrder = new Button();
            btnSaveChanges = new Button();
            btnAddItem = new Button();
            pnlHeader = new Panel();
            pnlActions = new Panel();
            lblSubHeading = new Label();
            pnlMainHeading = new Panel();
            lblMainHeading = new Label();
            btnAddCategory = new Button();
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
            pnlSidebar.Size = new Size(234, 579);
            pnlSidebar.TabIndex = 8;
            // 
            // pnlMenuButtons
            // 
            pnlMenuButtons.Controls.Add(btnMenu);
            pnlMenuButtons.Controls.Add(btnOrders);
            pnlMenuButtons.Controls.Add(btnCollapse);
            pnlMenuButtons.Dock = DockStyle.Top;
            pnlMenuButtons.Location = new Point(0, 131);
            pnlMenuButtons.Name = "pnlMenuButtons";
            pnlMenuButtons.Size = new Size(234, 364);
            pnlMenuButtons.TabIndex = 8;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.Location = new Point(0, 242);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(234, 121);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.Location = new Point(0, 121);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(234, 121);
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
            btnCollapse.Size = new Size(234, 121);
            btnCollapse.TabIndex = 0;
            btnCollapse.Text = "Collapse";
            btnCollapse.UseVisualStyleBackColor = true;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Location = new Point(0, 528);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(234, 51);
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
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Location = new Point(344, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 52);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back to all Orders";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Visible = false;
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
            // btnRemoveOrder
            // 
            btnRemoveOrder.Location = new Point(0, 0);
            btnRemoveOrder.Name = "btnRemoveOrder";
            btnRemoveOrder.Size = new Size(75, 23);
            btnRemoveOrder.TabIndex = 0;
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
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(344, 8);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(153, 52);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "+ Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Visible = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pnlActions);
            pnlHeader.Controls.Add(lblSubHeading);
            pnlHeader.Controls.Add(pnlMainHeading);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(234, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(747, 131);
            pnlHeader.TabIndex = 11;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnAddOrder);
            pnlActions.Dock = DockStyle.Right;
            pnlActions.Location = new Point(238, 68);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(509, 63);
            pnlActions.TabIndex = 2;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.Location = new Point(0, 71);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(202, 50);
            lblSubHeading.TabIndex = 1;
            lblSubHeading.Text = "Dashboard";
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
            lblMainHeading.Dock = DockStyle.Top;
            lblMainHeading.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainHeading.Location = new Point(0, 0);
            lblMainHeading.Name = "lblMainHeading";
            lblMainHeading.Size = new Size(747, 68);
            lblMainHeading.TabIndex = 0;
            lblMainHeading.Text = "Employee Dashboard";
            lblMainHeading.Click += lblMainHeading_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(344, 8);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(153, 52);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "+ Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Visible = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(234, 131);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(747, 448);
            pnlContent.TabIndex = 10;
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
        private Panel pnlMenuButtons;
        private Button btnMenu;
        private Button btnOrders;
        private Button btnCollapse;
        private Button btnLogout;
        private Panel pnlLogo;
        private Panel pnlSubHeading;
        private PictureBox pbLogo;
        private Panel pnlHeader;
        private Label lblMainHeading;
        private Panel pnlContent;
        private Label lblSubHeading;
        private Panel pnlActions;
        private Button btnAddOrder;
        private Panel pnlMainHeading;
        private Button btnRemoveOrder;
        private Button btnBack;
        private Button btnAddItem;
        private Button btnAddCategory;
        private Button btnSaveChanges;
    }
}