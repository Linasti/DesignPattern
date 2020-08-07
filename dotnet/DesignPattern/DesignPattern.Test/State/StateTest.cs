using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.State;
using DesignPattern.State.Models;

namespace DesignPattern.Test.State
{
    [TestFixture]
    public class StateTest
    {
        [Test]
        public void TestMethod()
        {
            Context context = new Context();

            StartState startState = new StartState();
            
            string resultAction = startState.DoAction(context);
            Assert.AreEqual("Player is in start state",resultAction);
            
            string currentState = context.GetState().ToString();
            Assert.AreEqual("Start State",currentState);

            StopState stopState = new StopState();

            resultAction =stopState.DoAction(context);
            Assert.AreEqual("Player is in stop state",resultAction);
            
            currentState = context.GetState().ToString();
            Assert.AreEqual("Stop State",currentState);
        }
    }
}
