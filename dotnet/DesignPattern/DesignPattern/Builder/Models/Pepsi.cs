using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Builder.Items;

namespace DesignPattern.Builder.Models
{
    public class Pepsi : ColdDrink
    {
        public override string name()
        {
            return "Persi";
        }

        public override float price()
        {
            return (float) 35;
        }
    }
}
