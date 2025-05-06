using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.trapezoid
{
    internal class Trapezoid : FixedShape
    {
        private float diag1;
        private float diag2;
        private float b;  // Base

        public Trapezoid(float diag1, float diag2, float b)
        {
            this.diag1 = diag1;
            this.diag2 = diag2;
            this.b = b;
        }

        private float GetHeightByDiag(float diag)
        {
            return diag * (float)Math.Sin(Math.PI / 4);
        }
        
        private float GetWidthByDiag(float diag)
        {
            return diag * (float)Math.Cos(Math.PI / 4);
        }

        public float GetArea()
        {
            float h1 = this.GetHeightByDiag(this.diag1);
            float h2 = this.GetHeightByDiag(this.diag2);

            return (b * h1 / 2) + (b * h2 / 2);
        }

        public float GetHeight()
        {
            float h1 = this.GetHeightByDiag(this.diag1);
            float h2 = this.GetHeightByDiag(this.diag2);

            return h1 > h2 ? h1 : h2;
        }

        public float GetPerimeter()
        {
            // Jeje
            return 2 * (this.b + this.diag1 + this.diag2);
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            Random r = new Random();
            int val;

            if (this.diag1 > this.diag2) val = r.Next((int)Math.Floor(this.diag2), (int)Math.Floor(this.diag1));
            else val = r.Next((int)Math.Floor(this.diag1), (int)Math.Floor(this.diag2));

                points.Add(new PointF(3 * val, 0));
            points.Add(new PointF(0, 1 * val));
            points.Add(new PointF(1 * val, 3 * val));
            points.Add(new PointF(4 * val, 4 * val));

            return points.ToArray();
        }

        public float GetWidth()
        {
            return this.GetWidthByDiag(this.diag1) + this.GetWidthByDiag(this.diag2) - this.b;
        }
    }
}
