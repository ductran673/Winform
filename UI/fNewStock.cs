using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UI.Model;

namespace UI
{
    public partial class fNewStock : Form
    {

        Stock stock;

        public fNewStock()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Nút lưu
        private void button1_Click(object sender, EventArgs e)
        {
            stock = new Stock();
            stock.Name = txtStockname.Text;
            stock.Address = rStockAddress.Text;
            try
            {
                using (var db = new Context())
                {
                    db.Stocks.Add(stock);
                    db.SaveChanges();
                }
                txtStockname.Text = null;
                rStockAddress.Text = null;
                toolTip1.Show("Lưu thành công.", button1, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, button1, 0, 0, 1000);
            }
            txtStockname.Focus();
        }

        private void fNewStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
