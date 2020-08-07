using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Command.Interfaces;

namespace DesignPattern.Command
{
    public class CommandBroker
    {
        private readonly List<Order> _orders = new List<Order>();

        public void TakeOrder(Order order)
        {
            _orders.Add(order);
        }

        public string PlaceOrders()
        {
            string result = string.Empty;

            foreach (Order order in _orders)
            {
                result += order.Execute();
            }

            return result;
        }


    }
}
