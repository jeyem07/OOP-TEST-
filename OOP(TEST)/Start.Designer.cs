namespace OOP_TEST_
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PatientBtn = new Guna.UI2.WinForms.Guna2Button();
            DoctorBtn = new Guna.UI2.WinForms.Guna2Button();
            AdminBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // PatientBtn
            // 
            PatientBtn.BorderRadius = 30;
            PatientBtn.Cursor = Cursors.Hand;
            PatientBtn.CustomizableEdges = customizableEdges1;
            PatientBtn.DisabledState.BorderColor = Color.DarkGray;
            PatientBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            PatientBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            PatientBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            PatientBtn.FillColor = Color.DarkCyan;
            PatientBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PatientBtn.ForeColor = Color.White;
            PatientBtn.Location = new Point(25, 140);
            PatientBtn.Name = "PatientBtn";
            PatientBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PatientBtn.Size = new Size(250, 113);
            PatientBtn.TabIndex = 0;
            PatientBtn.Text = "Patient";
            PatientBtn.Click += PatientBtn_Click;
            // 
            // DoctorBtn
            // 
            DoctorBtn.BorderRadius = 30;
            DoctorBtn.Cursor = Cursors.Hand;
            DoctorBtn.CustomizableEdges = customizableEdges3;
            DoctorBtn.DisabledState.BorderColor = Color.DarkGray;
            DoctorBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            DoctorBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DoctorBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DoctorBtn.FillColor = Color.DarkCyan;
            DoctorBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorBtn.ForeColor = Color.White;
            DoctorBtn.Location = new Point(311, 140);
            DoctorBtn.Name = "DoctorBtn";
            DoctorBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DoctorBtn.Size = new Size(250, 113);
            DoctorBtn.TabIndex = 1;
            DoctorBtn.Text = "Doctor";
            DoctorBtn.Click += DoctorBtn_Click;
            // 
            // AdminBtn
            // 
            AdminBtn.BorderRadius = 30;
            AdminBtn.Cursor = Cursors.Hand;
            AdminBtn.CustomizableEdges = customizableEdges5;
            AdminBtn.DisabledState.BorderColor = Color.DarkGray;
            AdminBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AdminBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AdminBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AdminBtn.FillColor = Color.DarkCyan;
            AdminBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AdminBtn.ForeColor = Color.White;
            AdminBtn.Location = new Point(592, 140);
            AdminBtn.Name = "AdminBtn";
            AdminBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            AdminBtn.Size = new Size(250, 113);
            AdminBtn.TabIndex = 2;
            AdminBtn.Text = "Admin";
            AdminBtn.Click += AdminBtn_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(174, 36);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(536, 38);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Welcome to Hospital Information System";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(365, 83);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(118, 31);
            guna2HtmlLabel2.TabIndex = 4;
            guna2HtmlLabel2.Text = "Choose as";
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 369);
            ControlBox = false;
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(AdminBtn);
            Controls.Add(DoctorBtn);
            Controls.Add(PatientBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button PatientBtn;
        private Guna.UI2.WinForms.Guna2Button DoctorBtn;
        private Guna.UI2.WinForms.Guna2Button AdminBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}