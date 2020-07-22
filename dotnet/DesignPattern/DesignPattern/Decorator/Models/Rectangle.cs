using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Decorator.Interfaces;

namespace DesignPattern.Decorator.Models
{
    public class Rectangle: Shape
    {
        public string draw()
        {
            return "Shape: Rectangle";
        }
    }
}
