using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.NullObject;
using DesignPattern.NullObject.Interfaces;

namespace DesignPattern.Test.NullObject
{
    [TestFixture]
    public class NullObjectTest
    {
        [Test]
        public void TestMethod()
        {
            AbstractCustomer customerRob = CustomerFactory.GetCustomer("Rob");
            Assert.AreEqual("Rob",customerRob.GetName());

            AbstractCustomer customerRob2 = CustomerFactory.GetCustomer("rob");
            Assert.AreEqual("Rob",customerRob2.GetName());


            AbstractCustomer customerUnknow = CustomerFactory.GetCustomer("unknow");
            Assert.AreEqual("Not Available in Customer Database",customerUnknow.GetName());
        }
    }
}
