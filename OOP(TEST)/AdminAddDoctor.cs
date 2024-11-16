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
using MySql.Data.MySqlClient;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;




namespace OOP_TEST_
{
    public partial class AdminAddDoctor : Form
    {
        private string connectionstring = "Server=127.0.0.1; Database=patient;User ID=root;Password=";
        public AdminAddDoctor()
        {
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }



        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Doctor
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
            public string ConsultationFee { get; set; }

            public bool CheckInputs()
            {
                if (string.IsNullOrEmpty(FirstName) ||
                    string.IsNullOrEmpty(LastName) ||
                    string.IsNullOrEmpty(Email) ||
                    string.IsNullOrEmpty(Password) ||
                    string.IsNullOrEmpty(ConfirmPassword) ||
                    string.IsNullOrEmpty(ConsultationFee))
                {
                    MessageBox.Show("Please fill out all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (Password != ConfirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
        }
        private void MDBtnAddDoctor1_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor
            {
                FirstName = MDFirstName.Text,
                LastName = MDLastName.Text,
                Email = MDEmail.Text,
                Password = MDPassword.Text,
                ConfirmPassword = MDConfirmPassword.Text,
                ConsultationFee = MDConsultationFee.Text
            };

            if (!doctor.CheckInputs())
            {
                return;
            }

            string hashedPassword = HashPassword(doctor.Password);

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "INSERT INTO tb_doctor (Firstname, Lastname, Username, Consultationfee, Password, password1) " +
                               "VALUES (@MDFirstname, @MDLastname, @MDEmail, @MDConsultationfee, @MDPassword, @Password1)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MDFirstname", doctor.FirstName);
                    cmd.Parameters.AddWithValue("@MDLastname", doctor.LastName);
                    cmd.Parameters.AddWithValue("@MDEmail", doctor.Email);
                    cmd.Parameters.AddWithValue("@MDConsultationfee", doctor.ConsultationFee);
                    cmd.Parameters.AddWithValue("@MDPassword", doctor.Password);
                    cmd.Parameters.AddWithValue("@Password1", hashedPassword);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}