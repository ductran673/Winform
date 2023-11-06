using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Model;

namespace UI
{
    internal class Utility
    {
        public static Administrator Employee { get; set; }
        public static bool isOpeningForm(string nameForm)
        {
            foreach (Form f in Application.OpenForms)
            {
                if ((string)f.Name == nameForm) return true;
            }
            return false;
        }
    }
}
