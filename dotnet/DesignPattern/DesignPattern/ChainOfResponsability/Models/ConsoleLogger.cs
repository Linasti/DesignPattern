using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.ChainOfResponsability.Interfaces;

namespace DesignPattern.ChainOfResponsability.Models
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(LevelLogger level)
        {
            _level = level;
        }
        protected override string write(string message)
        {
            return $"Console Logger: {message}";
        }
    }
}
