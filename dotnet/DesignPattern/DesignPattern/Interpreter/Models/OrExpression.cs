using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Interpreter.Interfaces;

namespace DesignPattern.Interpreter.Models
{
    public class OrExpression : Expression
    {
        private readonly Expression _expression1;
        private readonly Expression _expression2;

        public OrExpression(Expression expression1, Expression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }
        public bool Interpret(string context)
        {
            return _expression1.Interpret(context) || _expression2.Interpret(context);
        }
    }
}
