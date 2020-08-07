using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Memento;

namespace DesignPattern.Test.Memento
{
    [TestFixture]
    public class MementoTest
    {
        [Test]
        public void TestMethod()
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();
      
            originator.SetState("State #1");
            originator.SetState("State #2");
            careTaker.Add(originator.SaveStateToMemento());
      
            originator.SetState("State #3");
            
            careTaker.Add(originator.SaveStateToMemento());
            originator.SetState("State #4");

            Assert.AreEqual("State #4",originator.GetState());
      
            originator.GetStateFromMemento(careTaker.Get(0));
            Assert.AreEqual("State #2", originator.GetState());

            originator.GetStateFromMemento(careTaker.Get(1));
            Assert.AreEqual("State #3", originator.GetState());
        }
    }
}
