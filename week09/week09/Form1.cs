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

namespace week09
{
    public partial class Form1 : Form
    {
        SaveFileDialog savef = new SaveFileDialog();
        string filename;
        OpenFileDialog openf = new OpenFileDialog();
        List<string> values = new List<string>();
        StreamReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openf.Multiselect = true;
            openf.Filter = "text files (*.txt)|*.txt";
            if (openf.ShowDialog()==DialogResult.OK)
            {
                foreach(string f in openf.FileNames)
                {
                    openf.InitialDirectory = f;
                    reader = new StreamReader(openf.InitialDirectory);
                    Form2 newform = new Form2(reader.ReadToEnd(), f);
                    newform.MdiParent = this;
                    newform.Show();
                }

            }
            reader.Close();

        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openf.Multiselect = true;
            openf.Filter = "text files (*.txt)|*.txt";
            if (openf.ShowDialog() == DialogResult.OK)
            {
                foreach (string f in openf.FileNames)
                {
                    openf.InitialDirectory = f;
                    reader = new StreamReader(openf.InitialDirectory);
                    Form2 newform = new Form2(reader.ReadToEnd(), f);
                    newform.MdiParent = this;
                    filename = openf.FileName;
                }
                reader.Close();

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog()==DialogResult.OK)
            {
                
            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form2 i in this.MdiChildren)
            {
                 values = i.turnback();
                filename = values[0];
                if (filename == null)
                {
                    savef.Filter = "text files (*.txt)|*.txt";
                    if (savef.ShowDialog() == DialogResult.OK)
                    {
                        Stream stream = savef.OpenFile();
                        StreamWriter writer = new StreamWriter(stream);
                        writer.Write(values[1]);
                        writer.Close();
                        stream.Close();
                    }
                  
                }
                else
                {

                    StreamWriter writer = new StreamWriter(values[0]);
                        writer.Write(values[1]);
                        writer.Close();
                   
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form2 i in this.MdiChildren)
            {
                values = i.turnback();
                savef.Filter = "text files (*.txt)|*.txt";
                if (savef.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = savef.OpenFile();
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write(values[1]);
                    writer.Close();
                    stream.Close();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.MdiParent = this;
            newform.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.MdiParent = this;
            newform.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Form2 i in this.MdiChildren)
            {
                values = i.turnback();
                filename = values[0];
                if (filename == null)
                {
                    savef.Filter = "text files (*.txt)|*.txt";
                    if (savef.ShowDialog() == DialogResult.OK)
                    {
                        Stream stream = savef.OpenFile();
                        StreamWriter writer = new StreamWriter(stream);
                        writer.Write(values[1]);
                        writer.Close();
                        stream.Close();
                    }

                }
                else
                {

                    StreamWriter writer = new StreamWriter(values[0]);
                    writer.Write(values[1]);
                    writer.Close();

                }
            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
