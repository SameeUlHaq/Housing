using System;
using System.Windows.Forms;
using Housing.LogicLayers;
using Housing.Models;

namespace GUIWIN
{
    public partial class MyApplicationsForm : Form
    {
        private HousingService service;
        private Student student;

        public MyApplicationsForm(HousingService service, Student student)
        {
            InitializeComponent();
            this.service = service;
            this.student = student;
        }

        private void MyApplicationsForm_Load(object sender, EventArgs e)
        {
            dgvApps.DataSource = service.GetApplications(student.Id);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var main = new MainForm(service, student);
            main.Show();
            this.Hide();
        }
    }
}
