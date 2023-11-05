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
    public partial class fManageProduct : Form
    {
        public fManageProduct()
        {
            InitializeComponent();
        }

        private void fManageProduct_Activated(object sender, EventArgs e)
        {
            using (var connectDB = new Context())
            {
                dataGridView1.DataSource = connectDB.Products.ToList();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditProduct"))
                    return;
                fEditProduct f = new fEditProduct(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long ProductID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                    using (var connectDB = new Context())
                    {
                        Product Product = connectDB.Products.Single(c => c.ProductID == ProductID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + Product.Name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            connectDB.Products.Remove(Product);
                            connectDB.SaveChanges();
                            fManageProduct_Activated(sender, e);
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
                dataGridView1.DataSource = connectDB.Products.Where(c => c.Name.Contains(txtName.Text)).ToList();
            }

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewProduce"))
            {
                return;
            }
            fNewProduct f = new fNewProduct();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        
    }
}
