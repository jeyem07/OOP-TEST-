using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace OOP_TEST_
{
    public partial class DoctorLogin : Form
    {
        private UserAuthentication _userAuthentication;

        public DoctorLogin()
        {
            InitializeComponent();
            _userAuthentication = new UserAuthentication();
        }

        private void DoctorLoginBtn_Click(object sender, EventArgs e)
        {
            string username = DoctorUsername.Text;
            string password = DoctorPass.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isAuthenticated = _userAuthentication.ValidateDoctorCredentials(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PDashboard patientDashboard = new PDashboard();
                patientDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                DoctorPass.PasswordChar = '\0';
                DoctorPass.UseSystemPasswordChar = false;
            }
            else
            {
                DoctorPass.PasswordChar = '●';
                DoctorPass.UseSystemPasswordChar = true;
            }
        }
    }

    public class UserAuthentication
    {
        private readonly string _connectionString = "Server=127.0.0.1;Database=patient;User ID=root;Password=";

        public bool ValidateDoctorCredentials(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT Password1 FROM tb_doctor WHERE Email = @MDemail";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MDemail", username);
                    string storedHashedPassword = (string)cmd.ExecuteScalar();

                    return storedHashedPassword != null && VerifyPassword(password, storedHashedPassword);
                }
            }
        }

        private bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHashedPassword);
        }
    }
}
