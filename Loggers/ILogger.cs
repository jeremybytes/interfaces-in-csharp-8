using System;
using System.Collections.Generic;
using System.Text;

namespace Loggers
{
    public enum LogLevel
    {
        None,
        Info,
        Warning,
        Error,
    }

    public interface ILogger
    {
        void Log(LogLevel level, string message);

        void Log(Exception ex) => Log(LogLevel.Error, ex.ToString());
    }
}
