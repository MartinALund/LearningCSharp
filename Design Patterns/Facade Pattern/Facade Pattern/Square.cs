using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("SQUARE");

        }
    }
}
