using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Data;

namespace OOP_TEST_
{
    public partial class PatientLogin : Form
    {
        private readonly PatientRepository _patientRepository;

        public PatientLogin()
        {
            InitializeComponent();
            _patientRepository = new PatientRepository();
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
                PatientPass.UseSystemPasswordChar = false;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = PatientUsername.Text;
            string password = PatientPass.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isAuthenticated = _patientRepository.VerifyUser(username, password);

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
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }

    public class PatientRepository
    {
        private readonly string _connectionString = "Server=127.0.0.1;Database=patient;User ID=root;Password=";

        public bool VerifyUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT Password1 FROM tb_patient WHERE Username = @Username";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    string storedHashedPassword = (string)cmd.ExecuteScalar();

                    if (storedHashedPassword != null && VerifyPassword(password, storedHashedPassword))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHashedPassword);
        }
    }
}
