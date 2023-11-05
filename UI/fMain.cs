using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageCustomer"))
            {
                return;

            }
            fManageCustomer f = new fManageCustomer();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("ImportForm"))
            {
                return;

            }
            ImportForm  f = new ImportForm();
            f.MdiParent = this;
            f.Show();

        }
    }
}
