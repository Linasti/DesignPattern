using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Prototype.Interfaces;
using DesignPattern.Prototype.Models;

namespace DesignPattern.Prototype
{
    public class ShapeCache
    {
        private static IDictionary<string,Shape> _shapeDictionary = new Dictionary<string, Shape>();

        public static Shape GetShape(string ShapeId)
        {
            Shape cachedShape = _shapeDictionary[ShapeId];
            return cachedShape.Clone() as Shape;
        }

        public static void LoadCache()
        {
            Circle circle = new Circle();
            circle.SetId("1");
            _shapeDictionary.Add(circle.GetId(),circle);
            
            Square square = new Square();
            square.SetId("2");
            _shapeDictionary.Add(square.GetId(),square);

            Rectangle rectangle = new Rectangle();
            rectangle.SetId("3");
            _shapeDictionary.Add(rectangle.GetId(),rectangle);
        }
    }
}
