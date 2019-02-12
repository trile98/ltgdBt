using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week09
{
    public partial class Form2 : Form
    {
        List<string> values=new List<string>();

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string s,string title)
        {
            InitializeComponent();
            this.Text = title;
            txtboxnew.Text=s;

        }

 

        public List<string> turnback()
        {
            values.Add( this.Text);
            values.Add(txtboxnew.Text);
            return values;
        }

    }
}
