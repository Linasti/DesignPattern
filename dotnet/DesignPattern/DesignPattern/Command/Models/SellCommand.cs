using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Command.Interfaces;

namespace DesignPattern.Command.Models
{
    public class SellCommand :Order
    {
        private Stock _stock;

        public SellCommand(Stock stock)
        {
            _stock = stock;
        }
        public string Execute()
        {
            return _stock.Sell();
        }
    }
}
