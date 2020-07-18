using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Builder.Items;

namespace DesignPattern.Builder.Models
{
    public class ChickenBurger : Burger
    {
        public override string name()
        {
            return "chicken burger";
        }

        public override float price()
        {
            return (float) 50.5;
        }
    }
}
