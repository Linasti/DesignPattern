using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Command.Interfaces;

namespace DesignPattern.Command.Models
{
    public class BuyCommand : Order
    {
        private Stock _stock;

        public BuyCommand(Stock stock)
        {
            _stock = stock;
        }
        public string Execute()
        {
            return _stock.Buy();
        }
    }
}
