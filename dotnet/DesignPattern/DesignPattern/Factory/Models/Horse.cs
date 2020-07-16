using System;
using System.Collections.Generic;
using System.Text;

using DesignPattern.Factory.Interfaces;

namespace DesignPattern.Factory.Models
{
    public class Horse : IPet
    {
        string IPet.Eat()
        {
            return "Grass";
        }

        int IPet.Walk()
        {
            return 15;
        }
    }
}
