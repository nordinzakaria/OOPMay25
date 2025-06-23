using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
                            // INHERITANCE
                            // - whatever public, protected is accessible in here
    internal class ColoredCircle : Circle
    {
        public Color Color {  get; set; }

        public ColoredCircle() { }

        public void Draw(Graphics g1)
        {
            Pen p = new Pen(this.Color, 2);
            g1.DrawEllipse(p, this.X, this.Y, this.Radius, this.Radius);
        }
    }
}
}
