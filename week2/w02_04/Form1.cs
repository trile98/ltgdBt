using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02_04
{
    public partial class Form1 : Form
    {
        double tongtien;
        int slkh;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double tien = 0;
            if (checkden.Checked == true)
                tien += 20000;
            if (checkSua.Checked == true)
                tien += 25000;
            if (checkDa.Checked == true)
                tien += 25000;
            if (checkSuaDa.Checked == true)
                tien += 30000;
            if (checkKem.Checked == true)
                tien += 35000;
            if (checksv.Checked == true)
                tien *= 0.8;
            MessageBox.Show(tien.ToString());
            tongtien += tien;
            slkh++;
        }

        private void btnTToan_Click(object sender, EventArgs e)
        {
            txttien.Text = tongtien.ToString();
            txtkh.Text = slkh.ToString();
            txtten.Text = "";
            checksv.Checked = false;
            checkden.Checked = false;
            checkSua.Checked = false;
            checkDa.Checked = false;
            checkSuaDa.Checked = false;
            checkKem.Checked = false;
            //btnNhap.Enabled = false;
            //btnTinh.Enabled = false;
            //btnTToan.Enabled = false;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtten.Text = "";
            checksv.Checked = false;
            checkden.Checked = false;
            checkSua.Checked = false;
            checkDa.Checked = false;
            checkSuaDa.Checked = false;
            checkKem.Checked = false;
            //btnNhap.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr==DialogResult.Yes)
                Close();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    if(txtten.Text.CompareTo("")!=0)
        //    {
        //        btnNhap.Enabled = true;
        //        btnTinh.Enabled = true;
        //        btnTToan.Enabled = true;
        //    }
        //    else
        //    {
        //        btnNhap.Enabled = false;
        //        btnTinh.Enabled = false;
        //        btnTToan.Enabled = false;
        //    }
                
        //}
    }
}
