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
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var created = service.Register(username, password);

            if (!created)
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            MessageBox.Show("Account created successfully!");

            // back to login
            var login = new LoginForm(service);
            this.Hide();
            login.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var login = new LoginForm(service);
            this.Hide();
            login.Show();
        }
    }
}
