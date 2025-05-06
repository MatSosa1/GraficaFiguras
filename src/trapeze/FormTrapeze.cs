using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.trapeze
{
    public partial class FormTrapeze : FormShape
    {
        private Trapeze t;

        public FormTrapeze()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            if (!this.CheckBoxes()) return;

            this.t = new Trapeze(float.Parse(this.txtMajorBase.Text), float.Parse(this.txtMinorBase.Text), float.Parse(this.txtHeight.Text));

            this.txtPerimeter.Text = this.t.GetPerimeter().ToString();
            this.txtArea.Text = this.t.GetArea().ToString();

            this.graph.DrawPolygon(this.pen, this.t.GetPoints());
        }

        protected override bool CheckBoxes()
        {
            return IsUsefulNumber(txtMajorBase.Text) & IsUsefulNumber(txtMinorBase.Text) & IsUsefulNumber(txtHeight.Text);
        }
    }
}
