using System;
using System.Collections.Generic;
using System.Text;

using DesignPattern.Factory.Interfaces;

namespace DesignPattern.Factory.Models
{
    public class Dog : IPet
    {
        string IPet.Eat()
        {
            return "Bones";
        }

        int IPet.Walk()
        {
            return 10;
        }
    }
}
