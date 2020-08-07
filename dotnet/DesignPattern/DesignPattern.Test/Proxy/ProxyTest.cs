using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Proxy;

namespace DesignPattern.Test.Proxy
{
    [TestFixture]
    public class ProxyTest
    {
        [Test]
        public void TestMethod()
        {
            string fileImage = "myImage"; 
           ProxyImage proxyImage = new ProxyImage(fileImage);
           string loadingDisplayImage = proxyImage.Display();
           Assert.AreEqual("Displaying "+fileImage,loadingDisplayImage);
        }
    }
}
