using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Prototype.Interfaces;

namespace DesignPattern.Prototype.Models
{
    public class Circle: Shape
    {
        public Circle()
        {
            this.Type = "Circle";
        }
        public override string Draw()
        {
            return "Draw cicle";
        }
    }
}
