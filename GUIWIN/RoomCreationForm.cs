using System;
using System.Windows.Forms;
using Housing.LogicLayers;
using Housing.Models;

namespace GUIWIN
{
    public partial class RoomCreationForm : Form
    {
        private HousingService service;
        private Admin admin; // THE LOGGED IN ADMIN

        public RoomCreationForm(HousingService service, Admin admin)
        {
            InitializeComponent();
            this.service = service;
            this.admin = admin;
        }

        private void RoomCreationForm_Load(object sender, EventArgs e)
        {
            RefreshRoomList();
        }

        private void RefreshRoomList()
        {
            dgvRooms.DataSource = null;
            dgvRooms.DataSource = service.GetAllRooms();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            var form = new RoomEditForm(service, null);
            form.ShowDialog();
            RefreshRoomList();
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow == null)
            {
                MessageBox.Show("Select a room to edit.");
                return;
            }

            var room = dgvRooms.CurrentRow.DataBoundItem as Room;

            var form = new RoomEditForm(service, room);
            form.ShowDialog();
            RefreshRoomList();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow == null)
            {
                MessageBox.Show("Select a room to delete.");
                return;
            }

            var room = dgvRooms.CurrentRow.DataBoundItem as Room;
            service.DeleteRoom(room.Id);
            RefreshRoomList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminMain = new AdminMainForm(service, admin);
            adminMain.Show();
            this.Hide();
        }
    }
}
