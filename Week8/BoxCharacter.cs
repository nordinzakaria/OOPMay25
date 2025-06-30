using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class BoxCharacter : Character
    {
        public Color Color { get; set; }

        public BoxCharacter() 
        {
            Pos = new Position();
        }

        public void Move() // overriding
        {
            Pos.X += 10;
        }
    }
}
