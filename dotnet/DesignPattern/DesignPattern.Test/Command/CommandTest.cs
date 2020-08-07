using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Command;
using DesignPattern.Command.Models;

namespace DesignPattern.Test.Command
{
    [TestFixture]
    public class CommandTest
    {
        [Test]
        public void TestMethod()
        {
           Stock abcStock = new Stock();

            BuyCommand buyCommand = new BuyCommand(abcStock);
            SellCommand sellCommand = new SellCommand(abcStock);


            CommandBroker broker = new CommandBroker();
            broker.TakeOrder(buyCommand);
            broker.TakeOrder(sellCommand);

            string orderResult = broker.PlaceOrders();

            Assert.AreEqual("Stock [ Name: ABC, Quantity: 11 ] bought Stock [ Name: ABC, Quantity: 10 ] sold ",
                orderResult);

        }
    }
}
