using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class ShapeDrawer
    {
        private Graphics graphics;
        private Pen pen;

        public ShapeDrawer(Graphics graphics, Pen pen)
        {
            this.graphics = graphics;
            this.pen = pen;
        }

        public void DibujarCirculo(int cX, int cY, int sX, int sY)
        {
            graphics.DrawEllipse(pen, cX, cY, sX, sY);
        }

        public void DibujarRectangulo(int cX, int cY, int sX, int sY)
        {
            graphics.DrawRectangle(pen, cX, cY, sX, sY);
        }

        public void DibujarLinea(int cX, int cY, int x, int y)
        {
            graphics.DrawLine(pen, cX, cY, x, y);
        }

        public void DibujarPentagono(int cX, int cY, int sX, int sY)
        {
            int sides = 5;
            float centerX = cX + sX / 2;
            float centerY = cY + sY / 2;
            float radius = Math.Min(Math.Abs(sX), Math.Abs(sY)) / 2;
            PointF[] points = new PointF[sides];

            for (int i = 0; i < sides; i++)
            {
                double angle = i * (2 * Math.PI / sides) - Math.PI / 2;
                points[i] = new PointF(
                    centerX + radius * (float)Math.Cos(angle),
                    centerY + radius * (float)Math.Sin(angle)
                );
            }

            graphics.DrawPolygon(pen, points);
        }

        public void DibujarEstrella(int cX, int cY, int sX, int sY)
        {
            float centerX = cX + sX / 2;
            float centerY = cY + sY / 2;
            float outerRadius = Math.Min(Math.Abs(sX), Math.Abs(sY)) / 2;
            float innerRadius = outerRadius / 2.5f;
            PointF[] points = new PointF[10];

            for (int i = 0; i < 10; i++)
            {
                float radius = (i % 2 == 0) ? outerRadius : innerRadius;
                double angle = i * (2 * Math.PI / 10) - Math.PI / 2;
                points[i] = new PointF(
                    centerX + radius * (float)Math.Cos(angle),
                    centerY + radius * (float)Math.Sin(angle)
                );
            }

            graphics.DrawPolygon(pen, points);
        }
    }

}
