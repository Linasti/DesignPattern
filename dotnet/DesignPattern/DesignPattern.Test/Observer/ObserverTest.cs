using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Observer;
using DesignPattern.Observer.Models;

namespace DesignPattern.Test.Observer
{
    [TestFixture]
    public class ObserverTest
    {
        [Test]
        public void TestMethod()
        {
            Subject subject = new Subject();

            HexaObserver hexa = new HexaObserver(subject);
            OctalObserver octal = new OctalObserver(subject);
            BinaryObserver binary = new BinaryObserver(subject);

            string result = subject.SetState(15);
            Assert.AreEqual("hexa String: f octal String: 17 Binary String: 1111 ",result);
        }
    }
}
