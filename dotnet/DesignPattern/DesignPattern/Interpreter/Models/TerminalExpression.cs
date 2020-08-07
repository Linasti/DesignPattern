using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Interpreter.Interfaces;

namespace DesignPattern.Interpreter.Models
{
    public class TerminalExpression : Expression
    {
        private string _data;

        public TerminalExpression(string data)
        {
            _data = data;
        }
        public bool Interpret(string context)
        {
            if(context.Contains(_data)){
                return true;
            }
            return false;
        }
    }
}
