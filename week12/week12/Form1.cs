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

namespace week12
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapt;
        SqlDataReader reader;
        SqlCommand command;
        DataTable table;

        public void Filltable(string query)
        {
            adapt = new SqlDataAdapter(query, conn);
            table = new DataTable();
            adapt.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        public Form1()
        {
            InitializeComponent();

            conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=giaodien;Integrated Security=True");
            conn.Open();
            adapt = new SqlDataAdapter("select * from SinhVien join Nganh on (SinhVien.MaNganh=Nganh.MaNganh)", conn);
            table = new DataTable();
            adapt.Fill(table);
            dataGridView1.DataSource = table;

            adapt = new SqlDataAdapter("select * from Nganh", conn);
            table = new DataTable();
            adapt.Fill(table);
            cmbnganh.DataSource = table;
            cmbnganh.DisplayMember = "TenNganh";
            cmbnganh.ValueMember = "MaNganh";
            conn.Close();

        }

       

       

        private void txttimten_MouseClick(object sender, MouseEventArgs e)
        {
            txttimten.Text = "";
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from SinhVien join Nganh on (SinhVien.MaNganh=Nganh.MaNganh) where HoTen=N'" + txttimten.Text+"'";
            Filltable(query);
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = conn.CreateCommand();
            foreach (DataGridViewRow i in dataGridView1.SelectedRows)
            {
                command.CommandText = "delete from SinhVien where Maso=" + i.Cells["Maso"].Value.ToString();
                command.ExecuteNonQuery();

                dataGridView1.Rows.Remove(i);
            }
            conn.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = conn.CreateCommand();
            command.CommandText = "insert into SinhVien values('" + txtms.Text + "',N'" + txtten.Text + "',N'" + txtgioitinh.Text + "','" + cmbnganh.SelectedValue.ToString() + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + float.Parse(txtdiem.Text) + "')";
            command.ExecuteNonQuery();

            string query = "select * from SinhVien join Nganh on (SinhVien.MaNganh=Nganh.MaNganh)";
            Filltable(query);
        }


        private void cmbnganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string query = "select * from SinhVien join Nganh on (SinhVien.MaNganh=Nganh.MaNganh) where Nganh.MaNganh='" + cmbnganh.SelectedValue.ToString() + "'";
            Filltable(query);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = conn.CreateCommand();
            command.CommandText = "update SinhVien set Maso='" + txtms.Text + "',HoTen=N'" + txtten.Text + "',GioiTinh=N'" + txtgioitinh.Text + "',MaNganh='" + cmbnganh.SelectedValue.ToString() + "',NgaySinh='" + dateTimePicker1.Value.ToShortDateString() + "',Diem='" + float.Parse(txtdiem.Text) + "' where Maso='" + txtms.Text + "'";
            command.ExecuteNonQuery();

            string query = "select * from SinhVien join Nganh on (SinhVien.MaNganh=Nganh.MaNganh)";
            Filltable(query);
        }
    }
}
