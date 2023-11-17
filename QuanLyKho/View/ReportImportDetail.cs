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
    public partial class ReportImportDetail : Form
    {
        public ReportImportDetail()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void ReportImportDetail_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("DataSet1", db.ImportDetail.Select(p => new {
               p.ImportDetailID,
               p.ImportBillID,
               p.Quantity,
               p.ProductID,
               p.Price

           }).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath =
           Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\rImportDetail.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();

        }
    }
}
