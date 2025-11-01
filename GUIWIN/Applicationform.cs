using System;
using System.Windows.Forms;
using Housing.LogicLayers;
using Housing.Models;

namespace GUIWIN
{
    public partial class ApplicationForm : Form
    {
        private HousingService service;
        private Student loggedStudent;

        public ApplicationForm(HousingService service, Student student)
        {
            InitializeComponent();
            this.service = service;
            this.loggedStudent = student;
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            // load available rooms
            dgvRooms.DataSource = service.GetAvailableRooms();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow == null)
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            var room = dgvRooms.CurrentRow.DataBoundItem as Room;

            if (room == null)
            {
                MessageBox.Show("No room selected.");
                return;
            }

            bool success = service.ApplyForRoom(loggedStudent.Id, room.Id);

            if (success)
            {
                MessageBox.Show("Application sent!");

                // refresh room list
                dgvRooms.DataSource = service.GetAvailableRooms();
            }
            else
            {
                MessageBox.Show("Room is not available.");
            }
        }
    }
}
