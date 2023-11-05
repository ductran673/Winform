using UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public static class Utility
    {
        

        static public bool IsOpeningForm(string formname)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name == formname)
                    return true;
            return false;
        }
    }
}
