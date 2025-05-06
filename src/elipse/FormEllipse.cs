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
    public partial class FormEllipse : FormShape
    {
        private Ellipse ellipse;

        public FormEllipse()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            if (!this.CheckBoxes()) return;

            this.ellipse = new Ellipse(float.Parse(this.txtMajorAxis.Text), float.Parse(this.txtMinorAxis.Text));

            this.txtPerimeter.Text = this.ellipse.GetPerimeter().ToString();
            this.txtArea.Text = this.ellipse.GetArea().ToString();

            this.graph.DrawEllipse(this.pen, 0, 0, this.ellipse.GetMajorAxis(), this.ellipse.GetMinorAxis());
        }

        protected override bool CheckBoxes()
        {
            return IsUsefulNumber(this.txtMajorAxis.Text) & IsUsefulNumber(this.txtMinorAxis.Text);
        }
    }
}
