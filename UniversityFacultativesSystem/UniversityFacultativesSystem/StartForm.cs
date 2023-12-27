using System;
using System.Drawing;
using System.Windows.Forms;
using UniversityFacultativesSystem.Properties;

namespace UniversityFacultativesSystem
{
    internal partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.Style(3.6f, Color.LightSkyBlue);
            Icon = Resources.education_computer_school_graduate_cap_monitor_icon_149680;
            deaneryButton.Style(2f, Color.LightSkyBlue);
            teacherButton.Style(2f, Color.LightSkyBlue);
            studentButton.Style(2f, Color.LightSkyBlue);
            closeButton.Style(1.6f, Color.LightSkyBlue);
            minimizeButton.Style(1.6f, Color.LightSkyBlue);
        }

        private void RoleClicked(object sender, EventArgs e)
        {

        }

        private void Close(object sender, EventArgs e) => this.Close();
        private void Minimize(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void MouseEnteredRoles(object sender, EventArgs e)
         => Controls.Find($"label{(int.Parse((sender as Control).Tag.ToString())) + 2}", false)[0].Visible = true;

        private void MouseLeftRoles(object sender, EventArgs e)
         => Controls.Find($"label{(int.Parse((sender as Control).Tag.ToString())) + 2}", false)[0].Visible = false;
    }
}
