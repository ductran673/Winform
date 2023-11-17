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
    public partial class ReportListExportBill  : Form
    {
        public ReportListExportBill()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void ReportListExportBill_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("DataSet1", db.ExportBills.Select(p => new {
               p.ExportBillID,
               p.AdministratorID,
               p.CustomerID,
               p.CreateDate,
               p.Description

           }).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath =
           Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\rListExportBill.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();

        }
    }
}
