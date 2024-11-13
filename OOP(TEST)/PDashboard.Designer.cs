namespace OOP_TEST_
{
    partial class PDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            ManageDoctorsBtn = new Guna.UI2.WinForms.Guna2Button();
            AppointmentBtn = new Guna.UI2.WinForms.Guna2Button();
            BookAppointmentPanel = new Panel();
            SubmitBtn = new Button();
            label2 = new Label();
            DoctorComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            guna2GradientPanel1.SuspendLayout();
            BookAppointmentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.Controls.Add(ManageDoctorsBtn);
            guna2GradientPanel1.Controls.Add(AppointmentBtn);
            guna2GradientPanel1.CustomizableEdges = customizableEdges11;
            guna2GradientPanel1.Location = new Point(1, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2GradientPanel1.Size = new Size(211, 335);
            guna2GradientPanel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(3, 31);
            label1.Name = "label1";
            label1.Size = new Size(204, 74);
            label1.TabIndex = 33;
            label1.Text = "PATIENT\n DASHBOARD";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ManageDoctorsBtn
            // 
            ManageDoctorsBtn.BorderRadius = 30;
            ManageDoctorsBtn.Cursor = Cursors.Hand;
            ManageDoctorsBtn.CustomizableEdges = customizableEdges7;
            ManageDoctorsBtn.DisabledState.BorderColor = Color.DarkGray;
            ManageDoctorsBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ManageDoctorsBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ManageDoctorsBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ManageDoctorsBtn.FillColor = Color.DarkCyan;
            ManageDoctorsBtn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            ManageDoctorsBtn.ForeColor = Color.White;
            ManageDoctorsBtn.Location = new Point(42, 233);
            ManageDoctorsBtn.Name = "ManageDoctorsBtn";
            ManageDoctorsBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ManageDoctorsBtn.Size = new Size(131, 60);
            ManageDoctorsBtn.TabIndex = 31;
            ManageDoctorsBtn.Text = "Appointment History";
            // 
            // AppointmentBtn
            // 
            AppointmentBtn.BorderRadius = 30;
            AppointmentBtn.Cursor = Cursors.Hand;
            AppointmentBtn.CustomizableEdges = customizableEdges9;
            AppointmentBtn.DisabledState.BorderColor = Color.DarkGray;
            AppointmentBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AppointmentBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AppointmentBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AppointmentBtn.FillColor = Color.DarkCyan;
            AppointmentBtn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            AppointmentBtn.ForeColor = Color.White;
            AppointmentBtn.Location = new Point(42, 138);
            AppointmentBtn.Name = "AppointmentBtn";
            AppointmentBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            AppointmentBtn.Size = new Size(131, 60);
            AppointmentBtn.TabIndex = 30;
            AppointmentBtn.Text = "Book Appointment";
            AppointmentBtn.Click += AppointmentBtn_Click;
            // 
            // BookAppointmentPanel
            // 
            BookAppointmentPanel.Controls.Add(dateTimePicker1);
            BookAppointmentPanel.Controls.Add(SubmitBtn);
            BookAppointmentPanel.Controls.Add(label2);
            BookAppointmentPanel.Controls.Add(DoctorComboBox);
            BookAppointmentPanel.Location = new Point(218, 0);
            BookAppointmentPanel.Name = "BookAppointmentPanel";
            BookAppointmentPanel.Size = new Size(469, 335);
            BookAppointmentPanel.TabIndex = 31;
            BookAppointmentPanel.Visible = false;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(250, 241);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(94, 29);
            SubmitBtn.TabIndex = 4;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 80);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // DoctorComboBox
            // 
            DoctorComboBox.FormattingEnabled = true;
            DoctorComboBox.Location = new Point(66, 77);
            DoctorComboBox.Name = "DoctorComboBox";
            DoctorComboBox.Size = new Size(151, 28);
            DoctorComboBox.TabIndex = 0;
            DoctorComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(66, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 342);
            ControlBox = false;
            Controls.Add(BookAppointmentPanel);
            Controls.Add(guna2GradientPanel1);
            Name = "PatientDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            BookAppointmentPanel.ResumeLayout(false);
            BookAppointmentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button ManageDoctorsBtn;
        private Guna.UI2.WinForms.Guna2Button AppointmentBtn;
        private Panel BookAppointmentPanel;
        private Label label2;
        private ComboBox DoctorComboBox;
        private Button SubmitBtn;
        private DateTimePicker dateTimePicker1;
    }
}