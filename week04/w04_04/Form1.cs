using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04_04
{
    public partial class Form1 : Form
    {
        string thang;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime(int.Parse(numericUpDownNam.Value.ToString()), int.Parse(numericUpDownThang.Value.ToString()), int.Parse(numericUpDownNgay.Value.ToString()));
            string thu = d.DayOfWeek.ToString();

            switch (int.Parse(numericUpDownThang.Value.ToString()))
            {
                case 1:
                    thang = "Tháng một";
                    break;
                case 2:
                    thang = "Tháng hai";
                    break;
                case 3:
                    thang = "Tháng ba";
                    break;
                case 4:
                    thang = "Tháng tư";
                        break;
                case 5:
                    thang = "Tháng năm";
                    break;
                case 6:
                    thang = "Tháng sáu";
                    break;
                case 7:
                    thang = "Tháng bảy";
                    break;
                case 8:
                    thang = "Tháng tám";
                    break;
                case 9:
                    thang = "Tháng chín";
                    break;
                case 10:
                    thang = "Tháng mười";
                    break;
                case 11:
                    thang = "Tháng mười một";
                    break;
                case 12:
                    thang = "Tháng mười hai";
                    break;

            }

            if (thu.CompareTo("Monday") == 0)
                thu = "Thứ hai";
            if (thu.CompareTo("Tuesday") == 0)
                thu = "Thứ ba";
            if (thu.CompareTo("Wednesday") == 0)
                thu = "Thứ tư";
            if (thu.CompareTo("Thursday") == 0)
                thu = "Thứ năm";
            if (thu.CompareTo("Friday") == 0)
                thu = "Thứ sáu";
            if (thu.CompareTo("Saturday") == 0)
                thu = "Thứ bảy";
            if (thu.CompareTo("Sonday") == 0)
                thu = "Chủ Nhật";

            grplich.Text += " "+numericUpDownNam.Value.ToString();
            lblthang.Text = thang;
            lblthu.Text = thu;
            lblngay.Text = numericUpDownNgay.Value.ToString();
        }

        private void numericUpDownNam_ValueChanged(object sender, EventArgs e)
        {
            if (double.Parse(numericUpDownNam.Value.ToString()) % 400 == 0||(double.Parse(numericUpDownNam.Value.ToString()) % 4 == 0 && double.Parse(numericUpDownNam.Value.ToString()) % 100 != 0))
            {
                switch (numericUpDownThang.Value)
                {
                    case 2:
                        numericUpDownNgay.Maximum = 29;
                        break;
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        numericUpDownNgay.Maximum = 31;
                        break;
                    default:
                        numericUpDownNgay.Maximum = 30;
                        break;
                }
               
               }
            else
            {
                switch (numericUpDownThang.Value)
                {
                    case 2:
                        numericUpDownNgay.Maximum = 28;
                        break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        numericUpDownNgay.Maximum = 31;
                        break;
                    default:
                        numericUpDownNgay.Maximum = 30;
                        break;
                }
            }
        }

        private void numericUpDownNgay_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownThang_ValueChanged(object sender, EventArgs e)
        {

            if (numericUpDownNgay.Value > numericUpDownNgay.Maximum)
                numericUpDownNgay.Value = numericUpDownNgay.Maximum;
        }
    }
}
