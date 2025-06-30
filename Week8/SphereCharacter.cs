using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class SphereCharacter: Character
    {
        public int Velocity {  get; set; }

        public SphereCharacter() : base() { }

        public void Move()  // overriding
        {
            Pos.Y += Velocity;
        }
    }
}
