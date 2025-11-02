using System;
using System.Windows.Forms;
using Housing.LogicLayers;

namespace GUIWIN
{
    public partial class RegisterForm : Form
    {
        private HousingService service;

        public RegisterForm(HousingService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter username and password.");
                return;
            }

            bool success = service.Register(username, password);

            if (!success)
            {
                MessageBox.Show("Username already exists!");
                return;
            }

            MessageBox.Show("Account created! Now log in.");

            var loginForm = new LoginForm(service);
            loginForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(service);
            loginForm.Show();
            this.Hide();
        }
    }
}
