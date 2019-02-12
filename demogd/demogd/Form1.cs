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

namespace demogd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Company;Integrated Security=True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from NhanVien",conn);
            DataTable tbl = new DataTable();
            adapt.Fill(tbl);
            crystal.SetDataSource(tbl);
            view.ReportSource=crystal;
        }

        public Form1(string sdk)
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Company;Integrated Security=True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from NhanVien where TEN LIKE '%"+sdk+"%'", conn);
            DataTable tbl = new DataTable();
            adapt.Fill(tbl);
            crystal.SetDataSource(tbl);
            view.ReportSource = crystal;
        }
    }
}
