using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.star
{
    internal class Star : FixedShape, RoundedShape
    {
        private float side;

        public Star(float side)
        {
            this.side = side;
        }

        public float GetArea()
        {
            float apot = this.GetApothema();
            float aPol = this.GetPerimeter() * apot / 2;

            float h = this.side / 2 * (float)Math.Tan(Math.PI / 5);
            float a = this.side * h / 2;
            a = a * 5; // 5 Triángulos

            return aPol - a;
        }

        private float GetApothema()
        {
            return this.side / 2 * (float)Math.Tan(Math.PI / 5);
        }

        public float GetHeight()
        {
            return this.GetApothema() * 2;
        }

        private float GetStarSide()
        {
            return (float)Math.Sin(Math.PI / 5);
        }

        public float GetPerimeter()
        {
            return this.side * this.GetStarSide() * 10;
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            float ap = this.GetApothema();
            float r = this.GetRadius();

            points.Add(new PointF(r, 0));
            points.Add(new PointF(r - (this.side / 2), 2 * ap));
            points.Add(new PointF(2 * r, (float)(ap * 0.9)));
            points.Add(new PointF(0, (float)(ap * 0.9)));
            points.Add(new PointF(r + (this.side / 2), 2 * ap));

            return points.ToArray();
        }

        public float GetWidth()
        {
            return this.GetRadius() * 2;
        }

        public float GetRadius()
        {
            return (float)Math.Sqrt(Math.Pow(this.GetApothema(), 2) + Math.Pow(this.side / 2, 2));
        }
    }
}
