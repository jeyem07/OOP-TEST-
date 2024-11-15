using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using BCrypt.Net;

namespace OOP_TEST_
{
    public partial class PatientRegister : Form
    {
        private readonly RegistrationService _registrationService;

        public PatientRegister()
        {
            InitializeComponent();
            _registrationService = new RegistrationService();
        }

        public class RegistrationService
        {
            private readonly DatabaseConnection _databaseConnection;

            public RegistrationService()
            {
                _databaseConnection = new DatabaseConnection();
            }

            public string HashPassword(string password)
            {
                return BCrypt.Net.BCrypt.HashPassword(password);
            }

            public bool RegisterPatient(string firstName, string lastName, string email, string contactNumber, string password, string hashedPassword)
            {
                using (MySqlConnection conn = _databaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO tb_patient (Firstname, Lastname, Email, ContactNumber, Password, password1) VALUES (@Firstname, @Lastname, @Email, @ContactNumber, @Password, @Password1)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Firstname", firstName);
                        cmd.Parameters.AddWithValue("@Lastname", lastName);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Password1", hashedPassword);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            return true;
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            return false;
                        }
                    }
                }
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
            PatientLogin login = new PatientLogin();
            login.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PatientFN.Text) || String.IsNullOrEmpty(PatientLN.Text) || String.IsNullOrEmpty(PatientNum.Text) || String.IsNullOrEmpty(PatientPass.Text) || String.IsNullOrEmpty(PatientConfirmPass.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PatientPass.Text != PatientConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            string hashedPassword = _registrationService.HashPassword(PatientPass.Text);

            bool success = _registrationService.RegisterPatient(PatientFN.Text, PatientLN.Text, PatientEmail.Text, PatientNum.Text, PatientPass.Text, hashedPassword);

            if (success)
            {
                MessageBox.Show("Registration successful!");
                PatientLogin patientLogin = new PatientLogin();
                patientLogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }
    }
}
