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
    public partial class LoginSuccess : Form
    {
        public LoginSuccess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void LoginSuccess_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
