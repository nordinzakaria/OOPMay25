using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    internal class Circle
    {
        private float _radius;
        public float Radius 
        { 
            get { return _radius; } 
            set { if (value > 0) _radius = value; } 
        }
        public float X { get; set; }
        public float Y { get; set; }

        public Circle() { }
        public Circle(float x, float y)
        {
            this.X = x;
            this.Y = y;            
        }
        public Circle(float radius, float x, float y)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        public void Draw(Graphics g1)
        {
            Pen p = new Pen(Color.Blue, 2);
            g1.DrawEllipse(p, this.X, this.Y, this.Radius, this.Radius);
        }
    }
}