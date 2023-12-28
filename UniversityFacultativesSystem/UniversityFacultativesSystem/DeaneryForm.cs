using System;
using System.Drawing;
using System.Windows.Forms;
using UniversityFacultativesDAL.Service;
using UniversityFacultativesSystem.Properties;

namespace UniversityFacultativesSystem
{
    internal partial class DeaneryForm : Form
    {
        DataService service;

        public DeaneryForm(string user, string password)
        {
            InitializeComponent();
            Icon = Resources.education_computer_school_graduate_cap_monitor_icon_149680;
            closeButton.Style(1.6f, Color.LightSkyBlue);
            minimizeButton.Style(1.6f, Color.LightSkyBlue);
            buttonQuit.Style(1.6f, Color.LightSkyBlue);


            service = new DataService(user, password);



        }

        private void Close(object sender, EventArgs e) => this.Close();
        private void Minimize(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void ClosingForm(object sender, FormClosingEventArgs e) => service.Close();
        private void Quit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете вийти з облікового запису?", "Вихід з облікового запису", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
                Program.GoTo(new StartForm());
        }

        private void Tab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage
        }
    }
}
