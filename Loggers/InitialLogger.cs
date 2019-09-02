using System;
using System.Collections.Generic;
using System.Text;

namespace Loggers
{
    public class InitialLogger : ILogger
    {
        public void Log(LogLevel level, string message)
        {
            Console.WriteLine($"Level - {level:F}: {message}");
        }
    }
}
