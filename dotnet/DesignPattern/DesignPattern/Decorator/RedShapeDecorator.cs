using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Decorator.Decorator;
using DesignPattern.Decorator.Interfaces;

namespace DesignPattern.Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decorateShape) 
            : base(decorateShape)
        {}

        public override string draw()
        {
            string drawShape = _decorateShape.draw();
            return $"{drawShape} {SetRedBorder(_decorateShape)}";
        }
         
        private string SetRedBorder(Shape decorateShape)
        {
            return "Border Color: Red";
        }
    }
}
