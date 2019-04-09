using System;

namespace ChainOfResponsibility {
    class Program {
        const string FILE_NAME = @"C:\log.txt";
        static void Main(string[] args) {
            FileLogger fileLogger = new FileLogger(LogLevels.Information | LogLevels.Warning | LogLevels.Error, FILE_NAME);
            ConsoleLogger consoleLogger = new ConsoleLogger(LogLevels.All);
            consoleLogger.NextLogger = fileLogger;

            consoleLogger.Log("Program started", LogLevels.Debug);
            consoleLogger.Log("Warning Information", LogLevels.Warning);
        }
    }
}
