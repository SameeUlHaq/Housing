using Housing.Models;
using Housing.LogicLayers;
using System;
using System.Windows.Forms;

namespace GUIWIN
{
    public partial class MainForm : Form
    {
        private HousingService service;
        private Student student;

        public MainForm(HousingService service, Student student)
        {
            InitializeComponent();
            this.service = service;
            this.student = student;
            lblWelcome.Text = $"Welcome, {student.Name}!";
        }


        private void btnRooms_Click(object sender, EventArgs e)
        {
            var appForm = new ApplicationForm(service, student);
            appForm.Show();
            this.Hide(); // om du vill gömma MainForm under tiden
        }


        private void btnApplications_Click(object sender, EventArgs e)
        {
            var myForm = new MyApplicationsForm(service, student);
            myForm.Show();
            this.Hide();
        }


    }
}
