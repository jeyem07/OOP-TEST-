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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrWhiteSpace(AdminUsername.Text) || String.IsNullOrWhiteSpace(AdminPass.Text))
            {
                MessageBox.Show("Credentials are Empty", "Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AdminUsername.Text == "admin" && AdminPass.Text == "admin123")
            {
                MessageBox.Show("Log in Succesfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }

            else
            {
                MessageBox.Show("Invalid Credentials. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                AdminPass.PasswordChar = '\0';
                AdminPass.UseSystemPasswordChar = false;
            }
            else
            {
                AdminPass.PasswordChar = '●';
                AdminPass.UseSystemPasswordChar = false;
            }
        }
    }
}