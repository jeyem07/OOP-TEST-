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
using Microsoft.VisualBasic.ApplicationServices;


namespace OOP_TEST_
{
    public partial class DoctorLogin : Form
    {
        private readonly string connectionString = "Server=127.0.0.1;Database=patient;User ID=root;Password=";

        public DoctorLogin()
        {
            InitializeComponent();
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

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Password1 FROM patientinfo WHERE Email = @MDemail";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MDemail", DoctorUsername.Text);
                    string storedHashedPassword = (string)cmd.ExecuteScalar();

                    if (storedHashedPassword != null && VerifyPassword(password, storedHashedPassword))
                    {
                        MessageBox.Show("Login successful!", "succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PatientDashboard patientDashboard = new PatientDashboard();
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
}


