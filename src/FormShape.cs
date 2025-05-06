using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea.src
{
    public abstract partial class FormShape : Form
    {
        protected Graphics graph;
        protected Pen pen;

        public FormShape()
        {
            InitializeComponent();

            this.graph = picCanvas.CreateGraphics();
            this.pen = new Pen(Color.Black, 3);
        }

        public abstract void btnCalc_Click(object sender, EventArgs e);

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.picCanvas.Image = null;
        }

        protected bool IsUsefulNumber(String text)
        {
            int x;

            if (!int.TryParse(text, out x)) return false;

            return x >= 0;
        }

        protected abstract bool CheckBoxes();
    }
}
