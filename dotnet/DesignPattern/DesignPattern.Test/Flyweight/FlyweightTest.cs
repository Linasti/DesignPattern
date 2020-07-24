using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Flyweight;
using DesignPattern.Flyweight.Interfaces;

namespace DesignPattern.Test.Flyweight
{
    [TestFixture]
    public class FlyweightTest
    {
        private static string[] colors = { "Red", "Green", "Blue", "White", "Black" };
        [Test]
        public void Should_return_Same_Object()
        {
            Shape firstCircle = ShapeFactory.GetCircle(colors[0]);
            Shape secondCircle = ShapeFactory.GetCircle(colors[0]);
            Assert.AreSame(firstCircle,secondCircle);
        }

        [Test]
        public void Should_return_Different_Object()
        {
            Shape firstCircle = ShapeFactory.GetCircle(colors[0]);
            Shape secondCircle = ShapeFactory.GetCircle(colors[1]);
            Assert.AreNotSame(firstCircle,secondCircle);
        }
    }
}
