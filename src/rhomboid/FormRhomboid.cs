using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.rhomboid
{
    public partial class FormRhomboid : xdForm
    {
        private Rhomboid r;

        public FormRhomboid()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            this.r = new Rhomboid(float.Parse(this.txtBase.Text), float.Parse(this.txtHeight.Text), float.Parse(this.txtSide.Text));

            this.txtPerimeter.Text = this.r.GetPerimeter().ToString();
            this.txtArea.Text = this.r.GetArea().ToString();

            this.graph.DrawPolygon(this.pen, this.r.GetPoints());
        }
    }
}
