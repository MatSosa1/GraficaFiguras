using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.rhombus
{
    public partial class FormRhombus : FormShape
    {
        private Rhombus r;

        public FormRhombus()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            if (!this.CheckBoxes()) return;

            this.r = new Rhombus(float.Parse(this.txtMajorDiag.Text), float.Parse(this.txtMinorDiag.Text));

            this.txtPerimeter.Text = this.r.GetPerimeter().ToString();
            this.txtArea.Text = this.r.GetArea().ToString();

            this.graph.DrawPolygon(this.pen, this.r.GetPoints());
        }

        protected override bool CheckBoxes()
        {
            return IsUsefulNumber(txtMajorDiag.Text) & IsUsefulNumber(txtMinorDiag.Text);
        }
    }
}
