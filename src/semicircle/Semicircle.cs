using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.semicircle
{
    internal class Semicircle : RoundedShape
    {
        private float radius;

        public Semicircle(float radius)
        {
            this.radius = radius;
        }

        public float GetArea()
        {
            return (float)(Math.PI * Math.Pow(radius, 2) / 2);
        }

        public float GetPerimeter()
        {
            return (float)(Math.PI * radius) + (2 * radius);
        }

        public float GetRadius()
        {
            return this.radius;
        }
    }
}
