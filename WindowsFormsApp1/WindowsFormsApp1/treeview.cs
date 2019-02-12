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
    public partial class treeview : Form
    {
        TreeNode node;
        public treeview()
        {
            InitializeComponent();
        }

    

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            int check=0;
            foreach (TreeNode i in treeviewSV.Nodes)
            {
                if (i.Text.CompareTo(txtMa.Text.ToString()) == 0)
                {
                    
                    i.Nodes[0].Text = txtTen.Text;
                    i.Nodes[1].Text = txtDc.Text;
                    i.Nodes[2].Text = datetimeNS.Value.ToString();
                    i.Nodes[3].Text = cmbLop.Text;
                    check = 1;
                }
            }

            if (check == 0)
            {
                treeviewSV.Nodes.Add(txtMa.Text.ToString());
                int sl = treeviewSV.Nodes.Count-1;
                treeviewSV.Nodes[sl ].Nodes.Add(txtTen.Text.ToString());
                treeviewSV.Nodes[sl].Nodes.Add(txtDc.Text.ToString());
                treeviewSV.Nodes[sl].Nodes.Add(datetimeNS.Value.ToString());
                treeviewSV.Nodes[sl].Nodes.Add(cmbLop.Text.ToString());

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            
            txtDc.Text = "";
            cmbLop.Text = "";
            txtTen.Text = "";
            datetimeNS.Value = DateTime.Now;
        }

        private void rename_Click(object sender, EventArgs e)
        {
            treeviewSV.LabelEdit = true;
            treeviewSV.SelectedNode.BeginEdit();
        }

        private void deletenode_Click(object sender, EventArgs e)
        {
            treeviewSV.SelectedNode.Remove();
        }

        private void deleteall_Click(object sender, EventArgs e)
        {
            treeviewSV.Nodes.Clear();
        }

      
    }
}
