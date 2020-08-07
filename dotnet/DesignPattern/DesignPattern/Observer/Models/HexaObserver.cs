using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer.Models
{
    public class HexaObserver : Interfaces.Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override string Update()
        {
            return $"hexa String: {Convert.ToString(subject.GetState(), 16)}";
        }
    }
}
