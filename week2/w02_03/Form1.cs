using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioTime_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Font = new Font("Times New Roman", txt1.Font.Size);
        }

        private void radioAr_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Font = new Font("Arial", txt1.Font.Size);

        }

        private void radioTa_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Font = new Font("Tahoma", txt1.Font.Size);

        }

        private void radioCo_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Font = new Font("Courier New", txt1.Font.Size);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
