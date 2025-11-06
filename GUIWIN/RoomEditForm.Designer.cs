namespace GUIWIN
{
    partial class RoomEditForm
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
            lblRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblBuildingName = new Label();
            txtBuildingName = new TextBox();
            lblBuildingLocation = new Label();
            txtBuildingLocation = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(20, 20);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(86, 15);
            lblRoomNumber.TabIndex = 0;
            lblRoomNumber.Text = "Room Number:";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(130, 17);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(200, 23);
            txtRoomNumber.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(20, 60);
            lblType.Name = "lblType";
            lblType.Size = new Size(36, 15);
            lblType.TabIndex = 2;
            lblType.Text = "Type:";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Location = new Point(130, 57);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(200, 23);
            cmbType.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(130, 97);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 5;
            // 
            // lblBuildingName
            // 
            lblBuildingName.AutoSize = true;
            lblBuildingName.Location = new Point(20, 140);
            lblBuildingName.Name = "lblBuildingName";
            lblBuildingName.Size = new Size(89, 15);
            lblBuildingName.TabIndex = 6;
            lblBuildingName.Text = "Building Name:";
            // 
            // txtBuildingName
            // 
            txtBuildingName.Location = new Point(130, 137);
            txtBuildingName.Name = "txtBuildingName";
            txtBuildingName.Size = new Size(200, 23);
            txtBuildingName.TabIndex = 7;
            // 
            // lblBuildingLocation
            // 
            lblBuildingLocation.AutoSize = true;
            lblBuildingLocation.Location = new Point(20, 180);
            lblBuildingLocation.Name = "lblBuildingLocation";
            lblBuildingLocation.Size = new Size(104, 15);
            lblBuildingLocation.TabIndex = 8;
            lblBuildingLocation.Text = "Building Location:";
            // 
            // txtBuildingLocation
            // 
            txtBuildingLocation.Location = new Point(130, 177);
            txtBuildingLocation.Name = "txtBuildingLocation";
            txtBuildingLocation.Size = new Size(200, 23);
            txtBuildingLocation.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 30);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(240, 220);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // RoomEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 265);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBuildingLocation);
            Controls.Add(lblBuildingLocation);
            Controls.Add(txtBuildingName);
            Controls.Add(lblBuildingName);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(txtRoomNumber);
            Controls.Add(lblRoomNumber);
            Name = "RoomEditForm";
            Text = "Room Editor";
            Load += RoomEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomNumber;
        private TextBox txtRoomNumber;
        private Label lblType;
        private ComboBox cmbType;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblBuildingName;
        private TextBox txtBuildingName;
        private Label lblBuildingLocation;
        private TextBox txtBuildingLocation;
        private Button btnSave;
        private Button btnCancel;
    }
}
