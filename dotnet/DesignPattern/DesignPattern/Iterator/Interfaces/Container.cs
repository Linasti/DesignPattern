using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator.Interfaces
{
    public interface Container
    {
        Iterator GetIterator();
    }
}
