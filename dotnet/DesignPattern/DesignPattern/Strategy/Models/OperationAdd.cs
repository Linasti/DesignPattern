using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Strategy.Interfaces;

namespace DesignPattern.Strategy.Models
{
    public class OperationAdd : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
