using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigurasTarea.src;

namespace FigurasTarea.src.rectangle
{
    public partial class FormRectangle : FormShape
    {
        private Rectangle rectangle;

        public FormRectangle()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            if (!this.CheckBoxes()) return;

            this.rectangle = new Rectangle(float.Parse(this.txtWidth.Text), float.Parse(this.txtHeight.Text));

            this.txtPerimeter.Text = this.rectangle.GetPerimeter().ToString();
            this.txtArea.Text = this.rectangle.GetArea().ToString();

            this.graph.DrawPolygon(this.pen, this.rectangle.GetPoints());
        }

        protected override bool CheckBoxes()
        {
            return IsUsefulNumber(txtWidth.Text) & IsUsefulNumber(txtHeight.Text);
        }
    }
}
