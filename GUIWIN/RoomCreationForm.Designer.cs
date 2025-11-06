namespace GUIWIN
{
    partial class RoomCreationForm
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
            dgvRooms = new DataGridView();
            btnAddRoom = new Button();
            btnEditRoom = new Button();
            btnDeleteRoom = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(12, 12);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowTemplate.Height = 29;
            dgvRooms.Size = new Size(760, 350);
            dgvRooms.TabIndex = 0;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Location = new Point(12, 380);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(150, 30);
            btnAddRoom.TabIndex = 1;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnEditRoom
            // 
            btnEditRoom.Location = new Point(200, 380);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(150, 30);
            btnEditRoom.TabIndex = 2;
            btnEditRoom.Text = "Edit Room";
            btnEditRoom.UseVisualStyleBackColor = true;
            btnEditRoom.Click += btnEditRoom_Click;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.Location = new Point(388, 380);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(150, 30);
            btnDeleteRoom.TabIndex = 3;
            btnDeleteRoom.Text = "Delete Room";
            btnDeleteRoom.UseVisualStyleBackColor = true;
            btnDeleteRoom.Click += btnDeleteRoom_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(622, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 30);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // RoomCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnEditRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(dgvRooms);
            Name = "RoomCreationForm";
            Text = "Manage Rooms";
            Load += RoomCreationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRooms;
        private Button btnAddRoom;
        private Button btnEditRoom;
        private Button btnDeleteRoom;
        private Button btnBack;
    }
}
