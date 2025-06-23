using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    internal class Rectangle : Shape
    {
        public float X {  get; set; }
        public float Y { get; set; }

        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle() {  Width = 0; Height = 0;}

        public Rectangle(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public float CalcArea()
        {
            return 0;
        }

        public float CalcPerimeter() 
        { return 0; }
    }
}
