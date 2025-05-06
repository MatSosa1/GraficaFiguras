using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src.square
{
    public partial class FormSquare : FormShape
    {
        private Square figura;

        public FormSquare()
        {
            InitializeComponent();
        }

        public override void btnCalc_Click(object sender, EventArgs e)
        {
            this.figura = new Square(float.Parse(this.textBox1.Text));

            this.txtPerimeter.Text = this.figura.GetPerimeter().ToString();
            this.txtArea.Text = this.figura.GetArea().ToString();

            this.graph.DrawPolygon(this.pen, this.figura.GetPoints());
        }
    }
}
