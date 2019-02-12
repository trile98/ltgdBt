using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week13
{
    public partial class Form1 : Form
    {
        List<NV_DTO> lnv = new List<NV_DTO>();
        List<Phong_DTO> lphong = new List<Phong_DTO>();

        public Form1()
        {
            InitializeComponent();
            
            lnv = NV_BUS.LoadData();
            lphong = Phong_BUS.LoadData();

            gridviewer.DataSource = lnv;
            cmbphong.DataSource = lphong;
            cmbphong.DisplayMember = "TenPhong";
            cmbphong.ValueMember = "Phong";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            NV_DTO nv = new NV_DTO();
            nv.MS = txtms.Text;
            nv.Ten = txtten.Text;
            nv.NS = pickns.Value.ToShortDateString();
            nv.SDT = txtsdt.Text;
            nv.DC = txtdc.Text;
            nv.Phong = int.Parse(cmbphong.SelectedValue.ToString());
            if (NV_BUS.AddNV(nv))
            {
                MessageBox.Show("Thêm Thành Công!!");
                lnv = NV_BUS.LoadData();
                gridviewer.DataSource = lnv;
            }
            else
                MessageBox.Show("Thêm Không Thành Công!!");

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in gridviewer.SelectedRows)
            {
                if (NV_BUS.DeleteNV(item.Cells["Ms"].Value.ToString()))
                {
                    MessageBox.Show("Xóa Thành Công!!");
                    lnv = NV_BUS.LoadData();
                    gridviewer.DataSource = lnv;
                }
                else
                    MessageBox.Show("Xóa Không Thành Công!!");

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NV_DTO nv = new NV_DTO();
            nv.MS = txtms.Text;
            nv.Ten = txtten.Text;
            nv.NS = pickns.Value.ToShortDateString();
            nv.SDT = txtsdt.Text;
            nv.DC = txtdc.Text;
            nv.Phong = int.Parse(cmbphong.SelectedValue.ToString());
            if (NV_BUS.UpdateNV(nv))
            {
                MessageBox.Show("Sửa Thành Công!!");
                lnv = NV_BUS.LoadData();
                gridviewer.DataSource = lnv;
            }
            else
                MessageBox.Show("Sửa Không Thành Công!!");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            Report rpt = new Report();
            rpt.Show();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            lnv = NV_BUS.LoadData(txttim.Text);
            lphong = Phong_BUS.LoadData();

            gridviewer.DataSource = lnv;
        }
    }
}
