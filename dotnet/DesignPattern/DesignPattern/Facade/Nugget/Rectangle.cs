using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade.Nugget
{
    public class Rectangle : IShape
    {
        string IShape.Draw()
        {
            return "Drawing Rectangle!";
        }
    }
}
