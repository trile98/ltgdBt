using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Listview : Form
    {
        public Listview()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            int check = 0;
            ListViewItem masv = new ListViewItem(txtMa.ToString());
            foreach (ListViewItem i in listSV.Items)
            {
                if (masv.Text.CompareTo(i.Text)==0)
                {
                    i.SubItems[0].Text=txtTen.Text;
                    i.SubItems[1].Text=txtDc.Text;
                    i.SubItems[2].Text=datetimeNS.Value.ToString();
                    i.SubItems[3].Text=cmbLop.Text;
                    check = 1;
                }
            }
                if (check == 0)
                {
                    listSV.Items.Add(masv);
                    masv.SubItems.Add(txtTen.Text);
                    masv.SubItems.Add(txtDc.Text);
                    masv.SubItems.Add(datetimeNS.Value.ToString());
                    masv.SubItems.Add(cmbLop.Text);
                }
        }
    }
}
