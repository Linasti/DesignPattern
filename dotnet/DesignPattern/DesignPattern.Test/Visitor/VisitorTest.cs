using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Visitor;
using DesignPattern.Visitor.Models;

namespace DesignPattern.Test.Visitor
{
    [TestFixture]
    public class VisitorTest
    {
        [Test]
        public void TestMethod()
        {
            Computer computer = new Computer();
            string result = computer.Accept(new ComputerPartDisplayVisitor());
            Assert.AreEqual("Displaying Mouse. Displaying Keyboard. Displaying Monitor. Displaying Computer.",
                result);
        }
    }
}
