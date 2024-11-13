using MySql.Data.MySqlClient;
using System;
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDoctor = "";

            if (DoctorComboBox.SelectedItem != null)
            {
                selectedDoctor = DoctorComboBox.SelectedItem.ToString();
            }


            // Check if the selected item is the placeholder
            if (selectedDoctor == "Select a Doctor...")
            {
                // Set the label to 0 if the placeholder is selected
                ConsFeeLbl.Text = "Consultation Fee";
            }
            else if (doctorFees.ContainsKey(selectedDoctor))
            {
                // Set the label to the consultation fee of the selected doctor
                ConsFeeLbl.Text = doctorFees[selectedDoctor];
            }

        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            BookAppointmentPanel.Visible = true;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {



                conn.Open();

                string query = "SELECT lastname, consultationfee from tb_doctor";


                MySqlCommand adapter = new MySqlCommand(query, conn);
                MySqlDataReader reader = adapter.ExecuteReader();

                DoctorComboBox.Items.Clear();
                doctorFees.Clear();

                DoctorComboBox.Items.Add(PlaceholderText);
                DoctorComboBox.SelectedIndex = 0;


                while (reader.Read())
                {
                    string Lastname = reader["lastname"].ToString();

                    string ConsultationFee = reader["consultationfee"].ToString();

                    DoctorComboBox.Items.Add(Lastname);

                    doctorFees[Lastname] = ConsultationFee;
                }

                conn.Close();

            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
