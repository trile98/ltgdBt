using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week03
{
    public partial class Form1 : Form
    {
        int stt, stt1;
        List<int> dachon, dachon1;
        List<string> MonHoc= new List<string>();
        List<int> SoTinChi= new List<int>();
        List<double> HocPhi= new List<double>();
        int tongtc,tongtc1;
        double tongtien,tongtien1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stt = 0;
            stt1 = 0;
             MonHoc.AddRange( new string[] {"Toán","Lý","Hóa","Văn" , "Anh" });
            SoTinChi.AddRange(new int[] { 3, 2, 5, 2, 3 });
            HocPhi.AddRange(new double[] { 2000000, 3000000, 5000000, 1500000, 4000000 });
            dachon = new List<int>();
            dachon1 = new List<int>();
            listboxmon.Items.AddRange(MonHoc.ToArray());
            combomh.Items.AddRange(MonHoc.ToArray());
        }

        private void btndk_Click(object sender, EventArgs e)
        {
            
            if (dachon.Contains(combomh.Items.IndexOf(combomh.SelectedItem.ToString())))
            {
                lblthongbao.Text = "Môn học đã được đăng ký trước đó!!";
            }
            else
            {
                stt++;
                tongtien = 0;
                tongtc = 0;
                int thutuhientai = combomh.Items.IndexOf(combomh.SelectedItem.ToString());
                dachon.Add(thutuhientai);
                string mhdk = stt + "\t" + combomh.SelectedItem.ToString() + "\t" + SoTinChi[thutuhientai] + "\t" + HocPhi[thutuhientai];
                listBoxds.Items.Add(mhdk);
                lblsomon.Text = "Số môn: "+ dachon.Count();
                foreach (int i in dachon)
                {
                    tongtc += SoTinChi[i];
                    tongtien += HocPhi[i];
                }
                lblsotc.Text = "Số tín chỉ: "+ tongtc.ToString();
                lbltongtien.Text = "Tổng tiền: "+ tongtien.ToString();
            }
        }

        private void btndk1_Click(object sender, EventArgs e)
        {
            if (dachon1.Contains(MonHoc.IndexOf(listboxmon.SelectedItem.ToString())))
            {
                lblthongbao1.Text = "Môn học đã được đăng ký trước đó!!";
            }
            else
            {
                stt1++;
                tongtien1 = 0;
                tongtc1 = 0;
                int thutuhientai = MonHoc.IndexOf(listboxmon.SelectedItem.ToString());
                dachon1.Add(thutuhientai);
                string mhdk = stt1 + "\t" + listboxmon.SelectedItem.ToString() + "\t" + SoTinChi[thutuhientai] + "\t" + HocPhi[thutuhientai];
                listboxdachon.Items.Add(mhdk);
                listboxmon.Items.RemoveAt(listboxmon.Items.IndexOf(listboxmon.SelectedItem.ToString()));
                lblsomon1.Text = "Số môn: " + dachon1.Count();
                foreach (int i in dachon1)
                {
                    tongtc1 += SoTinChi[i];
                    tongtien1 += HocPhi[i];
                }
                lblsotc1.Text = "Số tín chỉ: " + tongtc1.ToString();
                lbltongtien1.Text = "Tổng tiền: " + tongtien1.ToString();
            }
        }
    }
}
