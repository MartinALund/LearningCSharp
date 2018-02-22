using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape1 = shapeFactory.getShape("CIRCLE");
            shape1.Draw();

            IShape shape2 = shapeFactory.getShape("SQUARE");
            shape2.Draw();

            IShape shape3 = shapeFactory.getShape("RECTANGLE");
            shape3.Draw();

            Console.ReadKey();

        }
    }
}
