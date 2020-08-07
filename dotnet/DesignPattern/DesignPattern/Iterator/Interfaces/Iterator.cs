using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator.Interfaces
{
    public interface Iterator
    {
        public bool HasNext();
        public object Next();
    }
}
