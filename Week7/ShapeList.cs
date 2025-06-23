using Shapes.Shapes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class ShapeList
    {
        public static List<Circle> circles = new List<Circle>();
        public static Graphics g1 {  get; set; }

        private ShapeList() { }

        public static void AddCircle(Circle circle)
        {
            circles.Add(circle);
        }

        public static void Clear()
        {
            circles.Clear();
        }

        public static void Draw()
        {
            foreach (var item in circles)
            {
                item.Draw(g1);
            }
        }
    }
}
