using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Prototype;
using DesignPattern.Prototype.Interfaces;

namespace DesignPattern.Test.Prototype
{
    [TestFixture]
    public class PrototypeTest
    {
        [Test]
        public void TestMethod()
        {
            ShapeCache.LoadCache();
            
            Shape cloneShape1 = ShapeCache.GetShape("1");
            Assert.AreEqual(cloneShape1.GetShapeType(), "Circle");

            Shape cloneShape2 = ShapeCache.GetShape("2");
            Assert.AreEqual(cloneShape2.GetShapeType(), "Square");

            Shape cloneShape3 = ShapeCache.GetShape("3");
            Assert.AreEqual(cloneShape3.GetShapeType(), "Rectangle");

        }
    }
}
