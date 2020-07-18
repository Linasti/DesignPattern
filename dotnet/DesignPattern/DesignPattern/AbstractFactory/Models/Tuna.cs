using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.Models
{
    public class Tuna : IPet
    {
        int IPet.MoveSpeed()
        {
            return 5;
        }

        string IPet.Eat()
        {
            return "sardine";
        }
    }
}
