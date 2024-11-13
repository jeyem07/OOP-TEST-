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

        private void MDBtnAddDoctor1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MDFirstName.Text) || String.IsNullOrEmpty(MDLastName.Text) || String.IsNullOrEmpty(MDEmail.Text) || String.IsNullOrEmpty(MDPassword.Text) || String.IsNullOrEmpty(MDConfirmPassword.Text) || String.IsNullOrEmpty(MDConsultationFee.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MDPassword.Text != MDConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            string hashedPassword = HashPassword(MDPassword.Text);

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "INSERT INTO patientinfo (Firstname, Lastname, Email, Consultationfee, Password, password1) VALUES (@MDFirstname, @MDLastname, @MDEmail, @MDConsultationfee,  @MDPassword, @Password1)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MDEmail", MDEmail.Text);
                    cmd.Parameters.AddWithValue("@MDFirstname", MDFirstName.Text);
                    cmd.Parameters.AddWithValue("@MDLastname", MDLastName.Text);
                    cmd.Parameters.AddWithValue("@MDPassword", MDPassword.Text);
                    cmd.Parameters.AddWithValue("@MDConsultationfee", MDConsultationFee.Text);
                    cmd.Parameters.AddWithValue("@Password1", hashedPassword);


                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");

                    
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
