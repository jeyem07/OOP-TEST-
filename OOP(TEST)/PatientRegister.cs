using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace OOP_TEST_
{
    public partial class PatientRegister : Form
    {
        private string connectionstring = "Server=127.0.0.1; Database=patient;User ID=root;Password=";

        public PatientRegister()
        {
            InitializeComponent();
        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
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
                MessageBox.Show("Please fill out all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PatientPass.Text != PatientConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            string hashedPassword = HashPassword(PatientPass.Text);

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "INSERT INTO patient123 (Firstname, Lastname, Email, ContactNumber, Password) VALUES (@Firstname, @Lastname, @Username, @ContactNumber,  @Password)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", PatientEmail.Text);
                    cmd.Parameters.AddWithValue("@Firstname", PatientFN.Text);
                    cmd.Parameters.AddWithValue("@Lastname", PatientLN.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", PatientNum.Text);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");

                        PatientLogin patientLogin = new PatientLogin();
                        patientLogin.Show();
                        this.Hide();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
