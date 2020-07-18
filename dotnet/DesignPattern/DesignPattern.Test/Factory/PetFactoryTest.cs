using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Factory.Interfaces;
using DesignPattern.Factory.Models;
using DesignPattern.Factory;

namespace DesignPattern.Test.Factory
{
    [TestFixture]
    public class PetFactoryTest
    {
        [TestCase(EPetType.Cat, typeof(Cat), 20, "Mouse")]
        [TestCase(EPetType.Dog, typeof(Dog), 10, "Bones")]
        [TestCase(EPetType.Horse, typeof(Horse), 15, "Grass")]
        public void GetMyPet(EPetType petType, Type type, int speed, string food)
        {
            IPet animal = PetFactory.GetMyPet(petType);

            Assert.IsInstanceOf(type, animal);
            Assert.AreEqual(speed, animal.Walk());
            Assert.AreEqual(food, animal.Eat());
        }
    }
}
