using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.elipse
{
    public partial class FormEllipse : xdForm
    {
        private Ellipse ellipse;

        public FormEllipse()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            this.ellipse = new Ellipse(float.Parse(this.txtMajorAxis.Text), float.Parse(this.txtMinorAxis.Text));  // Agrega los txtbox para los valores de aquí

            this.txtPerimeter.Text = this.ellipse.GetPerimeter().ToString();
            this.txtArea.Text = this.ellipse.GetArea().ToString();

            this.graph.DrawEllipse(this.pen, 0, 0, this.ellipse.GetMajorAxis(), this.ellipse.GetMinorAxis());
        }
    }
}
