using DesignPattern.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype.Models
{
    public class Rectangle: Shape
    {
        public Rectangle()
        {
            this.Type = "Rectangle";
        }
        public override string Draw()
        {
            return "Draw rectangle";
        }
    }
}
