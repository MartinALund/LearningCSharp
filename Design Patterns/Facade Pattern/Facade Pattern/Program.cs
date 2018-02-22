using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMakerFacade facade = new ShapeMakerFacade();
            facade.DrawCircle();
            facade.DrawRectangle();
            facade.DrawSquare();
            Console.ReadKey();
        }
    }
}
