using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    internal interface Shape  // Shape is an interface
    {
        // Only list down the method headers
        public float CalcArea();    
        public float CalcPerimeter();
    }
}
