namespace GUIWIN
{
    partial class AdminMainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnManageRooms = new Button();
            btnLogout = new Button();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // btnManageRooms
            // 
            btnManageRooms.Location = new Point(52, 60);
            btnManageRooms.Margin = new Padding(3, 2, 3, 2);
            btnManageRooms.Name = "btnManageRooms";
            btnManageRooms.Size = new Size(175, 26);
            btnManageRooms.TabIndex = 0;
            btnManageRooms.Text = "Manage Rooms";
            btnManageRooms.UseVisualStyleBackColor = true;
            btnManageRooms.Click += btnManageRooms_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(52, 98);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(175, 26);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(52, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(96, 15);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome Admin";
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 150);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(btnManageRooms);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminMainForm";
            Text = "AdminMainForm";
            Load += AdminMainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnManageRooms;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
    }
}
