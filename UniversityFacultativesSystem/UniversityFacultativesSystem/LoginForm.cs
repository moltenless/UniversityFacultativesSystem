using System;
using System.Drawing;
using System.Windows.Forms;
using UniversityFacultativesSystem.Properties;

namespace UniversityFacultativesSystem
{
    internal partial class LoginForm : Form
    {
        private Role role;
        public LoginForm(Role role)
        {
            InitializeComponent();
            this.Style(3.6f, Color.LightSkyBlue);
            loginButton.Style(2f, Color.LightSkyBlue);
            closeButton.Style(1.6f, Color.LightSkyBlue);
            minimizeButton.Style(1.6f, Color.LightSkyBlue);

            Icon = Resources.education_computer_school_graduate_cap_monitor_icon_149680;

            this.role = role;
            switch (role)
            {
                case Role.Deanery:
                    roleLabel.Text += "деканат:";
                    break;
                case Role.Teacher:
                    roleLabel.Text += "викладач:";
                    break;
                case Role.Student:
                    roleLabel.Text += "студент:";
                    break;
            }

            loginTextbox.Focus();
        }

        private void Login(object sender, EventArgs e)
        {
            switch(role)
            {
                case Role.Deanery:

                    break;
                case Role.Teacher:

                    break;
                case Role.Student:

                    break;
            }
        }

        private void Close(object sender, EventArgs e) => this.Close();
        private void Minimize(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void MouseEnteredRoles(object sender, EventArgs e) => labelArrow.Visible = true;
        private void MouseLeftRoles(object sender, EventArgs e) => labelArrow.Visible = false;
        private void BackClicked(object sender, EventArgs e) => Program.GoTo(new StartForm());

        public enum Role { Deanery = 1, Teacher = 2, Student = 3 }

        private void ABCChange(object sender, EventArgs e) => passwordTextbox.UseSystemPasswordChar = !passwordTextbox.UseSystemPasswordChar;
    }
}
