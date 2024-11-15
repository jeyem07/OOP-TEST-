using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace OOP_TEST_
{
    public partial class PDashboard : Form
    {
        private string connectionString = "Server=127.0.0.1; Database=patient;User ID=root;Password=";
        private Dictionary<string, string> doctorFees = new Dictionary<string, string>();
        private const string PlaceholderText = "Select a Doctor...";

        public PDashboard()
        {
            InitializeComponent();
            LoadAppointmentHistory();
        }

        private void LoadAppointmentHistory()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                                    appointmenthistory.id,
                                    Tb_patient.Firstname AS p_firstname, 
                                    Tb_patient.Lastname AS p_lastname, 
                                    Tb_patient.ContactNumber AS p_contactnumber,
                                    tb_doctor.firstname AS d_firstname, 
                                    tb_doctor.lastname AS d_lastname, 
                                    tb_doctor.consultationfee AS d_consultationfee
                                 FROM 
                                    appointmenthistory
                                 JOIN 
                                    tb_patient ON appointmenthistory.id = tb_patient.id
                                 JOIN 
                                    tb_doctor ON appointmenthistory.id = tb_doctor.id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable appointmentHistoryTable = new DataTable();
                adapter.Fill(appointmentHistoryTable);

                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDoctor = "";

            if (DoctorComboBox.SelectedItem != null)
            {
                selectedDoctor = DoctorComboBox.SelectedItem.ToString();
            }

            if (selectedDoctor == "Select a Doctor...")
            {
                ConsFeeLbl.Text = "Consultation Fee";
            }
            else if (doctorFees.ContainsKey(selectedDoctor))
            {
                ConsFeeLbl.Text = "Consulation Fee: " + doctorFees[selectedDoctor];
            }
        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            BookAppointmentPanel.Visible = true;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT lastname, consultationfee FROM tb_doctor";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                DoctorComboBox.Items.Clear();
                doctorFees.Clear();

                DoctorComboBox.Items.Add(PlaceholderText);
                DoctorComboBox.SelectedIndex = 0;

                while (reader.Read())
                {
                    string lastName = reader["lastname"].ToString();
                    string consultationFee = reader["consultationfee"].ToString();

                    DoctorComboBox.Items.Add(lastName);
                    doctorFees[lastName] = consultationFee;
                }

                conn.Close();
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (DoctorComboBox.SelectedItem == null || DoctorComboBox.SelectedItem.ToString() == PlaceholderText)
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }

            int patientId = 1;
            string selectedDoctor = DoctorComboBox.SelectedItem.ToString();
            string consultationFee = ConsFeeLbl.Text;


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO AppointmentHistory 
                                 (p_firstname, d_lastname, d_consultationfee) 
                                 VALUES (@patientId, @doctorLastname, @consultationFee)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@patientId", patientId);
                cmd.Parameters.AddWithValue("@doctorLastname", selectedDoctor);
                cmd.Parameters.AddWithValue("@consultationFee", consultationFee);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Appointment successfully booked.");
                    LoadAppointmentHistory();
                }
                else
                {
                    MessageBox.Show("Error booking appointment. Please try again.");
                }

                conn.Close();
            }
        }

        private void TimeCombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}