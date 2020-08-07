using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer.Models
{
    public class BinaryObserver : Interfaces.Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return $"Binary String: {Convert.ToString(subject.GetState(), 2)}";
        }
    }
}
