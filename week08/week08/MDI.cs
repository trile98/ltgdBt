using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week08
{
    
    public partial class formmdi : Form
    {
        public formmdi()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog();
            if (openf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String path = openf.FileName;
                    FormPaint paint = new FormPaint(path);
                    paint.MdiParent = this;
                    paint.Show();
                }
                catch (Exception err)
                {
                    MessageBox.Show("error: " + err.Message);
                    throw;
                } 
            }
     
            
        }
    }
}
