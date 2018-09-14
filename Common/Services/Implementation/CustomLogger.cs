using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Common.Services.Implementation
{
    internal class CustomLogger : ICustomLogger
    {
        private delegate Task LogEvent(LogLevel logLevel, string Text, Exception exception = null);
        private readonly ConsoleLogger _consoleLogger = new ConsoleLogger();
        private readonly FileLogger _fileLogger = new FileLogger();

        private event LogEvent OnEvent;


        public CustomLogger()
        {
            this.OnEvent += _consoleLogger.LogEventAsync;
            this.OnEvent += _fileLogger.LogEventAsync;
        }

        public void AddLogger(ILogger logger)
        {
            this.OnEvent += logger.LogEventAsync;
        }

        
        public void AddWarning(string Text)
        {
            this.OnEvent(LogLevel.Warning, Text);
        }

        public void AddError(string Text, Exception ex)
        {
            this.OnEvent(LogLevel.Error, Text, ex);
        }
    }
}
