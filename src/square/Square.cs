using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.square
{
    internal class Square: FixedShape
    {
        private float side { get; set; }

        public Square(float side)
        {
            this.side = side;
        }

        public float GetPerimeter()
        {
            return side * 4;
        }

        public float GetArea()
        {
            return side * side;
        }

        public float GetWidth()
        {
            return side;
        }

        public float GetHeight()
        {
            return side;
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            points.Add(new PointF(0, 0));
            points.Add(new PointF(0, side));
            points.Add(new PointF(side, side));
            points.Add(new PointF(side, 0));

            return points.ToArray();
        } 
    }
}
