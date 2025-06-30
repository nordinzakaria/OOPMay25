using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Character
    {
        public Position Pos {  get; set; }

        public Character()
        {
            Pos = new Position();
        }

        public void Move()
        {
            Pos.X += 10;
            Pos.Y += 10;
        }

    }
}
