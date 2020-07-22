using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Decorator;
using DesignPattern.Decorator.Interfaces;
using DesignPattern.Decorator.Models;

namespace DesignPattern.Test.Decorator
{
    [TestFixture]
    public class DecoratorTest
    {
        [Test]
        public void CicleTest()
        {
            Shape circle = new Circle();
            Assert.AreEqual("Shape: Circle", circle.draw());
        }

        [Test]
        public void redCircleTest()
        {
            Shape redCircle = new RedShapeDecorator(new Circle());
            Assert.AreEqual("Shape: Circle Border Color: Red", redCircle.draw());
        }

        [Test]
        public void redRectangleTest()
        {
            Shape redRectangle = new RedShapeDecorator(new Rectangle());
            Assert.AreEqual("Shape: Rectangle Border Color: Red", redRectangle.draw());
        }
    }
}
