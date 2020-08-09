using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Template;
using DesignPattern.Template.Models;

namespace DesignPattern.Test.Template
{
    [TestFixture]
    public class TemplateTest
    {
        [Test]
        public void TestMethod()
        {
            Game cricketGame = new Cricket();
            string cricketResult =cricketGame.Play();
            Assert.AreEqual("Cricket Game Initialized! Start playing. Cricket Game Started. Enjoy the game! Cricket Game Finished!",
                cricketResult);


            Game footGame = new Football();
            string footResult = footGame.Play();
            Assert.AreEqual("Football Game Initialized! Start playing. Football Game Started. Enjoy the game! Football Game Finished!",
                footResult);
        }
    }
}
