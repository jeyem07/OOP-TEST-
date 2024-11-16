using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OOP_TEST_
{
    public partial class AdminDashboard : Form
    {
        private string _connectionString = "Server=127.0.0.1; Database=patient;User ID=root;Password=";
        private DoctorList _doctorList;
        private PatientList _patientList;
        private AppointmentDetails _appointmentDetails;

        public AdminDashboard()
        {
            InitializeComponent();
            _doctorList = new DoctorList();
            _patientList = new PatientList();
            _appointmentDetails = new AppointmentDetails();
        }

        private void DoctorListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable doctorTable = _doctorList.GetAllDoctors();
                Data_GridView.DataSource = doctorTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            Data_GridView.Visible = true;
        }

        private void PatientListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable patientTable = _patientList.GetAllPatients();
                Data_GridView.DataSource = patientTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            Data_GridView.Visible = true;
        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable appointmentTable = _appointmentDetails.GetAllAppointments();
                Data_GridView.DataSource = appointmentTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            Data_GridView.Visible = true;
        }

        private void ManageDoctorsBtn_Click(object sender, EventArgs e)
        {
            Form openForm = Application.OpenForms["AdminAddDoctor"];
            if (openForm == null)
            {
                AdminAddDoctor adminAddDoctor = new AdminAddDoctor();
                adminAddDoctor.Show();
            }
            else
            {
                openForm.BringToFront();
                openForm.Focus();
            }
        }
    }

    public class DoctorList
    {
        private string _connectionString = "Server=127.0.0.1; Database=patient;User ID=root;Password=";

        public DataTable GetAllDoctors()
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT firstname, lastname, username, consultationfee, password from tb_doctor";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable doctorTable = new DataTable();
                adapter.Fill(doctorTable);
                return doctorTable;
            }
        }
    }

    public class PatientList
    {
        private string _connectionString = "Server=127.0.0.1; Database=patient;User ID=root;Password=";

        public DataTable GetAllPatients()
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT firstname, lastname, username, Contactnumber, password from tb_patient";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable patientTable = new DataTable();
                adapter.Fill(patientTable);
                return patientTable;
            }
        }
    }

    public class AppointmentDetails
    {
        private string _connectionString = "Server=127.0.0.1; Database=patient;User ID=root;Password=";

        public DataTable GetAllAppointments()
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = @"SELECT a.AppointmentID, a.AppointmentDate, 
                                 p.firstname AS PatientFirstName, p.lastname AS PatientLastName,
                                 d.firstname AS DoctorFirstName, d.lastname AS DoctorLastName
                                 FROM AppointmentHistory a
                                 JOIN patientinfo p ON a.PatientID = p.PatientID
                                 JOIN doctorinfo d ON a.DoctorID = d.DoctorID";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable appointmentTable = new DataTable();
                adapter.Fill(appointmentTable);
                return appointmentTable;
            }
        }
    }
}
