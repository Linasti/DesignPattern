using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Builder.Items;

namespace DesignPattern.Builder.Models
{
    public class VegBurger : ColdDrink
    {
        public override string name()
        {
            return "Beg burger";
        }

        public override float price()
        {
            return (float)25.0;
        }
    }
}
