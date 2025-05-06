using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.rhombus
{
    internal class Rhombus : FixedShape
    {
        private float majorDiagonal;
        private float minorDiagonal;
        private float side;

        public Rhombus(float majorDiagonal, float minorDiagonal)
        {
            this.majorDiagonal = majorDiagonal;
            this.minorDiagonal = minorDiagonal;

            // Teorema de Pitágoras
            this.side = (float) Math.Sqrt(Math.Pow(majorDiagonal, 2) + Math.Pow(minorDiagonal, 2));
        }

        public float GetArea()
        {
            return majorDiagonal * minorDiagonal / 2;
        }

        public float GetHeight()
        {
            return majorDiagonal;
        }

        public float GetPerimeter()
        {
            return this.side * 4;
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            points.Add(new PointF(minorDiagonal / 2, 0));
            points.Add(new PointF(minorDiagonal, majorDiagonal / 2));
            points.Add(new PointF(minorDiagonal / 2, majorDiagonal));
            points.Add(new PointF(0, majorDiagonal / 2));

            return points.ToArray();
        }

        public float GetWidth()
        {
            return this.minorDiagonal;
        }
    }
}
