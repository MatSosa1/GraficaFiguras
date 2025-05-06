using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasTarea.src.circle
{
    internal class Circle : RoundedShape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public float GetArea()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }

        public float GetPerimeter()
        {
            return (float)(Math.PI * 2 * radius);
        }

        public float GetRadius()
        {
            return radius;
        }
    }
}
