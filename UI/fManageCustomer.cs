using Microsoft.EntityFrameworkCore;
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
    public partial class fManageCustomer : Form
    {
        public fManageCustomer()
        {
            InitializeComponent();
        }

        private void fManageCustomer_Activated(object sender, EventArgs e)
        {
            using (var connectDB = new Context())
            {
                dataGridView1.DataSource = connectDB.Customers.ToList();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditCustomer"))
                {
                    return;
                }
                fEditCustomer f = new fEditCustomer(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long CustomerID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value);
                    using (var connectDB = new Context())
                    {
                        Customer customer = connectDB.Customers.Single(c => c.CustomerID == CustomerID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + customer.Name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            connectDB.Customers.Remove(customer);
                            connectDB.SaveChanges();
                            fManageCustomer_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var connectDB = new Context())
            {
                dataGridView1.DataSource = connectDB.Customers.Where(c => c.Name.Contains(txtName.Text)).ToList();
            }

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewCustomer"))
            {
                return;
            }
            fNewCustomer f = new fNewCustomer();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
