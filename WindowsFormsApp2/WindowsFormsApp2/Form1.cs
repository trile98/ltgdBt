using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HelpProvider hlp = new HelpProvider();
            hlp.SetShowHelp(txtuser, true);
            hlp.SetHelpString(txtuser, "Enter UserName");

            hlp.SetShowHelp(btnlogin, true);
            hlp.SetHelpString(btnlogin, "click to login");

            hlp.HelpNamespace = "hlp.chm";
            hlp.SetHelpNavigator(lblhelp, HelpNavigator.TableOfContents);
        }
    }
}
