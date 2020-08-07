using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Iterator.Models;
using DesignPattern.Iterator;

namespace DesignPattern.Test.Iterator
{
    [TestFixture]
    public class IteratorTest
    {
        [Test]
        public void TestMethod()
        {
            string[] names = {"Robert" , "John" ,"Julie" , "Lora"};
            NameContainer namesRepository = new NameContainer(names);
            var iterator= namesRepository.GetIterator();

            for(int i=0; iterator.HasNext();i++){
                string name = (string)iterator.Next();
                Assert.AreEqual(names[i],name);
            } 	
        }
    }
}
