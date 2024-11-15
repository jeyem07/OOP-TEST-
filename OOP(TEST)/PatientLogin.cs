using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace OOP_TEST_
{
    public partial class PatientLogin : Form
    {
        private readonly AuthenticationService _authenticationService;

        public PatientLogin()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        public class AuthenticationService
        {
            private readonly DatabaseConnection _databaseConnection;

            public AuthenticationService()
            {
                _databaseConnection = new DatabaseConnection();
            }

            public bool Authenticate(string email, string enteredPassword)
            {
                using (MySqlConnection conn = _databaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Password1 FROM tb_patient WHERE Email = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", email);
                        string storedHashedPassword = (string)cmd.ExecuteScalar();

                        if (storedHashedPassword != null)
                        {
                            return VerifyPassword(enteredPassword, storedHashedPassword);
                        }
                        return false;
                    }
                }
            }

            private bool VerifyPassword(string enteredPassword, string storedHashedPassword)
            {
                return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHashedPassword);
            }
        }

        public class DatabaseConnection
        {
            private readonly string _connectionString = "Server=127.0.0.1;Database=patient;User ID=root;Password=";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(_connectionString);
            }
        }

        private void Linklbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientRegister register = new PatientRegister();
            register.Show();
            this.Hide();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                PatientPass.PasswordChar = '\0';
                PatientPass.UseSystemPasswordChar = false;
            }
            else
            {
                PatientPass.PasswordChar = '●';
                PatientPass.UseSystemPasswordChar = true;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = PatientUsername.Text;
            string password = PatientPass.Text;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_authenticationService.Authenticate(email, password))
            {
                MessageBox.Show("Login successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PDashboard patientDashboard = new PDashboard();
                patientDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}