using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.Interfaces
{
    public interface  ComputerPart
    {
       string Accept(ComputerPartVisitor computerPartVisitor);
    }
}
