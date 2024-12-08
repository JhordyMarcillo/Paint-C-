using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        Stack<Bitmap> undoStack = new Stack<Bitmap>();
        Stack<Bitmap> redoStack = new Stack<Bitmap>();

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
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }
        
        private void BtnPencilWidth_Click(object sender, EventArgs e)
        {
            p.Width = 1; 
            eraser.Width = 1; 
            MessageBox.Show("Grosor del lápiz ajustado a 1", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                if(index == 6)
                {
                    int sides = 5;

                    float centerX = cX + sX / 2;
                    float centerY = cY + sY / 2;

                    float radius = Math.Min(Math.Abs(sX), Math.Abs(sY)) / 2;

                    PointF[] pentagonPoints = new PointF[sides];

                    for (int i = 0; i < sides; i++)
                    {
                        double angle = i * (2 * Math.PI / sides) - Math.PI / 2;
                        pentagonPoints[i] = new PointF(
                            centerX + radius * (float)Math.Cos(angle),
                            centerY + radius * (float)Math.Sin(angle)
                        );
                    }

                    g.DrawPolygon(p, pentagonPoints);
                }

                if( index == 9)
                {
                    PointF[] rightTrianglePoints = new PointF[3];

                    rightTrianglePoints[0] = new PointF(cX, cY);

                    rightTrianglePoints[1] = new PointF(cX + sX, cY);

                    rightTrianglePoints[2] = new PointF(cX, cY + sY);

                    g.DrawPolygon(p, rightTrianglePoints);
                }

                if(index == 8)
                {
                    float centerX = cX + sX / 2;
                    float centerY = cY + sY / 2;

                    float outerRadius = Math.Min(Math.Abs(sX), Math.Abs(sY)) / 2;
                    float innerRadius = outerRadius / 2.5f; 

                    PointF[] starPoints = new PointF[10];

                    for (int i = 0; i < 10; i++)
                    {
                        float radius = (i % 2 == 0) ? outerRadius : innerRadius;

                        double angle = i * (2 * Math.PI / 10) - Math.PI / 2; // Ajuste para iniciar en la parte superior

                        starPoints[i] = new PointF(
                            centerX + radius * (float)Math.Cos(angle),
                            centerY + radius * (float)Math.Sin(angle)
                        );
                    }

                    g.DrawPolygon(p, starPoints);
                }
            }        
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
            pic_color.BackColor = ((Bitmap)picker.Image).GetPixel(point.X, point.Y);
            newColor = pic_color.BackColor;
            p.Color = pic_color.BackColor;
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pictureBox1, e.Location);
                Fill(bm, point.X, point.Y, newColor);
                pictureBox1.Image = bm; // Asegúrate de actualizar la imagen

                GuardarEstado();
            }
        }

        private void rellenar_Click(object sender, EventArgs e)
        {
            index = 7;
            pictureBox1.Image = bm;

        }


        private void nuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);

            pictureBox1.Image = bm;

            MessageBox.Show("Nuevo archivo creado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Cargar Archivo de Imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Cargar la imagen seleccionada
                        Image imagenCargada = Image.FromFile(openFileDialog.FileName);

                        // Redimensionar la imagen al tamaño del PictureBox
                        bm = RedimensionarImagen(imagenCargada, pictureBox1.Width, pictureBox1.Height);
                        g = Graphics.FromImage(bm);
                        pictureBox1.Image = bm;

                        MessageBox.Show("Archivo cargado y redimensionado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                GuardarEstado();
            }
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

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(new Bitmap(bm));

                bm = undoStack.Pop();
                g = Graphics.FromImage(bm);
                pictureBox1.Image = bm;
            }
            else
            {
                MessageBox.Show("No hay cambios para deshacer.", "Deshacer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRehacer_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(new Bitmap(bm));

                bm = redoStack.Pop();
                g = Graphics.FromImage(bm);
                pictureBox1.Image = bm;
            }
            else
            {
                MessageBox.Show("No hay cambios para rehacer.", "Rehacer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.FileName = "image";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImageFormat format = ImageFormat.Png;

                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1:
                                format = ImageFormat.Jpeg;
                                break;
                            case 2:
                                format = ImageFormat.Bmp;
                                break;
                            case 3:
                                format = ImageFormat.Png;
                                break;
                        }

                        bm.Save(saveFileDialog.FileName, format);
                        MessageBox.Show("Imagen guardada exitosamente", "Guardar Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void picker_Click(object sender, EventArgs e)
        {

        }

        private void BtnPentagono_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void BtnStair_Click(object sender, EventArgs e)
        {
            index = 8;
        }

        private void BtnParalelogramo_Click(object sender, EventArgs e)
        {
            index = 9;
        }

        private void BtnLineWidth2_Click(object sender, EventArgs e)
        {
            p.Width = 5; 
            eraser.Width = 5; 
            MessageBox.Show("Grosor del lápiz ajustado a 5", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLineWidth3_Click(object sender, EventArgs e)
        {
            p.Width = 10; 
            eraser.Width = 10;
            MessageBox.Show("Grosor del lápiz ajustado a 10", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pic_color_Click(object sender, EventArgs e)
        {

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

            if(index == 6)
            {
                int sides = 5;

                float centerX = cX + sX / 2;
                float centerY = cY + sY / 2;

                float radius = Math.Min(Math.Abs(sX), Math.Abs(sY)) / 2;

                PointF[] pentagonPoints = new PointF[sides];

                for (int i = 0; i < sides; i++)
                {
                    double angle = i * (2 * Math.PI / sides) - Math.PI / 2;
                    pentagonPoints[i] = new PointF(
                        centerX + radius * (float)Math.Cos(angle),
                        centerY + radius * (float)Math.Sin(angle)
                    );
                }

                g.DrawPolygon(p, pentagonPoints);
            }

            if (index == 9)
            {
                PointF[] rightTrianglePoints = new PointF[3];

                rightTrianglePoints[0] = new PointF(cX, cY);

                rightTrianglePoints[1] = new PointF(cX + sX, cY);

                rightTrianglePoints[2] = new PointF(cX, cY + sY);

                g.DrawPolygon(p, rightTrianglePoints);
            }

            if (index == 8)
            {
                float centerX = cX + sX / 2;
                float centerY = cY + sY / 2;


                float outerRadius = Math.Min(Math.Abs(sX), Math.Abs(sY)) / 2;
                float innerRadius = outerRadius / 2.5f; 

                PointF[] starPoints = new PointF[12];

                for (int i = 0; i < 12; i++)
                {
                    float radius = (i % 2 == 0) ? outerRadius : innerRadius;

                    double angle = i * (2 * Math.PI / 10) - Math.PI / 2; 

                    starPoints[i] = new PointF(
                        centerX + radius * (float)Math.Cos(angle),
                        centerY + radius * (float)Math.Sin(angle)
                    );
                }

                g.DrawPolygon(p, starPoints);
            }

            GuardarEstado();
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

        private Bitmap RedimensionarImagen(Image imagenOriginal, int ancho, int alto)
        {
            Bitmap imagenRedimensionada = new Bitmap(ancho, alto);

            using (Graphics g = Graphics.FromImage(imagenRedimensionada))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imagenOriginal, 0, 0, ancho, alto);
                GuardarEstado();
            }

            return imagenRedimensionada;
        }

        private void GuardarEstado()
        { 
            Bitmap copia = new Bitmap(bm);
            undoStack.Push(copia);

            redoStack.Clear();
        }
    }
}
