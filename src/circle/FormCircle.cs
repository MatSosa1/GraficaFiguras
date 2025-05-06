using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.circle
{
    public partial class FormCircle : xdForm
    {
        private Circle circle;

        public FormCircle()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            this.circle = new Circle(float.Parse(this.txtRadius.Text));

            this.txtPerimeter.Text = this.circle.GetPerimeter().ToString();
            this.txtArea.Text = this.circle.GetArea().ToString();

            this.graph.DrawEllipse(this.pen, 0, 0, this.circle.GetRadius() * 2, this.circle.GetRadius() * 2);
        }
    }
}
