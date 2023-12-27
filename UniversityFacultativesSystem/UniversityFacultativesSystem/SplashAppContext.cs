using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityFacultativesSystem
{
    public class SplashAppContext : ApplicationContext
    {
        Form mainForm = null;
        Timer splashTimer = new Timer();

        public SplashAppContext(Form mainForm, Form splashForm) : base(splashForm)
        {
            this.mainForm = mainForm;

            splashTimer.Tick += new EventHandler(SplashTimeUp);
            splashTimer.Interval = 5000;
            splashTimer.Enabled = true;
        }

        private void SplashTimeUp(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            splashTimer.Dispose();

            base.MainForm.Close();
        }

        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            if (sender is Form2)
            {
                base.MainForm = this.mainForm;
                base.MainForm.Show();
            }
            else if (sender is Form1)
            {
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
