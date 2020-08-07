using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Interpreter.Interfaces;
using DesignPattern.Interpreter.Models;

namespace DesignPattern.Test.Interpreter
{
    [TestFixture]
    public class InterpreterTest
    {
        //Rule: Robert and John are male
        public static Expression GetMaleExpression(){
            Expression robert = new TerminalExpression("Robert");
            Expression john = new TerminalExpression("John");
            return new OrExpression(robert, john);		
        }

        //Rule: Julie is a married women
        public static Expression GetMarriedWomanExpression(){
            Expression julie = new TerminalExpression("Julie");
            Expression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);		
        }


        [Test]
        public void TestMethod()
        {
            Expression isMale = GetMaleExpression();
            Expression isMarriedWoman = GetMarriedWomanExpression();

            Assert.IsTrue(isMale.Interpret("John"));
            Assert.IsTrue(isMarriedWoman.Interpret("Married Julie"));
        }
    }
}
