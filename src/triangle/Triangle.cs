using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.triangle
{
    // Triángulo Equilátero
    internal class Triangle: FixedShape
    {
        private float side;

        public Triangle(float side)
        {
            this.side = side;
        }

        public float GetPerimeter()
        {
            return side * 3;
        }

        public float GetArea()
        {
            return (this.GetWidth() * this.GetHeight()) / 2;
        }

        public float GetWidth()
        {
            return side;
        }

        public float GetHeight()
        {
            return (float)(side * Math.Sin(Math.PI / 3));
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            points.Add(new PointF(this.side / 2, 0));
            points.Add(new PointF(this.side, this.GetHeight()));
            points.Add(new PointF(0, this.GetHeight()));

            return points.ToArray();
        }
    }
}
