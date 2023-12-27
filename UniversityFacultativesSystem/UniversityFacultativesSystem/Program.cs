using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityFacultativesSystem
{
    internal static class Program
    {
        private static ApplicationContext applicationContext;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            applicationContext = new ApplicationContext(new StartForm());
            Application.Run(applicationContext);
        }

        internal static void GoTo(Form _new)
        {
            Form old = applicationContext.MainForm;
            applicationContext.MainForm = _new;
            old.Close();
            _new.Show();
        }
    }
}
