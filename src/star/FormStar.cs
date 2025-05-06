using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.star
{
    public partial class FormStar : FormShape
    {
        private Star s;

        public FormStar()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            if (!this.CheckBoxes()) return;

            this.s = new Star(float.Parse(this.txtSide.Text));

            this.txtPerimeter.Text = this.s.GetPerimeter().ToString();
            this.txtArea.Text = this.s.GetArea().ToString();

            this.graph.DrawPolygon(this.pen, this.s.GetPoints());
        }

        protected override bool CheckBoxes()
        {
            return IsUsefulNumber(txtSide.Text);
        }
    }
}
