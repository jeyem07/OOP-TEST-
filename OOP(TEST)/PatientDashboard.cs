using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace OOP_TEST_
{
    public partial class PatientDashboard : Form
    {
        private string connectionString = "Server=127.0.0.1; Database=patient;User ID=root;Password=";

        public PatientDashboard()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            BookAppointmentPanel.Visible = true;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
            }
        }
    }
}
