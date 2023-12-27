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
            button1.Style(3.6f, Color.LightSkyBlue);
            button2.Style(3.6f, Color.LightSkyBlue);
            button3.Style(1.6f, Color.LightSkyBlue);
            button4.Style(1.6f, Color.LightSkyBlue);
        }
    }
}
