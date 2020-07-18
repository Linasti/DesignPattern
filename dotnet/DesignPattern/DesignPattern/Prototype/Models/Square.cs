using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Prototype.Interfaces;

namespace DesignPattern.Prototype.Models
{
    public class Square : Shape
    {
        public Square()
        {
            this.Type = "Square";
        }
        public override string Draw()
        {
            return "Draw Square";
        }
    }
}
