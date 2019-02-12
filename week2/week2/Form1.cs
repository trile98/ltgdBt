using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
    public partial class Form1 : Form
    {
        float num1, num2,kq;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void radioNhan_CheckedChanged(object sender, EventArgs e)
        {
            num1 = float.Parse(txt1.Text);
            num2 = float.Parse(txt2.Text);
            kq = num1 * num2;
            txtKq.Text = kq.ToString();
        }

        private void radioChia_CheckedChanged(object sender, EventArgs e)
        {
            num1 = float.Parse(txt1.Text);
            num2 = float.Parse(txt2.Text);
            kq = num1 / num2;
            txtKq.Text = kq.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioTru_CheckedChanged(object sender, EventArgs e)
        {
            num1 = float.Parse(txt1.Text);
            num2 = float.Parse(txt2.Text);
            kq = num1 - num2;
            txtKq.Text = kq.ToString();
        }

        private void radioCong_CheckedChanged(object sender, EventArgs e)
        {
            num1 = float.Parse(txt1.Text);
            num2 = float.Parse(txt2.Text);
            kq = num1 + num2;
            txtKq.Text = kq.ToString();
        }

    }
}
