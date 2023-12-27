using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityFacultativesSystem
{
    internal static class Program
    {
        internal static FormSwitcher FormSwitcher { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormSwitcher = new FormSwitcher(new PlaceHereYourInitialForm());
            Application.Run(FormSwitcher.ApplicationContext);
        }
    }
}
