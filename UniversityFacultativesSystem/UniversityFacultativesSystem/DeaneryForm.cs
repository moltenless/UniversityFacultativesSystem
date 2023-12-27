using System;
using System.Drawing;
using System.Windows.Forms;
using UniversityFacultativesSystem.Properties;

namespace UniversityFacultativesSystem
{
    internal partial class DeaneryForm : Form
    {
        public DeaneryForm()
        {
            InitializeComponent();
            this.Style(3.6f, Color.LightSkyBlue);
            Icon = Resources.education_computer_school_graduate_cap_monitor_icon_149680;
            deaneryButton.Style(2f, Color.LightSkyBlue);
            closeButton.Style(1.6f, Color.LightSkyBlue);
            minimizeButton.Style(1.6f, Color.LightSkyBlue);
        }


        private void Close(object sender, EventArgs e) => this.Close();
        private void Minimize(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
    }
}
