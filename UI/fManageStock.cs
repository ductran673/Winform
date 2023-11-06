using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class fManageStock : Form
    {
        private long stockID;

        public fManageStock()
        {
            InitializeComponent();
        }

        private void fManageStock_Load(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                // Cập nhật dữ liệu combobox chọn kho
                cbStock.DisplayMember = "Name";
                cbStock.ValueMember = "StockID";
                cbStock.DataSource = db.Stocks.OrderBy(c => c.StockID).Select(c => new { c.Name, c.StockID }).ToList();

            }
        }

        private void cbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                stockID = Convert.ToInt64(cbStock.SelectedValue);
                dataGridView1.DataSource = db.Stocks.Where(p => p.StockID == stockID).Select(p => new
                {
                    p.StockID,
                    p.Name,
                    p.Address,
                }).ToList();
                lbsoluongkho.Text = "Số lượng kho: " + dataGridView1.Rows.Count;
            }
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewStock"))
            {
                return;
            }
            fNewStock f = new fNewStock();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void fManageStock_Activated(object sender, EventArgs e)
        {
            cbStock_SelectedIndexChanged(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StockDetail stockDetail = new StockDetail();
            Product product = new Product();
            Unit unit = new Unit();
            string nameunit;
            nameunit = unit.Name;
            ;
            using (var db = new Context())
            {
                dataGridView2.DataSource = db.StockDetails.Where(c => c.StockID == stockID).Select(c => new
                {
                    stockID,
                    product.ProductID,
                    product.Name,
                    product.Description,
                    nameunit
                }).ToList();
                //dataGridView2.DataSource = db.StockDetails.Where(p => p.StockID == stockID).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Xóa kho
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long StockID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StockID"].Value);
                    using (var db = new Context())
                    {
                        Stock stock = db.Stocks.Single(c => c.StockID == StockID);
                        if (MessageBox.Show("Bạn muốn xóa " + stock.Name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Stocks.Remove(stock);
                            db.SaveChanges();
                            fManageStock_Activated(sender, e);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }

            //Sửa kho
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditStock"))
                {
                    return;
                }
                fEditStock f = new fEditStock((Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["StockID"].Value)));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}
