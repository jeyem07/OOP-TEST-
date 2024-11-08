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

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void DoctorListBtn_Click(object sender, EventArgs e)
        {
            PatientGridView.Visible = false;
            DoctorGridView.Visible = true;
        }

        private void PatientListBtn_Click(object sender, EventArgs e)
        {
            DoctorGridView.Visible = false;
            PatientGridView.Visible = true;
        }

    }
}
