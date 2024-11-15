using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace OOP_TEST_
{
    public partial class DoctorLogin : Form
    {
        private readonly AuthenticationService _authenticationService;

        public DoctorLogin()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        #region Authentication Service
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
                    string query = "SELECT Password1 FROM tb_doctor WHERE Email = @MDemail";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MDemail", email);
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
        #endregion

        #region Database Connection Class
        public class DatabaseConnection
        {
            private readonly string _connectionString = "Server=127.0.0.1;Database=patient;User ID=root;Password=";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(_connectionString);
            }
        }
        #endregion

        #region UI Event Handlers
        private void DoctorLoginBtn_Click(object sender, EventArgs e)
        {
            string email = DoctorUsername.Text;
            string password = DoctorPass.Text;

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
        #endregion
    }
}
