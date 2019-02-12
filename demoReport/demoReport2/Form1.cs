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

namespace demoReport2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataTable tbl;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Company;Integrated Security=True");
            conn.Open();
             adapt= new SqlDataAdapter("SELECT PHONGBAN.MaPhong, PHONGBAN.TenPhong, NhanVien.MaNV, NhanVien.Ho, NhanVien.TENLOT, NhanVien.Ten, NhanVien.Phong FROM NhanVien INNER JOIN PHONGBAN ON NhanVien.Phong = PHONGBAN.MaPhong ", conn);
            tbl = new DataTable();
            adapt.Fill(tbl);
          
            rptestgroup1.SetDataSource(tbl);
            viewer.ReportSource = rptestgroup1;
            adapt = new SqlDataAdapter("SELECT PHONGBAN.MaPhong, PHONGBAN.TenPhong, NhanVien.MaNV, NhanVien.Ho, NhanVien.TENLOT, NhanVien.Ten, NhanVien.Phong FROM NhanVien INNER JOIN PHONGBAN ON NhanVien.Phong = PHONGBAN.MaPhong ", conn);
            tbl = new DataTable();
            adapt.Fill(tbl);
            comboBox1.DataSource = tbl;
            comboBox1.DisplayMember = "TenPhong";
            comboBox1.ValueMember = "Phong";
            conn.Close();
           
        }

 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            adapt = new SqlDataAdapter("SELECT PHONGBAN.MaPhong, PHONGBAN.TenPhong, NhanVien.MaNV, NhanVien.Ho, NhanVien.TENLOT, NhanVien.Ten, NhanVien.Phong FROM NhanVien INNER JOIN PHONGBAN ON NhanVien.Phong = PHONGBAN.MaPhong where NhanVien.Phong= " + comboBox1.SelectedValue.ToString(), conn);
            tbl = new DataTable();
            adapt.Fill(tbl);

            rptestgroup1.SetDataSource(tbl);
            viewer.ReportSource = rptestgroup1;
            conn.Close();
        }
    }
}
