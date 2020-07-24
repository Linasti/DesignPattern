using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Flyweight.Interfaces;
using DesignPattern.Flyweight.Models;

namespace DesignPattern.Flyweight
{
    public class ShapeFactory
    {
        private static readonly Dictionary<string,Shape> circles = new Dictionary<string,Shape>();

        public static Shape GetCircle(string color)
        {
            Circle circle = null;
            if (circles.ContainsKey(color))
            {
                circle = circles[color] as Circle; 
            }

            if (circle != null) 
                return circle;

            circle = new Circle(color);
            circles.Add(color, circle);
            Console.WriteLine($"Creating circle of color: {color}");

            return circle;
        }

    }
}
