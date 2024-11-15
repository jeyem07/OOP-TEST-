using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace OOP_TEST_
{
    public partial class PDashboard : Form
    {
        private readonly string connectionString = "Server=127.0.0.1; Database=patient;User ID=root;Password=";
        private readonly Dictionary<string, string> doctorFees = new Dictionary<string, string>();
        private const string PlaceholderText = "Select a Doctor...";

        private readonly AppointmentService appointmentService;
        private readonly DoctorManagementService doctorService;

        public PDashboard()
        {
            InitializeComponent();
            appointmentService = new AppointmentService(connectionString);
            doctorService = new DoctorManagementService(connectionString);

            LoadAppointmentHistory();
        }

        private void LoadAppointmentHistory()
        {
            var appointmentHistoryTable = appointmentService.GetAppointmentHistory();
            // Bind the appointmentHistoryTable to a UI control like DataGridView or ListView.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDoctor = DoctorComboBox.SelectedItem?.ToString() ?? string.Empty;

            if (selectedDoctor == PlaceholderText)
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
            doctorService.LoadDoctorsIntoComboBox(DoctorComboBox, doctorFees);
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

            bool isAppointmentBooked = appointmentService.BookAppointment(patientId, selectedDoctor, consultationFee);

            if (isAppointmentBooked)
            {
                MessageBox.Show("Appointment successfully booked.");
                LoadAppointmentHistory();
            }
            else
            {
                MessageBox.Show("Error booking appointment. Please try again.");
            }
        }
    }

    public class AppointmentService
    {
        private readonly string connectionString;

        public AppointmentService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetAppointmentHistory()
        {
            using (var conn = new MySqlConnection(connectionString))
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
                return appointmentHistoryTable;
            }
        }

        public bool BookAppointment(int patientId, string doctorLastname, string consultationFee)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO AppointmentHistory 
                                 (p_firstname, d_lastname, d_consultationfee) 
                                 VALUES (@patientId, @doctorLastname, @consultationFee)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@patientId", patientId);
                cmd.Parameters.AddWithValue("@doctorLastname", doctorLastname);
                cmd.Parameters.AddWithValue("@consultationFee", consultationFee);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

    public class DoctorManagementService
    {
        private readonly string connectionString;

        public DoctorManagementService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void LoadDoctorsIntoComboBox(ComboBox doctorComboBox, Dictionary<string, string> doctorFees)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT lastname, consultationfee FROM tb_doctor";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                doctorComboBox.Items.Clear();
                doctorFees.Clear();

                doctorComboBox.Items.Add("Select a Doctor...");
                doctorComboBox.SelectedIndex = 0;

                while (reader.Read())
                {
                    string lastName = reader["lastname"].ToString();
                    string consultationFee = reader["consultationfee"].ToString();

                    doctorComboBox.Items.Add(lastName);
                    doctorFees[lastName] = consultationFee;
                }
            }
        }
    }
}
