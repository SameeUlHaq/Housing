using System;
using System.Windows.Forms;
using Housing.LogicLayers;
using Housing.Models;

namespace GUIWIN
{
    public partial class AdminMainForm : Form
    {
        private HousingService service;
        private Admin admin;

        public AdminMainForm(HousingService service, Admin admin)
        {
            InitializeComponent();
            this.service = service;
            this.admin = admin;
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            // open room manager and pass the LOGGED IN ADMIN
            var form = new RoomCreationForm(service, admin);
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var login = new LoginForm(service);
            login.Show();
            this.Hide();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
