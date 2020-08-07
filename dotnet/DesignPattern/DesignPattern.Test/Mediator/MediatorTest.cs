using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Mediator;

namespace DesignPattern.Test.Mediator
{
    [TestFixture]
    public class MediatorTest
    {
        [Test]
        public void TestMethod()
        {
            User robert = new User("Robert");
            string messageSend = robert.SendMessage("Hi! John!");
            Assert.IsTrue(messageSend.Contains("[Robert] : Hi! John!"));

            User john = new User("John");
            messageSend = john.SendMessage("Hello! Robert!");
            Assert.IsTrue(messageSend.Contains("[John] : Hello! Robert!"));
        }
    }
}
