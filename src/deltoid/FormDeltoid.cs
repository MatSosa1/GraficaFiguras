using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.deltoid
{
    public partial class FormDeltoid : FormShape
    {
        private Deltoid d;

        public FormDeltoid()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            if (!this.CheckBoxes()) return;

            this.d = new Deltoid(float.Parse(this.txtHeight.Text), float.Parse(this.txtMajorSide.Text), float.Parse(this.txtMinorSide.Text));

            this.txtPerimeter.Text = this.d.GetPerimeter().ToString();
            this.txtArea.Text = this.d.GetArea().ToString();

            this.graph.DrawPolygon(this.pen, this.d.GetPoints());
        }

        protected override bool CheckBoxes()
        {
            return IsUsefulNumber(txtHeight.Text) & IsUsefulNumber(txtMajorSide.Text) & IsUsefulNumber(txtMinorSide.Text);
        }
    }
}
