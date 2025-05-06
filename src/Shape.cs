using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src
{
    public interface Shape
    {
        float GetPerimeter();
        float GetArea();
    }

    public interface RoundedShape: Shape
    {
        float GetRadius();
    }

    public interface FixedShape: Shape
    {
        float GetWidth();
        float GetHeight();
        PointF[] GetPoints();
    }

    public interface EllipseShape : Shape
    {
        float GetMajorAxis();
        float GetMinorAxis();
    }
}
