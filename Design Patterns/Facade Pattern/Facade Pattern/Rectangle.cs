using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("RECTANGLE");

        }
    }
}
