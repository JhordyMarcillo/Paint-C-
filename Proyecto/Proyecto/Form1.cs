using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {

        bool paint = false;
        int index;
        Point px, py;
        Bitmap bm;
        Graphics g;
        Pen p = new Pen(Color.Black, 2);
        Pen eraser = new Pen(Color.White, 5);
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color newColor;

        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color colorOld, Color colorNew)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == colorOld)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, colorNew);
            }
        }


        public void Fill(Bitmap bm, int x, int y,Color newColor)
        {
            Color oldColor = bm.GetPixel(x, y);

            if (oldColor == newColor) return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point point = pixels.Pop();

                 if (point.X < 0 || point.X >= bm.Width || point.Y < 0 || point.Y >= bm.Height)
                    continue;

               if (bm.GetPixel(point.X, point.Y) != oldColor)
                    continue;

                bm.SetPixel(point.X, point.Y, newColor);

                pixels.Push(new Point(point.X + 1, point.Y));
                pixels.Push(new Point(point.X - 1, point.Y));
                pixels.Push(new Point(point.X, point.Y + 1));
                pixels.Push(new Point(point.X, point.Y - 1));
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }

     

        private void BtnColorSet_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            newColor = cd.Color;
            pictureBox1.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void BtnPencilWidth_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowDialog();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint) { 

                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }

                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }

                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }        
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            index = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void Color_Click(object sender, MouseEventArgs e)
        {
           
        }

        private void picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(picker, e.Location);
            pictureBox1.BackColor = ((Bitmap)picker.Image).GetPixel(point.X, point.Y);
            newColor = pictureBox1.BackColor;
            p.Color = pictureBox1.BackColor;
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pictureBox1, e.Location);
                Fill(bm, point.X, point.Y, newColor);
                pictureBox1.Image = bm; // Asegúrate de actualizar la imagen
            }
        }

        private void rellenar_Click(object sender, EventArgs e)
        {
            index = 7;
            pictureBox1.Image = bm;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if(index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }

                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
            }
            pictureBox1.Refresh();

            x = e.X;
            y = e.Y;

            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if(index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }

            if(index == 4) 
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }

            if(index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
        }

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        static Point set_point(PictureBox picture, Point pt)
        {
            float pX = 1f * picture.Image.Width / picture.Width;
            float pY = 1f * picture.Image.Height / picture.Height;
            return new Point((int)(pt.X * pX),(int)(pt.Y * pY));
        }
    }
}
