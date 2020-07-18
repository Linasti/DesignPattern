using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.AbstractFactory.Interfaces;
using DesignPattern.AbstractFactory.Models;

namespace DesignPattern.AbstractFactory.Factories
{
    public class FishFactory : Interfaces.AbstractFactory
    {
        public override IPet GetPet(string petName)
        {
            if (petName.ToLower() == "tuna")
            {
                return new Tuna();
            }else if (petName.ToLower() == "tuna")
            {
                return  new Bonito();
            }
            throw new ArgumentOutOfRangeException(nameof(petName), petName, null);
        }
    }
}
