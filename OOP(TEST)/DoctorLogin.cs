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
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void DoctorLoginBtn_Click(object sender, EventArgs e)
        {
            string DoctorUser = DoctorUsername.Text;
            string DoctorPassword = DoctorPass.Text;

            if (DoctorUser == "doctor" && DoctorPassword == "doctor123")
            {
                MessageBox.Show("Log in Succesfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                DoctorDashboard doctorDashboard = new DoctorDashboard();
                doctorDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
                DoctorPass.UseSystemPasswordChar = false;
            }
        }
    }
}
