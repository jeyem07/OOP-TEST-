using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace OOP_TEST_
{
    public partial class PatientDashboard : Form
    {
        private string connectionString = "Server=127.0.0.1; Database=patient;User ID=root;Password=yourpassword";

        public PatientDashboard()
        {
            InitializeComponent();
        }
    }
}
