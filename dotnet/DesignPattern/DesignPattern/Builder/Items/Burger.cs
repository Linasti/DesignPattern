using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Builder.Interfaces;
using DesignPattern.Builder.Packings;

namespace DesignPattern.Builder.Items
{
    public abstract class Burger : Item
    {
        public abstract string name();

        public Packing packing()
        {
            return new Bottle();
        }

        public abstract float price();
    }
}
