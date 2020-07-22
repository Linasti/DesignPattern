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
using DesignPattern.Facade;

namespace DesignPattern.Test.Factory
{
    [TestFixture]
    public class ShapeFacadeTest
    {
        [Test]
        public void CircleValidation()
        {
            ShapeFacade shapeFacade = new ShapeFacade();

            Assert.AreEqual("Drawing Circle!", shapeFacade.DrawCircle());
        }

        [Test]
        public void SquareValidation()
        {
            ShapeFacade shapeFacade = new ShapeFacade();

            Assert.AreEqual("Drawing Square!", shapeFacade.DrawSquare());
        }

        [Test]
        public void RectangleValidation()
        {
            ShapeFacade shapeFacade = new ShapeFacade();

            Assert.AreEqual("Drawing Rectangle!", shapeFacade.DrawRectangle());
        }
    }
}
