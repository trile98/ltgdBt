using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lbltitle.Font = new Font(new FontFamily("Times New Roman"), int.Parse(numericUpDownsize.Value.ToString()));
        }

        private void radioRe_CheckedChanged(object sender, EventArgs e)
        {
            lbltitle.Font = new Font(lbltitle.Font, FontStyle.Regular);
        }

        private void radioBo_CheckedChanged(object sender, EventArgs e)
        {
            lbltitle.Font = new Font(lbltitle.Font, FontStyle.Bold);
        }

        private void radioIt_CheckedChanged(object sender, EventArgs e)
        {
            lbltitle.Font = new Font(lbltitle.Font, FontStyle.Italic);
        }

        private void radioBoth_CheckedChanged(object sender, EventArgs e)
        {
            lbltitle.Font = new Font(lbltitle.Font, FontStyle.Italic|FontStyle.Bold);
        }

        private void radioLeft_CheckedChanged(object sender, EventArgs e)
        {
            lbltitle.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void radioRight_CheckedChanged(object sender, EventArgs e)
        {

            lbltitle.TextAlign = ContentAlignment.MiddleRight;
        }

        private void radioCenter_CheckedChanged(object sender, EventArgs e)
        {
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioAuto_CheckedChanged(object sender, EventArgs e)
        {
            lbltitle.ForeColor = Color.Black;
        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            lbltitle.ForeColor = Color.Red;

        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            lbltitle.ForeColor = Color.Green;

        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            lbltitle.ForeColor = Color.Blue;

        }
    }
}
