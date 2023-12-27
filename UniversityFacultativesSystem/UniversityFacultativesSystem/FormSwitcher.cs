using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityFacultativesSystem
{
    internal class FormSwitcher
    {
        public FormSwitcher(Form initialForm)
        {
            ApplicationContext = new ApplicationContext(initialForm);
        }

        public ApplicationContext ApplicationContext { get; }

        public void GoTo(Form _new)
        {
            Form old = ApplicationContext.MainForm;
            ApplicationContext.MainForm = _new;
            old.Close();
            _new.Show();
        }
    }
}
