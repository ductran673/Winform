using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.View
{
    public partial class ReportListImportBill : Form
    {
        public ReportListImportBill()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void ReportListImportBill_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("DataSet1", db.ImportBills.Select(p => new {
               p.ImportBillID,
               p.AdministratorID,
               p.CustomerID,
               p.StockID,
               p.Description

           }).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath =
           Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\rListImportBill.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();

        }
    }
}
