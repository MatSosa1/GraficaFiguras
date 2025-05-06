using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.rectangle
{
    internal class Rectangle : FixedShape
    {
        private float width;
        private float height;

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float GetArea()
        {
            return width * height;
        }

        public float GetHeight()
        {
            return height;
        }

        public float GetPerimeter()
        {
            return 2 * (width + height);
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            points.Add(new PointF(0, 0));
            points.Add(new PointF(width, 0));
            points.Add(new PointF(width, height));
            points.Add(new PointF(0, height));

            return points.ToArray();
        }

        public float GetWidth()
        {
            return width;
        }
    }
}
