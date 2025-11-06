using System;
using System.Windows.Forms;
using Housing.LogicLayers;
using Housing.Models;

namespace GUIWIN
{
    public partial class RoomEditForm : Form
    {
        private HousingService service;
        private Room editingRoom;

        public RoomEditForm(HousingService service, Room room)
        {
            InitializeComponent();
            this.service = service;
            this.editingRoom = room; // null = create, not null = edit
        }

        private void RoomEditForm_Load(object sender, EventArgs e)
        {
            // fill dropdowns
            cmbType.DataSource = Enum.GetValues(typeof(RoomType));
            cmbStatus.DataSource = Enum.GetValues(typeof(RoomStatus));

            if (editingRoom != null)
            {
                txtRoomNumber.Text = editingRoom.Number;
                cmbType.SelectedItem = editingRoom.Type;
                cmbStatus.SelectedItem = editingRoom.Status;
                txtBuildingName.Text = editingRoom.Building.Name;
              
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string number = txtRoomNumber.Text.Trim();
            RoomType type = (RoomType)cmbType.SelectedItem;
            RoomStatus status = (RoomStatus)cmbStatus.SelectedItem;
            string buildingName = txtBuildingName.Text.Trim();
            string buildingLocation = txtBuildingLocation.Text.Trim();

            // generate building id automatically (just use count of rooms +1)
            int buildingId = service.GetAllRooms().Count + 1;

            var building = new Building(buildingId, buildingName, buildingLocation);

            if (editingRoom == null)
            {
                service.CreateRoom(number, type, status, building);
            }
            else
            {
                service.UpdateRoom(editingRoom.Id, number, type, status, building);
            }

            MessageBox.Show("Room saved!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
