using System;
using System.Collections.Generic;
using System.Text;

using DesignPattern.Factory;
using DesignPattern.Factory.Interfaces;
using DesignPattern.Factory.Models;

using NUnit.Framework;

namespace DesignPattern.Test.Factory
{
    class PetFactoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

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
