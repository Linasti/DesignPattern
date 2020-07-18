using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Singleton;

namespace DesignPattern.Test.Singleton
{
    [TestFixture]
    public class SingletonTest
    {
        [Test]
        public void TestMethod()
        {
            SingleObject singletonObject = SingleObject.GetInstance();
            string action = singletonObject.DoAction();

            Assert.AreEqual("myAction", action);
        }
    }
}
