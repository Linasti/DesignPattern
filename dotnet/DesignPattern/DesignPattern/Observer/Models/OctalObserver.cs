using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer.Models
{
    public class OctalObserver : Interfaces.Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override string Update()
        {
            return $"octal String: {Convert.ToString(subject.GetState(), 8)}";
        }
    }
}
