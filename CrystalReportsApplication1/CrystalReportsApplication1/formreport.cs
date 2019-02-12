using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalReportsApplication1
{
    public partial class formreport : Form
    {
        public formreport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
         
        }

        private void formreport_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer3_Load(object sender, EventArgs e)
        {
            ReportDocument redoc = new ReportDocument();
            redoc.Load("C:\\Users\\Nguyen Le\\source\\repos\\CrystalReportsApplication1\\CrystalReportsApplication1\\CrystalReport2.rpt");
            redoc.SetDataSource(new DataSet1());
            viewer.ReportSource = redoc;
            viewer.Refresh();

        }

        private void reportdoc_InitReport(object sender, EventArgs e)
        {

        }
    }
}
