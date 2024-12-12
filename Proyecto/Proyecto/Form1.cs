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
        int x, y, sX, sY, cX, cY; // Variables para coordenadas
        Stack<Bitmap> undoStack = new Stack<Bitmap>(); 
        Stack<Bitmap> redoStack = new Stack<Bitmap>(); 
        ColorDialog cd = new ColorDialog(); 
        Color newColor; 

        ShapeDrawer shapeDrawer; // Para dibujar formas
        BitmapManager bitmapManager; // Manejo de imágenes
        FillShape fillShape; // Para llenar formas
        UndoRedoManager undoRedoManager; // Manejo de deshacer/rehacer

        public Form1()
        {
            InitializeComponent();
            this.Width = 900; 
            this.Height = 700; 
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height); 
            g = Graphics.FromImage(bm); 
            g.Clear(Color.White); 
            pictureBox1.Image = bm; 

            // Inicializamos 
            shapeDrawer = new ShapeDrawer(g, p);
            bitmapManager = new BitmapManager();
            fillShape = new FillShape();
            undoRedoManager = new UndoRedoManager();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location; // Guardamos la ubicación inicial

            cX = e.X; // Coordenadas iniciales
            cY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint) // Si estamos pintando
            {
                if (index == 1) // Lápiz
                {
                    px = e.Location;
                    g.DrawLine(p, px, py); 
                    py = px; 
                }
                if (index == 2) // Borrador
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
            }
            pictureBox1.Refresh(); // Refrescamos el PictureBox
            x = e.X; // Actualizamos coordenadas
            y = e.Y;
            sX = e.X - cX; // Distancia desde el inicio
            sY = e.Y - cY;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX; // Distancia final
            sY = y - cY;
            DrawShape(); // Dibujamos la forma final
            GuardarEstado(); // Guardamos el estado para deshacer
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Obtenemos los gráficos del evento
            if (paint) DrawPreview(g); 
        }

        private void BtnColorSet_Click(object sender, EventArgs e)
        {
            cd.ShowDialog(); // Mostramos el diálogo de color
            newColor = cd.Color; 
            pic_color.BackColor = cd.Color; // Cambiamos el color de fondo del PictureBox
            p.Color = cd.Color; // Cambiamos el color del lápiz
        }

        private void BtnPencilWidth_Click(object sender, EventArgs e)
        {
            p.Width = 1; // Ajustamos el grosor
            eraser.Width = 1; 
            MessageBox.Show("Grosor ajustado a 1", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            shapeDrawer = new ShapeDrawer(g, p); 
            index = 3; // Círculo
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            shapeDrawer = new ShapeDrawer(g, p);
            index = 5; // Establecemos el índice para línea
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shapeDrawer = new ShapeDrawer(g, p);
            index = 2; // Establecemos el índice para borrador
        }

        private void BtnPentagono_Click(object sender, EventArgs e)
        {
            shapeDrawer = new ShapeDrawer(g, p);
            index = 6; // Pentágono
        }

        private void BtnStair_Click(object sender, EventArgs e)
        {
            shapeDrawer = new ShapeDrawer(g, p);
            index = 8; // Estrella
        }

        private void BtnTriangulo_Click(object sender, EventArgs e)
        {
            shapeDrawer = new ShapeDrawer(g, p);
            index = 9; // Triangulo
        }
        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            undoRedoManager = new UndoRedoManager(); // Reiniciamos 

            if (undoStack.Count > 0) // Verifica si no es 0
            {
                redoStack.Push(new Bitmap(bm)); // Guardamos el estado actual para rehacer
                bm = undoStack.Pop(); // Sacamos el último estado
                g = Graphics.FromImage(bm); // Actualizamos gráficos
                pictureBox1.Image = bm; 
            }
            else
            {
                MessageBox.Show("No hay cambios para deshacer.", "Deshacer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRehacer_Click(object sender, EventArgs e)
        {
            undoRedoManager = new UndoRedoManager();  
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


        private void BtnLineWidth2_Click(object sender, EventArgs e)
        {
            fillShape = new FillShape(); // Inicializamos el llenador de formas
            p.Width = 5; // Ajustamos el grosor del lápiz
            eraser.Width = 5; // Ajustamos el grosor del borrador
            MessageBox.Show("Grosor ajustado a 5", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLineWidth3_Click(object sender, EventArgs e)
        {
            fillShape = new FillShape(); 
            p.Width = 10; 
            eraser.Width = 10;
            MessageBox.Show("Grosor ajustado a 10", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void GuardarEstado()
        {
            Bitmap copia = new Bitmap(bm); // Copia del bitmap
            undoStack.Push(copia); // La agregamos a la pila de deshacer
            redoStack.Clear(); // Limpiamos la pila de rehacer
        }

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            shapeDrawer = new ShapeDrawer(g, p); // Preparamos el dibujador
            index = 1; 
        }

        private void button29_Click(object sender, EventArgs e)
        {
            shapeDrawer = new ShapeDrawer(g, p); 
            index = 4; 
        }

        private void BtnParalelogramo_Click(object sender, EventArgs e)
        {

        }
        private void picker_Click(object sender, EventArgs e)
        {
            



        }

        private void pic_color_Click(object sender, EventArgs e)
        {



        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog(); 
            dialog.ShowDialog(); 
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

        private void Color_Click(object sender, MouseEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmapManager = new BitmapManager(); // Inicializamos el manejador de imágenes
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png"; // Filtros para guardar
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.FileName = "image"; // Nombre por defecto

                if (saveFileDialog.ShowDialog() == DialogResult.OK) // Si el usuario elige guardar
                {
                    try
                    {
                        ImageFormat format = ImageFormat.Png; // Por defecto, PNG

                        switch (saveFileDialog.FilterIndex) // Determinamos el formato según la opción seleccionada
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

                        bm.Save(saveFileDialog.FileName, format); // Guardamos la imagen
                        MessageBox.Show("Imagen guardada exitosamente", "Guardar Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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




        public void Fill(Bitmap bm, int x, int y, Color newColor)
        {

            fillShape = new FillShape();
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


        static Point set_point(PictureBox picture, Point pt)
        {
            float pX = 1f * picture.Image.Width / picture.Width;
            float pY = 1f * picture.Image.Height / picture.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
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

        private void DrawShape()
        {
            if (index == 3) g.DrawEllipse(p, cX, cY, sX, sY);
            if (index == 4) g.DrawRectangle(p, cX, cY, sX, sY);
            if (index == 5) g.DrawLine(p, cX, cY, x, y);
            if (index == 6) DrawPentagon(g);
            if (index == 9) DrawRightTriangle(g);
            if (index == 8) DrawStar(g);
        }

        private void DrawPreview(Graphics g)
        {
            if (index == 3) g.DrawEllipse(p, cX, cY, sX, sY);
            if (index == 4) g.DrawRectangle(p, cX, cY, sX, sY);
            if (index == 5) g.DrawLine(p, cX, cY, x, y);
            if (index == 6) DrawPentagon(g);
            if (index == 9) DrawRightTriangle(g);
            if (index == 8) DrawStar(g);
        }

        private void DrawPentagon(Graphics g)
        {
            int sides = 5;
            float centerX = cX + sX / 2;
            float centerY = cY + sY / 2;
            float radius = Math.Min(Math.Abs(sX), Math.Abs(sY)) / 2;
            PointF[] pentagonPoints = new PointF[sides];

            for (int i = 0; i < sides; i++)
            {
                double angle = i * (2 * Math.PI / sides) - Math.PI / 2;
                pentagonPoints[i] = new PointF(centerX + radius * (float)Math.Cos(angle), centerY + radius * (float)Math.Sin(angle));
            }
            g.DrawPolygon(p, pentagonPoints);
        }

        private void DrawRightTriangle(Graphics g)
        {
            PointF[] rightTrianglePoints = new PointF[3];
            rightTrianglePoints[0] = new PointF(cX, cY);
            rightTrianglePoints[1] = new PointF(cX + sX, cY);
            rightTrianglePoints[2] = new PointF(cX, cY + sY);
            g.DrawPolygon(p, rightTrianglePoints);
        }

        private void DrawStar(Graphics g)
        {
            float centerX = cX + sX / 2;
            float centerY = cY + sY / 2;
            float outerRadius = Math.Min(Math.Abs(sX), Math.Abs(sY)) / 2;
            float innerRadius = outerRadius / 2.5f;
            PointF[] starPoints = new PointF[10];

            for (int i = 0; i < 10; i++)
            {
                float radius = (i % 2 == 0) ? outerRadius : innerRadius;
                double angle = i * (2 * Math.PI / 10) - Math.PI / 2;
                starPoints[i] = new PointF(centerX + radius * (float)Math.Cos(angle), centerY + radius * (float)Math.Sin(angle));
            }
            g.DrawPolygon(p, starPoints);
        }

        
    }
}