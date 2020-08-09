using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Visitor.Interfaces;

namespace DesignPattern.Visitor.Models
{
    public class Computer : ComputerPart
    {
        ComputerPart[] parts;
        private const string SPACE = " ";
        public Computer()
        {
            parts = new ComputerPart[] {new Mouse(), new Keyboard(), new Monitor() };
        }
        public string Accept(ComputerPartVisitor computerPartVisitor)
        {
            string result = string.Empty;
            
            foreach (ComputerPart part in parts)
            {
                result += part.Accept(computerPartVisitor) + SPACE;
            }
            result += computerPartVisitor.Visit(this);

            return result;

        }
    }
}
