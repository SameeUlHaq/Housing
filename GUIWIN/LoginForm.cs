using System;
using System.Windows.Forms;
using Housing.LogicLayers;
using Housing.Models;

namespace GUIWIN
{
    public partial class LoginForm : Form
    {
        private HousingService service;

        public LoginForm(HousingService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = service.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("Wrong username or password!");
                return;
            }

            // open main form
            var main = new MainForm(service, user);
            main.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var reg = new RegisterForm(service);
            reg.Show();
            this.Hide();
        }
    }
}
