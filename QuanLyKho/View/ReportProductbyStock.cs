
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
    public partial class ReportProductbyStock : Form
    {
        public ReportProductbyStock()
        {
            InitializeComponent();
        }


        Context db = new Context();
        private void ReportProductbyStock_Load(object sender, EventArgs
           e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };

            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("DataSet", db.StockDetails.Select(p => new
           {
               p.ProductID,
               p.StockID,
               p.Quantity


           }).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath =
           Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\rProductbyStock.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();
        }

        
    }
}

