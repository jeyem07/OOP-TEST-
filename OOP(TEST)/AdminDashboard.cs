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

namespace OOP_TEST_
{
    public partial class AdminDashboard : Form
    {
        private string connectionstring = "Server=127.0.0.1; Database=patient;User ID=root;Password=";

        public AdminDashboard()
        {
            InitializeComponent();

        }

        private void DoctorListBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT firstname, lastname, email, consultationfee, password from tb_doctor";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);


                    DataTable doctorTable = new DataTable();
                    adapter.Fill(doctorTable);

                    Data_GridView.DataSource = doctorTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                Data_GridView.Visible = true;
            }

        }

        private void PatientListBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT firstname, lastname, email, Contactnumber, password from tb_patient";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);


                    DataTable PatientTable = new DataTable();
                    adapter.Fill(PatientTable);

                    Data_GridView.DataSource = PatientTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                Data_GridView.Visible = true;
            }
        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {

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
        public void LoadAppointments()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                try
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

                    Data_GridView.DataSource = appointmentTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                Data_GridView.Visible = true;
            }
        }
    }

}

