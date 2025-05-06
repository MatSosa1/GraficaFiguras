using System;
using System.Collections.Generic;
using System.Drawing;

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
            float h1 = GetHeightByDiag(diag1);
            float h2 = GetHeightByDiag(diag2);

            float baseTotal = b + GetWidthByDiag(diag1) + GetWidthByDiag(diag2);
            return ((b + baseTotal) / 2) * (h1 + h2) / 2;
        }

        public float GetHeight()
        {
            float h1 = this.GetHeightByDiag(this.diag1);
            float h2 = this.GetHeightByDiag(this.diag2);

            return h1 > h2 ? h1 : h2;
        }

        public float GetPerimeter()
        {
            float baseMayor = b + GetWidthByDiag(diag1) + GetWidthByDiag(diag2);
            return b + baseMayor + diag1 + diag2;
        }

        public PointF[] GetPoints()
        {
            List<PointF> points = new List<PointF>();

            float h = GetHeight();
            float b1 = GetWidthByDiag(diag1);
            float b2 = GetWidthByDiag(diag2);

            points.Add(new PointF(0, h));
            points.Add(new PointF(b1, 0));
            points.Add(new PointF(b + b1, 0));
            points.Add(new PointF(b + b1 + b2, h));

            return points.ToArray();
        }

        public float GetWidth()
        {
            return this.GetWidthByDiag(this.diag1) + this.GetWidthByDiag(this.diag2) - this.b;
        }
    }
}
