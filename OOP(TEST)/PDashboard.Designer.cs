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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            ManageDoctorsBtn = new Guna.UI2.WinForms.Guna2Button();
            AppointmentBtn = new Guna.UI2.WinForms.Guna2Button();
            BookAppointmentPanel = new Panel();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SubmitBtn = new Button();
            ConsFeeLbl = new Label();
            DoctorComboBox = new ComboBox();
            TimeCombobox = new ComboBox();
            guna2GradientPanel1.SuspendLayout();
            BookAppointmentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.Controls.Add(ManageDoctorsBtn);
            guna2GradientPanel1.Controls.Add(AppointmentBtn);
            guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            guna2GradientPanel1.Location = new Point(1, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            ManageDoctorsBtn.CustomizableEdges = customizableEdges1;
            ManageDoctorsBtn.DisabledState.BorderColor = Color.DarkGray;
            ManageDoctorsBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ManageDoctorsBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ManageDoctorsBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ManageDoctorsBtn.FillColor = Color.DarkCyan;
            ManageDoctorsBtn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            ManageDoctorsBtn.ForeColor = Color.White;
            ManageDoctorsBtn.Location = new Point(42, 233);
            ManageDoctorsBtn.Name = "ManageDoctorsBtn";
            ManageDoctorsBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ManageDoctorsBtn.Size = new Size(131, 60);
            ManageDoctorsBtn.TabIndex = 31;
            ManageDoctorsBtn.Text = "Appointment History";
            // 
            // AppointmentBtn
            // 
            AppointmentBtn.BorderRadius = 30;
            AppointmentBtn.Cursor = Cursors.Hand;
            AppointmentBtn.CustomizableEdges = customizableEdges3;
            AppointmentBtn.DisabledState.BorderColor = Color.DarkGray;
            AppointmentBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AppointmentBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AppointmentBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AppointmentBtn.FillColor = Color.DarkCyan;
            AppointmentBtn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            AppointmentBtn.ForeColor = Color.White;
            AppointmentBtn.Location = new Point(42, 138);
            AppointmentBtn.Name = "AppointmentBtn";
            AppointmentBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AppointmentBtn.Size = new Size(131, 60);
            AppointmentBtn.TabIndex = 30;
            AppointmentBtn.Text = "Book Appointment";
            AppointmentBtn.Click += AppointmentBtn_Click;
            // 
            // BookAppointmentPanel
            // 
            BookAppointmentPanel.Controls.Add(TimeCombobox);
            BookAppointmentPanel.Controls.Add(label2);
            BookAppointmentPanel.Controls.Add(dateTimePicker1);
            BookAppointmentPanel.Controls.Add(SubmitBtn);
            BookAppointmentPanel.Controls.Add(ConsFeeLbl);
            BookAppointmentPanel.Controls.Add(DoctorComboBox);
            BookAppointmentPanel.Location = new Point(218, 0);
            BookAppointmentPanel.Name = "BookAppointmentPanel";
            BookAppointmentPanel.Size = new Size(469, 335);
            BookAppointmentPanel.TabIndex = 31;
            BookAppointmentPanel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 80);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 6;
            label2.Text = "Dr.";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(66, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(250, 241);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(94, 29);
            SubmitBtn.TabIndex = 4;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // ConsFeeLbl
            // 
            ConsFeeLbl.AutoSize = true;
            ConsFeeLbl.Location = new Point(286, 80);
            ConsFeeLbl.Name = "ConsFeeLbl";
            ConsFeeLbl.Size = new Size(119, 20);
            ConsFeeLbl.TabIndex = 1;
            ConsFeeLbl.Text = "Consultation Fee";
            // 
            // DoctorComboBox
            // 
            DoctorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DoctorComboBox.FormattingEnabled = true;
            DoctorComboBox.Location = new Point(66, 77);
            DoctorComboBox.Name = "DoctorComboBox";
            DoctorComboBox.Size = new Size(151, 28);
            DoctorComboBox.TabIndex = 0;
            DoctorComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TimeCombobox
            // 
            TimeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            TimeCombobox.FormattingEnabled = true;
            TimeCombobox.Items.AddRange(new object[] { "6:00 - 14:00", "14:00 - 22:00", "22:00 - 6:00" });
            TimeCombobox.Location = new Point(66, 195);
            TimeCombobox.Name = "TimeCombobox";
            TimeCombobox.Size = new Size(151, 28);
            TimeCombobox.TabIndex = 45;
            TimeCombobox.SelectedIndexChanged += TimeCombobox_SelectedIndexChanged_1;
            // 
            // PDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 342);
            ControlBox = false;
            Controls.Add(BookAppointmentPanel);
            Controls.Add(guna2GradientPanel1);
            Name = "PDashboard";
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
        private Label ConsFeeLbl;
        private ComboBox DoctorComboBox;
        private Button SubmitBtn;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox TimeCombobox;
    }
}