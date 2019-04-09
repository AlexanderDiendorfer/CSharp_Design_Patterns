using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility {
    class FileLogger : ILogger {
        public string FileName { get; private set; }
        public LogLevels Levels { get; private set; }
        public ILogger NextLogger { get; private set; }

        public FileLogger (LogLevels levels,string file) {
            this.FileName = file ?? throw new ArgumentNullException(nameof(file));
            this.Levels = levels;
        }
        public void Log(string message, LogLevels level) {
            if (this.Levels.HasFlag(level))
            System.IO.File.AppendAllLines(this.FileName, new string[] { message });
            this.NextLogger?.Log(message, level);
        }
    }
}
