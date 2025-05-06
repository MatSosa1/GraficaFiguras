using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.rectangle.FormRectangle();
            form.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.triangle.FormTriangle();
            form.Show();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.square.FormSquare();
            form.Show();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.circle.FormCircle();
            form.Show();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.elipse.FormEllipse();
            form.Show();
        }

        private void btnSemicircle_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.semicircle.FormSemicircle();
            form.Show();
        }

        private void btnTrapeze_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.trapeze.FormTrapeze();
            form.Show();
        }

        private void btnTrapezoid_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.trapezoid.FormTrapezoid();
            form.Show();
        }

        private void btnRhombus_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.rhombus.FormRhombus();
            form.Show();
        }

        private void btnRhomboid_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.rhomboid.FormRhomboid();
            form.Show();
        }

        private void btnDeltoid_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.deltoid.FormDeltoid();
            form.Show();
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            src.FormShape form = new src.star.FormStar();
            form.Show();
        }
    }
}
