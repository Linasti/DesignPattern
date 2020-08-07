using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsability.Interfaces
{
    public abstract class AbstractLogger
    {
        protected LevelLogger _level;

        protected AbstractLogger _nextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            _nextLogger = nextLogger;
        }

        public string LogMessage(LevelLogger level, string message)
        {
            string result = string.Empty;
            if (_level <= level)
                result = write(message);

            if(_nextLogger != null)
                result += _nextLogger.LogMessage(level,message);
            return result;
        }

        protected abstract string write(string message);
    }

    public enum LevelLogger
    {
        INFO = 1,
        DEBUG = 2,
        ERROR = 3
    }
}
