using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.trapezoid
{
    public partial class FormTrapezoid : FormShape
    {
        private Trapezoid t;

        public FormTrapezoid()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            if (!this.CheckBoxes()) return;

            this.t = new Trapezoid(float.Parse(this.txtDiag1.Text), float.Parse(this.txtDiag2.Text), float.Parse(this.txtBase.Text));

            this.txtPerimeter.Text = this.t.GetPerimeter().ToString();
            this.txtArea.Text = this.t.GetArea().ToString();

            this.graph.DrawPolygon(this.pen, this.t.GetPoints());
        }

        protected override bool CheckBoxes()
        {
            return IsUsefulNumber(txtDiag1.Text) & IsUsefulNumber(txtDiag2.Text) & IsUsefulNumber(txtBase.Text);
        }
    }
}
