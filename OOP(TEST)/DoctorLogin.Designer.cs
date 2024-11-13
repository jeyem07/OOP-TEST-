namespace OOP_TEST_
{
    partial class DoctorLogin
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
            DoctorLoginBtn = new Guna.UI2.WinForms.Guna2Button();
            DoctorPass = new Guna.UI2.WinForms.Guna2TextBox();
            DoctorUsername = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            showPass = new CheckBox();
            SuspendLayout();
            // 
            // DoctorLoginBtn
            // 
            DoctorLoginBtn.BorderRadius = 30;
            DoctorLoginBtn.Cursor = Cursors.Hand;
            DoctorLoginBtn.CustomizableEdges = customizableEdges1;
            DoctorLoginBtn.DisabledState.BorderColor = Color.DarkGray;
            DoctorLoginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            DoctorLoginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DoctorLoginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DoctorLoginBtn.FillColor = Color.DarkCyan;
            DoctorLoginBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorLoginBtn.ForeColor = Color.White;
            DoctorLoginBtn.Location = new Point(131, 307);
            DoctorLoginBtn.Name = "DoctorLoginBtn";
            DoctorLoginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DoctorLoginBtn.Size = new Size(132, 63);
            DoctorLoginBtn.TabIndex = 28;
            DoctorLoginBtn.Text = "Login";
            DoctorLoginBtn.Click += DoctorLoginBtn_Click;
            // 
            // DoctorPass
            // 
            DoctorPass.BorderColor = Color.FromArgb(64, 64, 64);
            DoctorPass.BorderRadius = 26;
            DoctorPass.Cursor = Cursors.IBeam;
            DoctorPass.CustomizableEdges = customizableEdges3;
            DoctorPass.DefaultText = "";
            DoctorPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DoctorPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DoctorPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DoctorPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DoctorPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DoctorPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorPass.ForeColor = Color.Black;
            DoctorPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DoctorPass.Location = new Point(42, 182);
            DoctorPass.Margin = new Padding(13, 12, 13, 12);
            DoctorPass.Name = "DoctorPass";
            DoctorPass.Padding = new Padding(27, 25, 27, 25);
            DoctorPass.PasswordChar = '●';
            DoctorPass.PlaceholderForeColor = SystemColors.GrayText;
            DoctorPass.PlaceholderText = "Password";
            DoctorPass.SelectedText = "";
            DoctorPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DoctorPass.Size = new Size(317, 60);
            DoctorPass.TabIndex = 31;
            // 
            // DoctorUsername
            // 
            DoctorUsername.BorderColor = Color.FromArgb(64, 64, 64);
            DoctorUsername.BorderRadius = 26;
            DoctorUsername.Cursor = Cursors.IBeam;
            DoctorUsername.CustomizableEdges = customizableEdges5;
            DoctorUsername.DefaultText = "";
            DoctorUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DoctorUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DoctorUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DoctorUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DoctorUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DoctorUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorUsername.ForeColor = Color.Black;
            DoctorUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DoctorUsername.Location = new Point(42, 98);
            DoctorUsername.Margin = new Padding(13, 12, 13, 12);
            DoctorUsername.Name = "DoctorUsername";
            DoctorUsername.Padding = new Padding(27, 25, 27, 25);
            DoctorUsername.PasswordChar = '\0';
            DoctorUsername.PlaceholderForeColor = SystemColors.GrayText;
            DoctorUsername.PlaceholderText = "Username";
            DoctorUsername.SelectedText = "";
            DoctorUsername.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DoctorUsername.Size = new Size(317, 60);
            DoctorUsername.TabIndex = 30;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(86, 33);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(213, 38);
            guna2HtmlLabel1.TabIndex = 29;
            guna2HtmlLabel1.Text = "Login as Doctor";
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Location = new Point(56, 257);
            showPass.Name = "showPass";
            showPass.Size = new Size(139, 22);
            showPass.TabIndex = 34;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // DoctorLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 405);
            ControlBox = false;
            Controls.Add(showPass);
            Controls.Add(DoctorPass);
            Controls.Add(DoctorUsername);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(DoctorLoginBtn);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DoctorLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button DoctorLoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox DoctorPass;
        private Guna.UI2.WinForms.Guna2TextBox DoctorUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private CheckBox showPass;
    }
}