using System;
using System.Windows.Forms;
using Housing.LogicLayers;
using Housing.Models;

namespace GUIWIN
{
    public partial class ApplicationForm : Form
    {
        private HousingService service;
        private Student? loggedStudent;
        private Admin? loggedAdmin;

        public ApplicationForm(HousingService service, User user)
        {
            InitializeComponent();
            this.service = service;
            this.loggedStudent = user as Student;
            this.loggedAdmin = user as Admin;
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            dgvRooms.DataSource = service.GetAvailableRooms();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // ADMIN CAN'T APPLY
            if (loggedAdmin != null)
            {
                MessageBox.Show("Only students can apply for rooms.");
                return;
            }

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

            bool success = service.ApplyForRoom(loggedStudent!.Id, room.Id);

            if (success)
            {
                MessageBox.Show("Application sent!");
                dgvRooms.DataSource = service.GetAvailableRooms();
            }
            else
            {
                MessageBox.Show("Room is not available.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (loggedAdmin != null)
            {
                var adminForm = new AdminMainForm(service, loggedAdmin);
                adminForm.Show();
                this.Hide();
            }
            else
            {
                var main = new MainForm(service, loggedStudent!);
                main.Show();
                this.Hide();
            }
        }
    }
}
