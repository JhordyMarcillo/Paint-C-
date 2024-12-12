using System;
using System.Collections.Generic;
using System.Drawing;

namespace Proyecto
{
    internal class FillShape
    {
        // Bitmap y gráficos
        public Bitmap CurrentBitmap { get; private set; }
        private Pen _currentPen; 
        private Pen _eraser; 

        // Método para llenar una forma en la imagen
        public Bitmap Fill(Point point, Color newColor)
        {
            Color oldColor = CurrentBitmap.GetPixel(point.X, point.Y); 
            if (oldColor == newColor) return CurrentBitmap; // Si el color es el mismo, no hacemos nada

            FloodFill(CurrentBitmap, point.X, point.Y, oldColor, newColor); 
            return CurrentBitmap; 
        }

        // Método de llenado
        private void FloodFill(Bitmap bm, int x, int y, Color oldColor, Color newColor)
        {
            // Verificamos si estamos dentro de los límites de la imagen
            if (x < 0 || x >= bm.Width || y < 0 || y >= bm.Height) return;
            if (bm.GetPixel(x, y) != oldColor) return; // Verifica si el color coincide

            Stack<Point> pixels = new Stack<Point>(); // Usamos una pila para almacenar los puntos
            pixels.Push(new Point(x, y)); 

            while (pixels.Count > 0)
            {
                Point point = pixels.Pop();

                // Verifica los límites
                if (point.X < 0 || point.X >= bm.Width || point.Y < 0 || point.Y >= bm.Height)
                    continue;

                if (bm.GetPixel(point.X, point.Y) != oldColor)
                    continue;

                bm.SetPixel(point.X, point.Y, newColor); // Cambiamos el color del píxel

                pixels.Push(new Point(point.X + 1, point.Y)); // Derecha
                pixels.Push(new Point(point.X - 1, point.Y)); // Izquierda
                pixels.Push(new Point(point.X, point.Y + 1)); // Abajo
                pixels.Push(new Point(point.X, point.Y - 1)); // Arriba
            }
        }

        // Cambia el color del lápiz
        public void SetPenColor(Color color)
        {
            _currentPen.Color = color; 
        }

        // Cambia el grosor del lápiz y el borrador
        public void SetPenWidth(float width)
        {
            _currentPen.Width = width;
            _eraser.Width = width; 
        }
    }
}
