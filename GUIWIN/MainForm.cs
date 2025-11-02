using Housing.LogicLayers;
using Housing.Models;
using System;
using System.Windows.Forms;

namespace GUIWIN
{
    public partial class MainForm : Form
    {
        private HousingService service;
        private User user;

        public MainForm(HousingService service, User user)
        {
            InitializeComponent();
            this.service = service;
            this.user = user;
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            var student = user as Student;
            if (student == null)
            {
                MessageBox.Show("Only students can apply for rooms.");
                return;
            }

            var appForm = new ApplicationForm(service, student);
            appForm.Show();
            this.Hide();
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            var student = user as Student;
            if (student == null)
            {
                MessageBox.Show("Only students can view their applications.");
                return;
            }

            var myForm = new MyApplicationsForm(service, student);
            myForm.Show();
            this.Hide();
        }
    }
}
