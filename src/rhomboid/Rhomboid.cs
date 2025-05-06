using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.rhomboid
{
    internal class Rhomboid : FixedShape
    {
        private float b;  // Base
        private float height;
        private float side;

        public Rhomboid(float b, float height, float side)
        {
            this.b = b;
            this.height = height;
            this.side = side;
        }

        public float GetArea()
        {
            return this.b * this.height;
        }

        public float GetHeight()
        {
            return this.height;
        }

        public float GetPerimeter()
        {
            return 2 * (this.side + this.b);
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            float x = (float) (Math.Pow(this.side, 2) - Math.Pow(this.height, 2));
            x = (float)Math.Sqrt(x);

            points.Add(new PointF(x, 0));
            points.Add(new PointF(x + this.b, 0));
            points.Add(new PointF(this.b, this.height));
            points.Add(new PointF(0, this.height));

            return points.ToArray();
        }

        public float GetWidth()
        {
            return this.b;
        }
    }
}
