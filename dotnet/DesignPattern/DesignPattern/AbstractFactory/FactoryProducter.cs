using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.AbstractFactory.Factories;

namespace DesignPattern.AbstractFactory
{
    public class FactoryProducter
    {
        public static Interfaces.AbstractFactory GetFactory(EPetGroup petGroup)
        {
            switch (petGroup)
            {
                
                case EPetGroup.Birds:
                case EPetGroup.Reptiles:
                case EPetGroup.Amphibians:
                case EPetGroup.Arthropods:
                    break;
                case EPetGroup.Mammals:
                    return new MammalsFactory();
                case EPetGroup.Fish:
                    return new FishFactory();
                default:
                    throw new ArgumentOutOfRangeException(nameof(petGroup), petGroup, null);
            }
            return new FishFactory();
        }
    }
}
