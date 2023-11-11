using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
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
        private long StockID;
        private int ProductID;
        private Context db = new Context();
        DataTable table = new DataTable();
        //SqlConnection connection;
        //SqlCommand command;
        //string str = @"Data Source=MSI\MINHNGO;Initial Catalog=QLKH;Integrated Security=True";
        //SqlDataAdapter adapter = new SqlDataAdapter();


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Xóa kho
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long StockID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDKho"].Value);
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
                fEditStock f = new fEditStock((Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["IDKho"].Value)));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        //void loadDataStockDetail()
        //{
        //    command = connection.CreateCommand();
        //    command.CommandText = "select StockDetails.StockDetailID, StockDetails.ProductID, Products.Name, Products.Description, Units.Name from Products, StockDetails,Units where StockDetails.ProductID = Products.ProductID and StockDetails.UnitID = Units.UnitID";
        //    //command.CommandText = "select * from StockDetails";
        //    adapter.SelectCommand = command;
        //    table.Clear();
        //    adapter.Fill(table);
        //    dataGridView2.DataSource = table;
        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //connection = new SqlConnection(str);
            //connection.Open();
            //loadDataStockDetail();
            using (var db = new Context())
            {
                StockID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["IDKho"].Value);
                //ProductID = db.StockDetails.Where(x => x.StockID == StockID).Select(x => x.StockID);
                dataGridView2.DataSource = db.StockDetails.Where(x => x.StockID == StockID).Select(x => new
                {
                    x.StockID,
                    x.ProductID,
                    x.Product.Name,
                    x.Product.Description,
                    x.Product.Price
                }).ToList();
            }
        }
    }
}
