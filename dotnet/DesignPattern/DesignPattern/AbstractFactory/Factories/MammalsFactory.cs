using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.AbstractFactory.Interfaces;
using DesignPattern.AbstractFactory.Models;

namespace DesignPattern.AbstractFactory.Factories
{
    public class MammalsFactory : Interfaces.AbstractFactory
    {
        public override IPet GetPet(string petName)
        {
            if (petName.ToLower() == "cat")
            {
                return new Cat();
            }
            else if (petName.ToLower() == "dog")
            {
                return  new Dog();
            }
            else if (petName.ToLower() == "horse")
            {
                return  new Horse();
            }
            throw new ArgumentOutOfRangeException(nameof(petName), petName, null);
        }
    }
}
