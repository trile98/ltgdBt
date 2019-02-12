using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.ForeColor = Color.Green;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioRe_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Font = new Font(lbl1.Font,FontStyle.Regular);

        }

        private void radioBo_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Font = new Font(lbl1.Font,FontStyle.Bold);
        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.ForeColor=Color.Red;

        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.ForeColor = Color.Blue;
        
        }

        private void radioIt_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Font = new Font(lbl1.Font, FontStyle.Italic);

        }

        private void radioBoth_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Font = new Font(lbl1.Font, FontStyle.Bold | FontStyle.Italic);

        }

        private void radioAuto_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.ForeColor = Color.Black;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
