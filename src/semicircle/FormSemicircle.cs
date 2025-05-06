using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.semicircle
{
    public partial class FormSemicircle : FormShape
    {
        private Semicircle semi;

        public FormSemicircle()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            if (!this.CheckBoxes()) return;

            this.semi = new Semicircle(float.Parse(this.txtRadius.Text));

            this.txtPerimeter.Text = this.semi.GetPerimeter().ToString();
            this.txtArea.Text = this.semi.GetArea().ToString();

            float r = this.semi.GetRadius();

            this.graph.DrawArc(this.pen, 0, 0, r * 4, r * 2, 180, 180);
            this.graph.DrawLine(this.pen, new PointF(4 * r, r), new PointF(0, r));
        }

        protected override bool CheckBoxes()
        {
            return IsUsefulNumber(txtRadius.Text);
        }
    }
}
