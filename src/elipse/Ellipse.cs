using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.elipse
{
    internal class Ellipse : EllipseShape
    {
        private float MajorRadius;
        private float MinorRadius;

        public Ellipse(float majorRadius, float minorRadius)
        {
            MajorRadius = majorRadius;
            MinorRadius = minorRadius;
        }

        public float GetArea()
        {
            return (float) (Math.PI * this.MajorRadius * this.MinorRadius);
        }

        public float GetMajorAxis()
        {
            return this.MajorRadius * 2;
        }

        public float GetMinorAxis()
        {
            return this.MinorRadius * 2;
        }

        public float GetPerimeter()
        {
            double h = Math.Pow(this.MajorRadius - this.MinorRadius, 2);
            h = h / Math.Pow(this.MajorRadius + this.MinorRadius, 2);

            double term1 = Math.PI * (this.MajorRadius + this.MinorRadius);
            double term2 = 1 + ((3 * h) / (10 + Math.Sqrt(4 - 3 * h)));

            return (float) (term1 * term2);
        }
    }
}
