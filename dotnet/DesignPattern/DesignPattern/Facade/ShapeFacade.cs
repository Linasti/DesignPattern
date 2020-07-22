using System;
using System.Collections.Generic;
using System.Text;

using DesignPattern.Facade.Nugget;

namespace DesignPattern.Facade
{
    public class ShapeFacade
    {
        readonly IShape _circle;
        readonly IShape _rectangle;
        readonly IShape _square;

        public ShapeFacade()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public string DrawCircle()
        {
            return _circle.Draw();
        }

        public string DrawRectangle()
        {
            return _rectangle.Draw();
        }

        public string DrawSquare()
        {
            return _square.Draw();
        }
    }
}
