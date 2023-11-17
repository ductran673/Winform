
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
    public partial class ReportListProduct : Form
    {
        public ReportListProduct()
        {
            InitializeComponent();
        }


        Context db = new Context();
        private void ReportListProduct_Load(object sender, EventArgs
           e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("DataSet1", db.Products.Select(p => new
           {
               p.ProductID,
               p.Name,
               p.Description,

           }).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath =
           Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\rListProduct.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

