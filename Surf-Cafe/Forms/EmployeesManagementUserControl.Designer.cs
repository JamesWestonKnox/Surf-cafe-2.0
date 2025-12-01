namespace Surf_Cafe.Forms
{
    partial class EmployeesManagementUserControl
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
            flpEmployees = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpEmployees
            // 
            flpEmployees.Dock = DockStyle.Fill;
            flpEmployees.Location = new Point(0, 0);
            flpEmployees.Name = "flpEmployees";
            flpEmployees.Size = new Size(778, 533);
            flpEmployees.TabIndex = 0;
            // 
            // EmployeesManagementUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpEmployees);
            Name = "EmployeesManagementUserControl";
            Size = new Size(778, 533);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpEmployees;
    }
}
