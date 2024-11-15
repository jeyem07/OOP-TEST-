using System;
using System.Windows.Forms;

namespace OOP_TEST_
{
    public partial class AdminLogin : Form
    {
        private AuthenticationService _authenticationService;

        public AdminLogin()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            string username = AdminUsername.Text;
            string password = AdminPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Credentials are Empty", "Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_authenticationService.Authenticate(username, password))
            {
                MessageBox.Show("Log in Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                AdminPass.PasswordChar = '\0';
                AdminPass.UseSystemPasswordChar = false;
            }
            else
            {
                AdminPass.PasswordChar = '●';
                AdminPass.UseSystemPasswordChar = true;
            }
        }
    }

    public class AuthenticationService
    {
        public bool Authenticate(string username, string password)
        {
            return username == "admin" && password == "admin123";
        }
    }
}
