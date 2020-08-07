using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter.Interfaces
{
    public interface Expression
    {
        bool Interpret(string context);
    }
}
