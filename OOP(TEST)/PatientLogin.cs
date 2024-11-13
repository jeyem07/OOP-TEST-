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
    public partial class PatientLogin : Form
    {
        private readonly string connectionString = "Server=127.0.0.1;Database=patient;User ID=root;Password=";

        public PatientLogin()
        {
            InitializeComponent();
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

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Password1 FROM tb_patient WHERE Email = @Username";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", PatientUsername.Text);
                    string storedHashedPassword = (string)cmd.ExecuteScalar();

                    if (storedHashedPassword != null && VerifyPassword(password, storedHashedPassword))
                    {
                        MessageBox.Show("Login successful!", "succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHashedPassword);
        }
    }
}

