namespace GUIWIN
{
    partial class MyApplicationsForm
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

        private void InitializeComponent()
        {
            this.dgvApps = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApps
            // 
            this.dgvApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApps.Location = new System.Drawing.Point(25, 25);
            this.dgvApps.Name = "dgvApps";
            this.dgvApps.RowHeadersWidth = 51;
            this.dgvApps.RowTemplate.Height = 29;
            this.dgvApps.Size = new System.Drawing.Size(600, 300);
            this.dgvApps.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(250, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MyApplicationsForm
            // 
            this.ClientSize = new System.Drawing.Size(650, 420);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvApps);
            this.Name = "MyApplicationsForm";
            this.Text = "My Applications";
            this.Load += new System.EventHandler(this.MyApplicationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvApps;
        private System.Windows.Forms.Button btnBack;
    }
}
