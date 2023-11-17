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

namespace QuanLyKho
{
    public partial class ReportPhieu : Form
    {
        public ReportPhieu()
        {
            InitializeComponent();
        }


        Context db = new Context();
        private void ReportPhieu_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            reportViewer.LocalReport.DataSources.Add(new
           ReportDataSource("DataSet1", db.Administrators.Select(p => new
           {
               p.AdministratorID,
               p.UserName,
               p.Email,
               p.Phone

           }).ToList()));
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.LocalReport.ReportPath =
           Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
           "\\rPhieu.rdlc";
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();


        }

    }
}
