using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Visitor.Interfaces;
using DesignPattern.Visitor.Models;

namespace DesignPattern.Visitor
{
    public class ComputerPartDisplayVisitor : ComputerPartVisitor 
    {
        public string Visit(Computer computer)
        {
            return "Displaying Computer.";
        }

        public string Visit(Mouse mouse)
        {
            return "Displaying Mouse.";
        }

        public string Visit(Keyboard keyboard)
        {
            return "Displaying Keyboard.";
        }

        public string Visit(Monitor monitor)
        {
            return "Displaying Monitor.";
        }
    }
}
