using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.trapeze
{
    // Trapecio Isósceles
    internal class Trapeze : FixedShape
    {
        private float majorBase;
        private float minorBase;
        private float height;

        public Trapeze(float majorBase, float minorBase, float height)
        {
            this.majorBase = majorBase;
            this.minorBase = minorBase;
            this.height = height;
        }

        private float GetSide()
        {
            // l = sqrt((B - b)^2 + h^2)
            return (float)(Math.Sqrt(Math.Pow(this.majorBase - this.minorBase, 2) + Math.Pow(this.height, 2)));
        }

        public float GetArea()
        {
            return (this.majorBase + this.minorBase) * this.height / 2;
        }

        public float GetHeight()
        {
            return this.height;
        }

        public float GetPerimeter()
        {
            return this.majorBase + this.minorBase + (2 * this.GetSide());
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            float startPos = this.majorBase - this.minorBase;
            startPos /= 2;

            points.Add(new PointF(startPos, 0));
            points.Add(new PointF(startPos + this.minorBase, 0));
            points.Add(new PointF(this.majorBase, this.height));
            points.Add(new PointF(0, this.height));

            return points.ToArray();
        }

        public float GetWidth()
        {
            return this.majorBase;
        }
    }
}
