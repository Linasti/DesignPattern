using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.AbstractFactory.Factories;


namespace DesignPattern.AbstractFactory.Interfaces
{
    public abstract class AbstractFactory
    {
        public abstract IPet GetPet(string petName);
    }
}
