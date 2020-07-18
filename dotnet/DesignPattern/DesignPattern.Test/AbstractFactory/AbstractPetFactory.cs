using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.AbstractFactory;
using DesignPattern.AbstractFactory.Interfaces;
using DesignPattern.AbstractFactory.Models;

namespace DesignPattern.Test.AbstractFactory
{
    [TestFixture]
    public class AbstractPetFactory
    {
        [TestCase(typeof(Cat), 20, "Mouse", "cat", EPetGroup.Mammals)]
        [TestCase(typeof(Tuna), 5, "sardine", "tuna", EPetGroup.Fish)]
        public void GetMyPet(Type type, int speed, string food, string petName, EPetGroup petGroup)
        {
            DesignPattern.AbstractFactory.Interfaces.AbstractFactory factory = FactoryProducter.GetFactory(petGroup);

            IPet animal = factory.GetPet(petName);

            Assert.IsInstanceOf(type, animal);
            Assert.AreEqual(speed, animal.MoveSpeed());
            Assert.AreEqual(food, animal.Eat());

        }
    }
}
