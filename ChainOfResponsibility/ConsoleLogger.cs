using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility {
    class ConsoleLogger : ILogger {
        public LogLevels Levels { get; private set; }
        public ILogger NextLogger { get; set; }

        public ConsoleLogger(LogLevels levels) {

        }

        public void Log(string message, LogLevels level) {
            if (this.Levels.HasFlag(level)) {
                Console.WriteLine(message);
                this.NextLogger?.Log(message, level);
            }
        }
    }
}
