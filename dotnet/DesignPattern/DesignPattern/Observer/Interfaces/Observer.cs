using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer.Interfaces
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract string Update();
    }
}
