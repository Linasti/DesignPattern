using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Bridge.Interfaces;

namespace DesignPattern.Bridge
{
    public class Circle : Shape
    {
        private readonly int _x;
        private int _y;
        private int _radius;

        public Circle(int x, int y, int radius, DrawAPI drawAPI) 
            : base(drawAPI)
        {
            this._x = x;
            this._y = y;
            this._radius = radius;
        }

        public override string Draw()
        {
            return drawAPI.DrawCircle(_radius, _x, _y);
        }
    }
}
