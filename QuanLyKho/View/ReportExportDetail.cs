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
    public partial class ReportExportDetail : Form
    {
        public ReportExportDetail()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void ReportExportDetail_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("DataSet1", db.ExportBillDetails.Select(p => new
           {
               p.ExportBillDetailID,
               p.ExportBillID,
               p.exportProductDetails,


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
