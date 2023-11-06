using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Model;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhâp", textBox1, textBox1.Width, 0, 1000);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", textBox2, textBox2.Width, 0, 1000);
                textBox2.Focus();   return;
            }
            using(var db = new Context())
            {
                Utility.Employee  = db.Administrators.SingleOrDefault(login => login.UserName == textBox1.Text && login.Password == textBox2.Text);
                if (Utility.Employee != null)
                {
                    var form = new LoginSuccess();
                    form.ShowDialog();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    var form = new LoginFailed();
                    form.ShowDialog();
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
