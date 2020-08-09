using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.NullObject.Interfaces;
using DesignPattern.NullObject.Models;

namespace DesignPattern.NullObject
{
    public class CustomerFactory
    {
        public static string[] Names = {"Rob", "Joe", "Julie"};
        public static AbstractCustomer GetCustomer(string name)
        {
            foreach (string customerName in Names)
            {
                if (string.Equals(customerName, name, StringComparison.CurrentCultureIgnoreCase)){
                    return new RealCustomer(customerName);
                }
            }
            return new NullCustomer();
        }

    }
}
