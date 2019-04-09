using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility {

    [Flags]
    public enum LogLevels {
        Debug = 1,
        Information = 2,
        Warning = 4,
        Error = 8,
        Critical = 16,
        All = Debug | Information |Warning | Error | Critical
    }
    interface ILogger {
        void Log(string message, LogLevels level);

    }
}
