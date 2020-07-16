using System;
using System.Collections.Generic;
using System.Text;

using DesignPattern.Factory.Interfaces;
using DesignPattern.Factory.Models;

namespace DesignPattern.Factory
{
    public class PetFactory
    {
        /// <summary>
        /// Return a <see cref="IPet"/>  
        /// </summary>
        /// <param name="MyPetType">The pet type</param>
        /// <returns>A new instance of IPet</returns>
        public static IPet GetMyPet(EPetType MyPetType)
        {
            switch ( MyPetType )
            {
                case EPetType.Cat:
                    return new Cat();
                case EPetType.Dog:
                    return new Dog();
                case EPetType.Horse:
                    return new Horse();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
