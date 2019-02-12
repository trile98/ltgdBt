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
    public partial class FormPaint : Form
    {
        Point p1;
        Point p2;
        Graphics gr;
        Bitmap bm;
        Pen p = new Pen(Color.Red, 3);
        Point[] ps, pstri;

        public FormPaint(String path)
        {
            InitializeComponent();
            bm = new Bitmap(path);
            //bm.SetResolution(bm.HorizontalResolution, bm.VerticalResolution);
            gr = Graphics.FromImage(bm);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.BackgroundImage = (Bitmap)bm.Clone();
            this.Paint += new PaintEventHandler(Form1_Paint);
            Drawing = false;

        }



        private enum Shape
        {
            Line,
            Triangle,
            Square,
            Circle,
            Eraser
        }

        Shape shape;
        bool Drawing;

        public FormPaint()
        {
            InitializeComponent();
            bm = new Bitmap(this.Width, this.Height);
            gr = Graphics.FromImage(bm);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.Paint += new PaintEventHandler(Form1_Paint);
            Drawing = false;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if (Drawing)
            {
                switch (shape)
                {

                    case Shape.Line:

                        e.Graphics.DrawLine(p, p1, p2);
                        break;
                    case Shape.Triangle:
                        e.Graphics.DrawLines(p, pstri);
                        break;
                    case Shape.Square:
                        e.Graphics.DrawLines(p, ps);
                        break;
                    case Shape.Circle:
                        e.Graphics.DrawEllipse(p, p1.X, p1.Y, (p2.X - p1.X), (p2.Y - p1.Y));
                        break;


                    default:
                        break;
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btncolor1.BackColor = p.Color;
            btncolor2.BackColor = this.BackColor;
            btncircle.BackgroundImage = imageList1.Images[0];
            btnline.BackgroundImage = imageList1.Images[2];
            btnsquare.BackgroundImage = imageList1.Images[4];
            btntriangle.BackgroundImage = imageList1.Images[6];
            for (int i =   1; i < 100; i++)
            {
                cmbsize.Items.Add(i);
            }
        }

        private void btnline_Click(object sender, EventArgs e)
        {
            btncircle.BackgroundImage = imageList1.Images[0];
            btnsquare.BackgroundImage = imageList1.Images[4];
            btntriangle.BackgroundImage = imageList1.Images[6];
            btnline.BackgroundImage = imageList1.Images[3];
            shape = Shape.Line;
        }

        private void btnsquare_Click(object sender, EventArgs e)
        {
            btntriangle.BackgroundImage = imageList1.Images[6];
            btncircle.BackgroundImage = imageList1.Images[0];
            btnline.BackgroundImage = imageList1.Images[2];
            btnsquare.BackgroundImage = imageList1.Images[5];
            shape = Shape.Square;
        }

        private void btntriangle_Click(object sender, EventArgs e)
        {
            btncircle.BackgroundImage = imageList1.Images[0];
            btnline.BackgroundImage = imageList1.Images[2];
            btnsquare.BackgroundImage = imageList1.Images[4];
            btntriangle.BackgroundImage = imageList1.Images[7];
            shape = Shape.Triangle;
        }

        private void btncircle_Click(object sender, EventArgs e)
        {
            btncircle.BackgroundImage = imageList1.Images[1];
            btnline.BackgroundImage = imageList1.Images[2];
            btnsquare.BackgroundImage = imageList1.Images[4];
            btntriangle.BackgroundImage = imageList1.Images[6];
            shape = Shape.Circle;
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = new Point(e.Location.X, e.Location.Y);
            Drawing = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drawing)
            {
                p2 = new Point(e.Location.X, e.Location.Y);

                ps = new Point[] { p1, new Point(p2.X, p1.Y), p2, new Point(p1.X, p2.Y), p1 };
                pstri = new Point[] { p1, p2, new Point(p1.X, p2.Y), p1 };

                gr = Graphics.FromImage(bm);
                

                switch (shape)
                {
                   
                    case Shape.Line:

                        gr.DrawLine(p, p1, p2);
                        break;
                    case Shape.Triangle:
                       gr.DrawLines(p, pstri);
                        break;
                    case Shape.Square:
                        gr.DrawLines(p, ps);
                        break;
                    case Shape.Circle:
                        gr.DrawEllipse(p, p1.X, p1.Y, (p2.X - p1.X), (p2.Y - p1.Y));
                        break;
                    case Shape.Eraser:
                        {
                            gr.DrawEllipse(p, p1.X, p1.Y, 10, 10);
                            this.BackgroundImage = (Bitmap)bm.Clone();
                        break;
                        }

                    default:
                        break;
                }

            }
            this.Refresh();



        }



        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            p2 = new Point(e.Location.X, e.Location.Y);
          
            Drawing = false;
            
            switch (shape)
            {
                case Shape.Line:
                gr.DrawLine(p, p1, p2);
                    break;
                case Shape.Triangle:
                    {
                        ps = new Point[] { p1, p2, new Point(p1.X, p2.Y), p1 };
                        gr.DrawLines(p, ps);

                        break;
                    }
                case Shape.Square:
                    { 
                        ps = new Point[] { p1, new Point(p2.X, p1.Y), p2, new Point(p1.X, p2.Y), p1 };
                        gr.DrawLines(p, ps);
                        break;
                    }
                case Shape.Circle:
                    gr.DrawEllipse(p, p1.X, p1.Y, (p2.X - p1.X), (p2.Y - p1.Y));
                    
                    break;
                case Shape.Eraser:
                    gr.DrawEllipse(p, p1.X, p1.Y, 10, 10);
                    this.BackgroundImage = (Bitmap)bm.Clone();
                    break;

            }
            this.BackgroundImage = (Bitmap)bm.Clone();

        }

        private void cmbsize_SelectedValueChanged(object sender, EventArgs e)
        {
          
            p = new Pen(p.Color, int.Parse(cmbsize.SelectedItem.ToString()));
        }

        private void btncolor1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;
                btncolor1.BackColor = colorDialog1.Color;
                btncolor2.ForeColor = p.Color;
                btncolor1.ForeColor = this.BackColor;
                lblsize.ForeColor = p.Color;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            p = new Pen(this.BackColor, btnXoa.Width);
            shape = Shape.Eraser;
        }

        private void btncolor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btncolor2.ForeColor = p.Color;
                btncolor1.ForeColor = this.BackColor;
                this.BackColor = colorDialog1.Color;
                btncolor2.BackColor = colorDialog1.Color;
                lblsize.ForeColor = p.Color;
            }
        }

       
    }
}
