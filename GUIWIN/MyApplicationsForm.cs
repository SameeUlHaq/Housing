using System;
using System.Windows.Forms;
using Housing.LogicLayers;
using Housing.Models;

namespace GUIWIN
{
    public partial class MyApplicationsForm : Form
    {
        private HousingService service;
        private User loggedUser;

        public MyApplicationsForm(HousingService service, User user)
        {
            InitializeComponent();
            this.service = service;
            this.loggedUser = user;
        }

        private void MyApplicationsForm_Load(object sender, EventArgs e)
        {
            dgvApps.DataSource = service.GetApplications(loggedUser.Id);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var main = new MainForm(service, loggedUser);
            main.Show();
            this.Hide();
        }
    }
}
