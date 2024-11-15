using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OOP_TEST_
{
    public partial class AdminDashboard : Form
    {
        private string connectionString = "Server=127.0.0.1; Database=patient;User ID=root;Password=";

        public AdminDashboard()
        {
            InitializeComponent();
        }

        #region Database Connection Class
        public class DatabaseConnection
        {
            private string connectionString = "Server=127.0.0.1; Database=patient;User ID=root;Password=";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }
        #endregion

        #region Data Model Classes
        public class Doctor
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public decimal ConsultationFee { get; set; }
            public string Password { get; set; }
        }

        public class Patient
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string ContactNumber { get; set; }
            public string Password { get; set; }
        }

        public class Appointment
        {
            public int AppointmentID { get; set; }
            public DateTime AppointmentDate { get; set; }
            public string PatientFirstName { get; set; }
            public string PatientLastName { get; set; }
            public string DoctorFirstName { get; set; }
            public string DoctorLastName { get; set; }
        }
        #endregion

        #region Repository Classes
        public class DoctorRepository
        {
            private DatabaseConnection _databaseConnection;

            public DoctorRepository()
            {
                _databaseConnection = new DatabaseConnection();
            }

            public DataTable GetAllDoctors()
            {
                using (MySqlConnection connection = _databaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT firstname, lastname, email, consultationfee, password from tb_doctor";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable doctorTable = new DataTable();
                    adapter.Fill(doctorTable);
                    return doctorTable;
                }
            }
        }

        public class PatientRepository
        {
            private DatabaseConnection _databaseConnection;

            public PatientRepository()
            {
                _databaseConnection = new DatabaseConnection();
            }

            public DataTable GetAllPatients()
            {
                using (MySqlConnection connection = _databaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT firstname, lastname, email, Contactnumber, password from tb_patient";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable patientTable = new DataTable();
                    adapter.Fill(patientTable);
                    return patientTable;
                }
            }
        }

        public class AppointmentRepository
        {
            private DatabaseConnection _databaseConnection;

            public AppointmentRepository()
            {
                _databaseConnection = new DatabaseConnection();
            }

            public DataTable GetAllAppointments()
            {
                using (MySqlConnection connection = _databaseConnection.GetConnection())
                {
                    connection.Open();
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
        #endregion

        #region UI Event Handlers
        private void DoctorListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorRepository doctorRepository = new DoctorRepository();
                DataTable doctorTable = doctorRepository.GetAllDoctors();
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
                PatientRepository patientRepository = new PatientRepository();
                DataTable patientTable = patientRepository.GetAllPatients();
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
                AppointmentRepository appointmentRepository = new AppointmentRepository();
                DataTable appointmentTable = appointmentRepository.GetAllAppointments();
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
        #endregion
    }
}
