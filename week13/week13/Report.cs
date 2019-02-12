using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace week13
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=giaodien;Integrated Security=True");
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from NhanVien n join Phong p on n.Phong = p.Phong",conn);
            DataTable tbl = new DataTable();
            adapt.Fill(tbl);
            nVreport2.SetDataSource(tbl);
            crystalReportViewer1.ReportSource = nVreport2;
        }
    }
}
