using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder.Interfaces
{
    public interface  Item
    {
        public String name();
        public Packing packing();
        public float price();	
    }
}
