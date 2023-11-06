using System.Data;
using UI.Model;


namespace UI
{
    public partial class AddImportBill : Form
    {
        private Context db = new Context();
        public event EventHandler addBill;
        public AddImportBill()
        {
            InitializeComponent();
        }

        private void AddImportBill_Load(object sender, EventArgs e)
        {
            // đổ dữ liệu cho combobox kho
            comboBoxStock.DisplayMember = "Name";
            comboBoxStock.ValueMember = "StockID";
            comboBoxStock.DataSource = db.Stocks.Select(stock => new { stock.Name, stock.StockID }).ToList();
            // đổ dữ liệu cho combobox sản phẩm
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxSuplier.Text))
            {
                toolTip1.Show("Vui lòng không để trống nhà cung cấp", maskedTextBoxSuplier, maskedTextBoxSuplier.Width, 0, 1000);
                maskedTextBoxSuplier.Focus();
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxEmail.Text))
            {
                toolTip1.Show("Vui lòng không để trống email", maskedTextBoxEmail, maskedTextBoxEmail.Width, 0, 1000);
                maskedTextBoxEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxAddress.Text))
            {
                toolTip1.Show("Vui lòng không để trống địa chỉ", maskedTextBoxAddress, maskedTextBoxAddress.Width, 0, 1000);
                maskedTextBoxAddress.Focus();
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxPhone.Text))
            {
                toolTip1.Show("Vui lòng không để trống số điện thoại", maskedTextBoxPhone, maskedTextBoxPhone.Width, 0, 1000);
                maskedTextBoxPhone.Focus();
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxDescription.Text))
            {
                toolTip1.Show("Vui lòng không để trống mô tả", maskedTextBoxDescription, maskedTextBoxDescription.Width, 0, 1000);
                maskedTextBoxDescription.Focus();
                return;
            }
            try
            {
                int stockID = Convert.ToInt32(comboBoxStock.SelectedValue);
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
                addBill?.Invoke(this, EventArgs.Empty);
                toolTip1.Show("Tạo thành công", button2, button2.Width, 0, 2000);
                maskedTextBoxSuplier.Text = null;
                maskedTextBoxAddress.Text = null;
                maskedTextBoxEmail.Text = null;
                maskedTextBoxPhone.Text = null;
                maskedTextBoxDescription.Text = null;


            }
            catch (Exception err)
            {
                toolTip1.Show("Error: " + err.Message, button2, button2.Width, 0, 2000);
            }
        }

        private void AddImportBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void comboBoxStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stockID = Convert.ToInt32(comboBoxStock.SelectedValue);
            maskedTextBoxStockAddress.Text = db.Stocks.Where(stock => stock.StockID == stockID).Select(stock => new { stock.Address }).SingleOrDefault().Address.ToString();
        }

        private void maskedTextBoxSuplier_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxSuplier.Text))
            {
                toolTip1.Show("Vui lòng không để trống nhà cung cấp", maskedTextBoxSuplier, maskedTextBoxSuplier.Width, 0, 1000);
                e.Cancel= true;
            }
        }

        private void maskedTextBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxEmail.Text))
            {
                toolTip1.Show("Vui lòng không để trống email", maskedTextBoxEmail, maskedTextBoxEmail.Width, 0, 1000);
                e.Cancel = true;
            }
        }

        private void maskedTextBoxAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxAddress.Text))
            {
                toolTip1.Show("Vui lòng không để trống địa chỉ", maskedTextBoxAddress, maskedTextBoxAddress.Width, 0, 1000);
                e.Cancel = true;
            }
        }

        private void maskedTextBoxPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxPhone.Text))
            {
                toolTip1.Show("Vui lòng không để trống số điện thoại", maskedTextBoxPhone, maskedTextBoxPhone.Width, 0, 1000);
                e.Cancel = true;
                return;
            }
            if(maskedTextBoxPhone.Text.Length != 10)
            {
                toolTip1.Show("Số điện thoại phải 10 ký tự", maskedTextBoxPhone, maskedTextBoxPhone.Width, 0, 1000);
                e.Cancel = true;
                return;
            }
        }

        private void maskedTextBoxDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxDescription.Text))
            {
                toolTip1.Show("Vui lòng không để trống mô tả", maskedTextBoxDescription, maskedTextBoxDescription.Width, 0, 1000);
                e.Cancel = true;
            }
        }
    }
}
