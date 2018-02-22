using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("RECTANGLE METHOD");

        }
    }
}
