using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy;
using DesignPattern.Strategy.Models;

namespace DesignPattern.Test.Strategy
{
    [TestFixture]
    public class StrategyTest
    {
        public int num1 = 15;
        public int num2 = 7;
        [Test]
        public void TestMethod()
        {


            Context addContext = new Context(new OperationAdd());
            CheckResult(addContext,22);

            Context subContext = new Context(new OperationSubstract());
            CheckResult(subContext,8);

            Context multiplContext = new Context(new OperationMultiply());
            CheckResult(multiplContext,105);

        }

        private void CheckResult(Context context, int expected)
        {
            Assert.AreEqual(expected, context.ExecuteStrategy(num1, num2));
        }
    }
}
