using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Visitor.Interfaces;

namespace DesignPattern.Visitor.Models
{
    public class Keyboard : ComputerPart
    {
        public string Accept(ComputerPartVisitor computerPartVisitor)
        {
            return computerPartVisitor.Visit(this);
        }
    }
}
