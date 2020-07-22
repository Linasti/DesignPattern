using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade.Nugget
{
    public class Circle : IShape
    {
        string IShape.Draw()
        {
            return "Drawing Circle!";
        }
    }
}
