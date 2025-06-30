using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal abstract class Character // superclass or parent class
    {
        public Position Pos {  get; set; }

        public Character()
        {
            Pos = new Position();
        }

        public abstract void Move();

    }
}
