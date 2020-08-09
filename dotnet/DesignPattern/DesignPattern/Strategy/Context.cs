using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Strategy.Interfaces;

namespace DesignPattern.Strategy
{
    public class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int num1, int num2)
        {
            return _strategy.DoOperation(num1, num2);
        }
    }
}
