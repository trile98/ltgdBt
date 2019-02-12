using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioUSA_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxflag.Image = imageList1.Images[0];
        }

        private void radioAu_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxflag.Image = imageList1.Images[1];

        }

        private void radioBrazil_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxflag.Image = imageList1.Images[2];

        }

        private void radioCam_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxflag.Image = imageList1.Images[3];

        }
    }
}
