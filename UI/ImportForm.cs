﻿using System.Data;
using UI.Model;

namespace UI
{
    public partial class ImportForm : Form
    {
        private Context db = new Context();
        private long productID;
        private int stockID;
        private string productName;
        private List<ImportProduct> importProducts = new List<ImportProduct>();
        private DataTable dataTable = new DataTable();
        private bool btnDelete = false;
        private int IDADMIN;
        private int UnitID;
        private int total;
        public ImportForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // đổ dữ liệu cho combobox kho
            comboBoxStock.DisplayMember = "Name";
            comboBoxStock.ValueMember = "StockID";
            comboBoxStock.DataSource = db.Stocks.Select(stock => new {stock.Name, stock.StockID}).ToList();
            // đổ dữ liệu cho combobox sản phẩm
            comboBoxProduct.DisplayMember = "Name";
            comboBoxProduct.ValueMember = "ProductID";
            comboBoxProduct.DataSource = db.Products.Select(product => new {product.Name, product.ProductID}).ToList();
            // đổ dữ liệu cho combobox đơn vị
            comboBoxUnit.DisplayMember = "Name";
            comboBoxUnit.ValueMember = "UnitID";
            comboBoxUnit.DataSource = db.Units.Select(unit => new {unit.Name, unit.UnitID}).ToList();
            // Validating
            maskedTextBoxPrice.ValidatingType = typeof(Int32);
            maskedTextBoxQuantity.ValidatingType = typeof(Int32);
            // add columns cho datagridview
            dataTable.Columns.Add("Mã sản phẩm", typeof(long));
            dataTable.Columns.Add("Tên sản phẩm", typeof(string));
            dataTable.Columns.Add("Giá tiền", typeof(int));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataGridView1.DataSource = dataTable;
            // hiển thị tên admin

        }
        private void button1_Click(object sender, EventArgs e)
        {
            productID = Convert.ToInt64(comboBoxProduct.SelectedValue);
            productName = comboBoxProduct.Text;
            importProducts.Add(new ImportProduct { ProductID = productID, ProductName = productName, PriceProduct = Convert.ToInt32(maskedTextBoxPrice.Text), Quantity = Convert.ToInt32(maskedTextBoxQuantity.Text), UnitID = UnitID});
            dataTable.Rows.Add(productID, productName, Convert.ToInt32(maskedTextBoxPrice.Text), Convert.ToInt32(maskedTextBoxQuantity.Text));
            dataGridView1.DataSource = dataTable;
            toolTip1.Show("Thêm thành công", button1, button1.Width, 0, 1000);
            foreach(ImportProduct i in importProducts)
            {
                total += i.TotalPrice;
            }
            textBox1.Text = total.ToString() + "đ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            productName = comboBoxProduct.Text.ToString();
            productID = Convert.ToInt32(comboBoxProduct.SelectedValue);
        }

        private void comboBoxStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockID = Convert.ToInt32(comboBoxStock.SelectedValue);
            maskedTextBoxStockAddress.Text = db.Stocks.Where(stock => stock.StockID == stockID).Select(stock => new { stock.Address }).SingleOrDefault().Address.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDelete.Enabled = true;
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            importProducts.RemoveAt(rowIndex);
            toolTip1.Show("remove: " + importProducts.Count.ToString(), buttonDelete, 0, 0, 2000);
            if(importProducts.Count == 0)
            {
                buttonDelete.Enabled =false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = maskedTextBoxSuplier.Text;
            customer.Address = maskedTextBoxAddress.Text;
            customer.Email = maskedTextBoxEmail.Text;
            customer.Phone = maskedTextBoxPhone.Text;
            db.Customers.Add(customer);
            db.SaveChanges();
            ImportBill importBill = new ImportBill();
            importBill.Description = maskedTextBoxDescription.Text.ToString();
            importBill.AdministratorID = 1;
            importBill.StockID = stockID;
            importBill.DateTimeDate = dateTimePickerCreateBill.Value.Date;
            importBill.CustomerID = customer.CustomerID;
            db.ImportBills.Add(importBill);
            db.SaveChanges();
            foreach (ImportProduct import in importProducts)
            {
                ImportDetail importDetail = new ImportDetail();
                importDetail.ProductID = import.ProductID;
                importDetail.Price = import.PriceProduct;
                importDetail.Quantity = import.Quantity;
                importDetail.ImportBillID = importBill.ImportBillID;
                db.ImportDetail.Add(importDetail);
                db.SaveChanges();
                StockDetail stockDetail = new StockDetail();
                stockDetail.StockID = stockID;
                stockDetail.ProductID = import.ProductID;
                stockDetail.UnitID = import.UnitID;
                stockDetail.Quantity = import.Quantity;
                db.StockDetails.Add(stockDetail);
                db.SaveChanges();
            }
        }

        private void comboBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitID = Convert.ToInt32(comboBoxStock.SelectedValue);
        }
    }
}