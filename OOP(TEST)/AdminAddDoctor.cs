using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OOP_TEST_
{
    public partial class AdminAddDoctor : Form
    {
        private readonly DoctorService _doctorService;

        public AdminAddDoctor()
        {
            InitializeComponent();
            string connectionString = "Server=127.0.0.1; Database=patient; User ID=root; Password=";
            _doctorService = new DoctorService(connectionString);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDBtnAddDoctor1_Click(object sender, EventArgs e)
        {
            if (!_doctorService.ValidateInputs(
                MDFirstName.Text,
                MDLastName.Text,
                MDEmail.Text,
                MDPassword.Text,
                MDConfirmPassword.Text,
                MDConsultationFee.Text))
            {
                return;
            }

            try
            {
                _doctorService.RegisterDoctor(
                    MDFirstName.Text,
                    MDLastName.Text,
                    MDEmail.Text,
                    MDPassword.Text,
                    MDConsultationFee.Text);

                MessageBox.Show("Registration successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class DoctorService
    {
        private readonly string _connectionString;

        public DoctorService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool ValidateInputs(string firstName, string lastName, string email, string password, string confirmPassword, string consultationFee)
        {
            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(consultationFee))
            {
                MessageBox.Show("Please fill out all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void RegisterDoctor(string firstName, string lastName, string email, string password, string consultationFee)
        {
            string hashedPassword = HashPassword(password);

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO tb_doctor (Firstname, Lastname, Email, Consultationfee, Password)
                    VALUES (@MDFirstName, @MDLastName, @MDEmail, @MDConsultationFee, @PasswordHash)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MDFirstName", firstName);
                    cmd.Parameters.AddWithValue("@MDLastName", lastName);
                    cmd.Parameters.AddWithValue("@MDEmail", email);
                    cmd.Parameters.AddWithValue("@MDConsultationFee", consultationFee);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
