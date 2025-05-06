using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigurasTarea.src.square;

namespace FigurasTarea.src.triangle
{
    public partial class FormTriangle : FormShape
    {
        private Triangle triangle;

        public FormTriangle()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            if (!this.CheckBoxes()) return;

            this.triangle = new Triangle(float.Parse(this.textBox1.Text));

            this.txtPerimeter.Text = this.triangle.GetPerimeter().ToString();
            this.txtArea.Text = this.triangle.GetArea().ToString();

            this.graph.DrawPolygon(this.pen, this.triangle.GetPoints());
        }

        protected override bool CheckBoxes()
        {
            return IsUsefulNumber(textBox1.Text);
        }
    }
}
