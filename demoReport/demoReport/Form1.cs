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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crpNV_Load(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Company;Integrated Security=True");
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from NhanVien", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            crystalrptNV1.SetDataSource(ds.Tables[0]);
            crpNV.ReportSource = crystalrptNV1;

        }

        private void CrystalrptNV1_InitReport(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
