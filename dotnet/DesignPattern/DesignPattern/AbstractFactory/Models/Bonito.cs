using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.Models
{
    public class Bonito : IPet
    {
        int IPet.MoveSpeed()
        {
            return 7;
        }

        string IPet.Eat()
        {
            return "Mackerel";
        }
    }
}
