using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Visitor.Interfaces;

namespace DesignPattern.Visitor.Models
{
    public class Mouse : ComputerPart
    {
        public string Accept(ComputerPartVisitor computerPartVisitor)
        {
            return computerPartVisitor.Visit(this);
        }
    }
}
