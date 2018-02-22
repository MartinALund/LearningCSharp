using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class ShapeMakerFacade
    {
        private IShape Circle;
        private IShape Square;
        private IShape Rectangle;

        public ShapeMakerFacade()
        {
            Circle = new Circle();
            Square = new Square();
            Rectangle = new Rectangle();
        }

        public void DrawCircle()
        {
            Circle.Draw();
        }

        public void DrawSquare()
        {
            Square.Draw();
        }

        public void DrawRectangle()
        {
            Rectangle.Draw();
        }
    }
}
