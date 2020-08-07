using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.ChainOfResponsability.Interfaces;
using DesignPattern.ChainOfResponsability.Models;

namespace DesignPattern.Test.ChainOfResponsability
{
    [TestFixture]
    public class ChainOfResponsabilityTest
    {
        public AbstractLogger GetChainOfResponsability()
        {
            AbstractLogger errorLogger = new ErrorLogger(LevelLogger.ERROR);
            AbstractLogger fileLogger = new ErrorLogger(LevelLogger.DEBUG);
            AbstractLogger consoleLogger = new ErrorLogger(LevelLogger.INFO);
          
            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }

        [Test]
        public void TestMethod()
        {
            AbstractLogger loggerChain = GetChainOfResponsability();

            string informationLog = loggerChain.LogMessage(LevelLogger.INFO, "This is an information.");
            Assert.AreEqual("Error Logger: This is an information.",
                informationLog);

            string debugLog = loggerChain.LogMessage(LevelLogger.DEBUG, "This is an debug level information.");
            Assert.AreEqual("Error Logger: This is an debug level information.Error Logger: This is an debug level information.",
                debugLog);
            
            string errorLog = loggerChain.LogMessage(LevelLogger.ERROR, "This is an error information.");
            Assert.AreEqual("Error Logger: This is an error information.Error Logger: This is an error information.Error Logger: This is an error information.",
                errorLog);

        }
    }
}
