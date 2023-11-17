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
    public partial class ReportBieudo : Form
    {
        public ReportBieudo()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void ReportBieudo_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("DataSet1", db.StockDetails.Select(p => new {
             p.Quantity,
             
             

           }).ToList()));
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("DataSet2", db.Products.Select(p => new {
               p.ProductID

           }).ToList()));

            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath =
           Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\rBieudo.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();

        }
    }
}
