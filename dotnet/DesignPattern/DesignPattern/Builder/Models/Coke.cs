using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Builder.Items;

namespace DesignPattern.Builder.Models
{
    public class Coke : Burger
    {
        public override string name()
        {
            return "Coke";
        }

        public override float price()
        {
            return (float) 30;
        }
    }
}
