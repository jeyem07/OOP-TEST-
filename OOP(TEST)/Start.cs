namespace OOP_TEST_
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }


        private void PatientBtn_Click(object sender, EventArgs e)
        {

            PatientRegister patientForm = new PatientRegister();
            patientForm.Show();

            this.Hide();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            AdminLogin AdminForm = new AdminLogin();
            AdminForm.Show();
            this.Hide();
        }

        private void DoctorBtn_Click(object sender, EventArgs e)
        {
            DoctorLogin doctorForm = new DoctorLogin();
            doctorForm.Show();

            this.Hide();
        }
    }
}