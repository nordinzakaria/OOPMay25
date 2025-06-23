using Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Shapes.Shapes.Rectangle;

namespace Shapes
{
    internal class App
    {
        public void run()
        {
            List<Shape> shapes = new List<Shape>();

            Random randgen = new Random();

            // create circles
            for (int i = 0; i<10; i++)
            {
                Circle circ = new Circle(randgen.Next(100), 
                                         randgen.Next(300), 
                                         randgen.Next(300));
                shapes.Add(circ);
            }
            // create rectangles
            for (int i = 0; i < 10; i++)
            {
                Rectangle rect = new Rectangle(randgen.Next(100),
                                                randgen.Next(300),
                                                 randgen.Next(300),
                                            randgen.Next(300));
                shapes.Add(rect);
            }


            // POLYMORPHISM
            float total = 0;
            foreach (Shape sh in shapes)
            {
                total += sh.CalcArea();
            }
            Console.WriteLine(total);


        }

    }
}
