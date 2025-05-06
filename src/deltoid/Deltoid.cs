using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.deltoid
{
    internal class Deltoid : FixedShape
    {
        private float majorDiagonal;
        private float minorDiagonal;
        private float majorSide;
        private float minorSide;

        public Deltoid(float majorDiagonal, float majorSide, float minorSide)
        {
            this.majorDiagonal = majorDiagonal;
            this.majorSide = majorSide;
            this.minorSide = minorSide;

            float s = this.majorDiagonal + this.majorSide + this.minorSide;
            s /= 2;

            // Heron: A = sqrt(s (s - a) (s - b) (s - c))
            float x = s;
            x *= (s - this.majorDiagonal);
            x *= (s - this.majorSide);
            x *= (s - this.minorSide);

            float heron = (float) (Math.Sqrt(x));

            this.minorDiagonal = 4 * heron / this.majorDiagonal;
        }

        public float GetArea()
        {
            return this.majorDiagonal * this.minorDiagonal / 2;
        }

        public float GetHeight()
        {
            return this.majorDiagonal;
        }

        public float GetPerimeter()
        {
            return 2 * (this.majorSide + this.minorSide);
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            float yPos = (float) (Math.Pow(this.minorSide, 2) - Math.Pow(this.minorDiagonal / 2, 2));
            yPos = (float)Math.Sqrt(yPos);

            points.Add(new PointF(this.minorDiagonal / 2, 0));
            points.Add(new PointF(this.minorDiagonal, yPos));
            points.Add(new PointF(this.minorDiagonal / 2, this.majorDiagonal));
            points.Add(new PointF(0, yPos));

            return points.ToArray();
        }

        public float GetWidth()
        {
            return this.minorDiagonal;
        }
    }
}
