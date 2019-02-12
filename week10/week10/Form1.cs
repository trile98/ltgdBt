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

namespace week10
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=giaodien;Integrated Security=True");
            conn.Open();
            adapter = new SqlDataAdapter("select * from NhanVien", conn);
            DataTable datatbl = new DataTable();
            adapter.Fill(datatbl);
            conn.Close();

            gridview.DataSource = datatbl;
            conn.Close();
            gridview.Columns["DiaChi"].Width = 200;

            //gridview.Columns["Ms"].HeaderText = "Mã Số";
            //gridview.Columns["Ten"].HeaderText = "Tên";
            //gridview.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            //gridview.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            //gridview.Columns["Sdt"].HeaderText = "Số Điện Thoại";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            command = conn.CreateCommand();
            foreach (DataGridViewRow i in gridview.SelectedRows)
            {
                command.CommandText = "delete from NhanVien where Ms=" + i.Cells["Ms"].Value.ToString();
                command.ExecuteNonQuery();
              
                gridview.Rows.Remove(i);
            }
            conn.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //Int16.Parse(dateTimePicker1.Value.Day.ToString()) + "/" + Int16.Parse(dateTimePicker1.Value.Month.ToString()) + "/" + Int32.Parse(dateTimePicker1.Value.Year.ToString())
            conn.Open();
            command = conn.CreateCommand();

            command.CommandText = "Insert into NhanVien values('" + txtms.Text + "','" + txtten.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + txtsdt.Text + "','" + txtdc.Text + "')";

            //command.CommandText = "Insert into NhanVien values(@MS,@Ten,@NS,@sdt,@dc);";
            //command.Parameters.AddWithValue("@MS", txtms.Text);
            //command.Parameters.AddWithValue("@Ten", txtten.Text);
            //command.Parameters.AddWithValue("@NS", dateTimePicker1.Value.ToShortDateString());
            //command.Parameters.AddWithValue("@sdt", txtsdt.Text);
            //command.Parameters.AddWithValue("@dc", txtdc.Text);

            command.ExecuteNonQuery();

            adapter = new SqlDataAdapter("select * from NhanVien", conn);
            DataTable datatbl = new DataTable();
            adapter.Fill(datatbl);
            gridview.DataSource = datatbl;
            conn.Close();
        }
    }
}
