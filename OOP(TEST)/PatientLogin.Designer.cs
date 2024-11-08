namespace OOP_TEST_
{
    partial class PatientLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            PatientPass = new Guna.UI2.WinForms.Guna2TextBox();
            PatientUsername = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Linklbl1 = new LinkLabel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            showPass = new CheckBox();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BorderRadius = 30;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.CustomizableEdges = customizableEdges1;
            LoginBtn.DisabledState.BorderColor = Color.DarkGray;
            LoginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginBtn.FillColor = Color.DarkCyan;
            LoginBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(266, 381);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LoginBtn.Size = new Size(161, 60);
            LoginBtn.TabIndex = 22;
            LoginBtn.Text = "Login";
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PatientPass
            // 
            PatientPass.BorderColor = Color.FromArgb(64, 64, 64);
            PatientPass.BorderRadius = 26;
            PatientPass.Cursor = Cursors.IBeam;
            PatientPass.CustomizableEdges = customizableEdges3;
            PatientPass.DefaultText = "";
            PatientPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatientPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatientPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatientPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatientPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatientPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PatientPass.ForeColor = Color.Black;
            PatientPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatientPass.Location = new Point(99, 239);
            PatientPass.Margin = new Padding(13, 12, 13, 12);
            PatientPass.Name = "PatientPass";
            PatientPass.Padding = new Padding(27, 25, 27, 25);
            PatientPass.PasswordChar = '●';
            PatientPass.PlaceholderForeColor = SystemColors.GrayText;
            PatientPass.PlaceholderText = "Password";
            PatientPass.SelectedText = "";
            PatientPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PatientPass.Size = new Size(317, 60);
            PatientPass.TabIndex = 19;
            // 
            // PatientUsername
            // 
            PatientUsername.BorderColor = Color.FromArgb(64, 64, 64);
            PatientUsername.BorderRadius = 26;
            PatientUsername.Cursor = Cursors.IBeam;
            PatientUsername.CustomizableEdges = customizableEdges5;
            PatientUsername.DefaultText = "";
            PatientUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PatientUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PatientUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PatientUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PatientUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PatientUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PatientUsername.ForeColor = Color.Black;
            PatientUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PatientUsername.Location = new Point(99, 155);
            PatientUsername.Margin = new Padding(13, 12, 13, 12);
            PatientUsername.Name = "PatientUsername";
            PatientUsername.Padding = new Padding(27, 25, 27, 25);
            PatientUsername.PasswordChar = '\0';
            PatientUsername.PlaceholderForeColor = SystemColors.GrayText;
            PatientUsername.PlaceholderText = "Email";
            PatientUsername.SelectedText = "";
            PatientUsername.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PatientUsername.Size = new Size(317, 60);
            PatientUsername.TabIndex = 17;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(145, 89);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(217, 38);
            guna2HtmlLabel1.TabIndex = 15;
            guna2HtmlLabel1.Text = "Login as Patient";
            // 
            // Linklbl1
            // 
            Linklbl1.ActiveLinkColor = Color.DarkSlateGray;
            Linklbl1.AutoSize = true;
            Linklbl1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Linklbl1.LinkColor = Color.DeepSkyBlue;
            Linklbl1.Location = new Point(109, 357);
            Linklbl1.Name = "Linklbl1";
            Linklbl1.Size = new Size(126, 16);
            Linklbl1.TabIndex = 23;
            Linklbl1.TabStop = true;
            Linklbl1.Text = "Register an account";
            Linklbl1.LinkClicked += Linklbl1_LinkClicked;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 30;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkCyan;
            guna2Button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(303, 447);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(95, 58);
            guna2Button1.TabIndex = 24;
            guna2Button1.Text = "skip";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Location = new Point(109, 314);
            showPass.Name = "showPass";
            showPass.Size = new Size(139, 22);
            showPass.TabIndex = 33;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // PatientLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 517);
            ControlBox = false;
            Controls.Add(showPass);
            Controls.Add(guna2Button1);
            Controls.Add(Linklbl1);
            Controls.Add(LoginBtn);
            Controls.Add(PatientPass);
            Controls.Add(PatientUsername);
            Controls.Add(guna2HtmlLabel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PatientLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox PatientPass;
        private Guna.UI2.WinForms.Guna2TextBox PatientUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private LinkLabel Linklbl1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private CheckBox showPass;
    }
}