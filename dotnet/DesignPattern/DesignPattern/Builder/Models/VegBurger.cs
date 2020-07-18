using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Builder.Items;

namespace DesignPattern.Builder.Models
{
    public class VegBurger : Burger
    {
        public override string name()
        {
            return "Veg burger";
        }

        public override float price()
        {
            return (float)25.0;
        }
    }
}
