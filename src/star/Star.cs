using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.star
{
    internal class Star : FixedShape
    {
        private float side;

        public Star(float side)
        {
            this.side = side;
        }

        public float GetArea()
        {
            float apot = this.GetApothema();
            float a = this.GetPerimeter() * apot / 4;

            return a;
        }

        private float GetApothema()
        {
            return this.side / 2 * (float)Math.Tan(Math.PI / 5);
        }

        public float GetHeight()
        {
            return this.GetApothema() * 2;
        }

        public float GetPerimeter()
        {
            return this.side * 5;
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            float ap = this.GetApothema();

            points.Add(new PointF(ap, 0));
            points.Add(new PointF(ap - (this.side / 2), 2 * ap));
            points.Add(new PointF(2 * ap, (float)(ap * 0.9)));
            points.Add(new PointF(0, (float)(ap * 0.9)));
            points.Add(new PointF(ap + (this.side / 2), 2 * ap));

            return points.ToArray();
        }

        public float GetWidth()
        {
            return this.GetApothema() * 2;
        }
    }
}
