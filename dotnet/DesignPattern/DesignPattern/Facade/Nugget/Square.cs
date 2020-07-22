using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade.Nugget
{
    public class Square : IShape
    {
        string IShape.Draw()
        {
            return "Drawing Square!";
        }
    }
}
