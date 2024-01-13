using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UniversityFacultativesDAL.Entity;
using UniversityFacultativesDAL.Service;
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
            this.Enabled = false;
            DataService service = new DataService("deanery", "deanery32188");
            List<UserLogin> teachers = service.Logins.GetTeachersLogins();
            List<UserLogin> students = service.Logins.GetStudentsLogins();
            service.Close();

            string user = loginTextbox.Text;
            string password = passwordTextbox.Text;

            bool success = true;

            switch (role)
            {
                case Role.Deanery:
                    if (user != "deanery" || password != "deanery32188")
                    {
                        success = false;
                        break;
                    }
                    Program.GoTo(new DeaneryForm(user, password));
                    break;
                case Role.Teacher:
                    int teacherId = teachers.FindIndex(t => t.Login == user && t.Password == password);
                    if (teacherId == -1)
                    {
                        success = false;
                        break;
                    }
                    Program.GoTo(new TeacherForm(user, password));
                    break;
                case Role.Student:
                    int studentId = students.FindIndex(s => s.Login == user && s.Password == password);
                    if (studentId == -1)
                    {
                        success = false; 
                        break;
                    }
                    Program.GoTo(new StudentForm(user, password));
                    break;
            }

            if (!success)
            {
                MessageBox.Show("Ім'я користувача або пароль були неправильними!", "Невдалий вхід", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginTextbox.Clear();
                passwordTextbox.Clear();
                label1.ForeColor = label2.ForeColor = Color.Red;
            }

            this.Enabled = true;
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
