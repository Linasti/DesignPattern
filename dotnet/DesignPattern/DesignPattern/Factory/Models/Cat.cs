using System;
using System.Collections.Generic;
using System.Text;

using DesignPattern.Factory.Interfaces;

namespace DesignPattern.Factory.Models
{
    public class Cat : IPet
    {
        string IPet.Eat()
        {
            return "Mouse";
        }

        int IPet.Walk()
        {
            return 20;
        }
    }
}
