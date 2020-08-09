using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.NullObject.Interfaces
{
    public abstract class AbstractCustomer
    {
        protected string name;
        public abstract bool IsNil();
        public abstract string GetName();
    }
}
