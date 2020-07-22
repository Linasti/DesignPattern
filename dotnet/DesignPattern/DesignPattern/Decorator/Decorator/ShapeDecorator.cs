using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Decorator.Interfaces;

namespace DesignPattern.Decorator.Decorator
{
    public class ShapeDecorator: Shape
    {
        protected readonly Shape _decorateShape;

        public ShapeDecorator(Shape decorateShape)
        {
            _decorateShape = decorateShape;
        }
        public virtual string draw()
        {
            return _decorateShape.draw();
        }
    }
}
