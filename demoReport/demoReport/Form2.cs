using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoReport
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)

        {
            
        }

        private void crviewer_Load(object sender, EventArgs e)
        {
            ReportDocument rptdoc = new ReportDocument();
            rptdoc.Load("C:\\Users\\Nguyen Le\\source\\repos\\demoReport\\demoReport\\CrystalrptNV.rpt");
            rptdoc.SetDataSource(datasetNV1);
            crviewer.ReportSource = rptdoc;
            crviewer.Refresh();
        }
    }
}
