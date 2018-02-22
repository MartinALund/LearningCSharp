using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ShapeFactory
    {

        public IShape getShape(string ShapeType)
        {
            if (ShapeType == null)
                return null;

            if (ShapeType.Equals("CIRCLE"))
                return new Circle();
            else if (ShapeType.Equals("RECTANGLE"))
                return new Rectangle();
            else if (ShapeType.Equals("SQUARE"))
                return new Square();

            return null;
        }
    }
}
