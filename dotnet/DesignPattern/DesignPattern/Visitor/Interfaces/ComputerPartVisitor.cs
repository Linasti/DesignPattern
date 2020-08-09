using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Visitor.Models;

namespace DesignPattern.Visitor.Interfaces
{
    public interface ComputerPartVisitor
    {
        string Visit(Computer computer);
        string Visit(Mouse mouse);
        string Visit(Keyboard keyboard);
        string Visit(Monitor monitor);
    }
}
