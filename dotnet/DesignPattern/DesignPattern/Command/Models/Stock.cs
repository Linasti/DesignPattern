using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command.Models
{
    public class Stock
    {
        private string _name = "ABC";
        private int _quantity = 10;

        public string Buy()
        {
            _quantity++;
            return $"Stock [ Name: {_name}, Quantity: {_quantity} ] bought ";
        }

        public string Sell()
        {
            _quantity--;
            return $"Stock [ Name: {_name}, Quantity: {_quantity} ] sold ";
        }
    }
}
