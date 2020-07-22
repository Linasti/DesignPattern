using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Bridge;
using DesignPattern.Bridge.Interfaces;
using DesignPattern.Bridge.Models;
using Microsoft.VisualBasic.CompilerServices;

namespace DesignPattern.Test.Bridge
{
    [TestFixture]
    public class BridgeTest
    {
        [TestCase(100,100,10,typeof(RedCircle), "Drawing Circle[ color: red, radius: 10, x: 100, 100]")]
        [TestCase(100,100,10,typeof(GreenCircle), "Drawing Circle[ color: green, radius: 10, x: 100, 100]")]
        public void TestMethod(int x,int y, int radius,Type drawApiType,string expectedDrawing)
        { 
            DrawAPI drawApi = (DrawAPI)Activator.CreateInstance(drawApiType);

            Shape circle = new Circle(x,y,radius, drawApi);
            string outputDrawing = circle.Draw();
            Assert.AreEqual(expectedDrawing,outputDrawing);
        }
    }
}
