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


        public CustomLogger(ILogger logger)
        {
            this.OnEvent += _consoleLogger.LogEventAsync;
            this.OnEvent += _fileLogger.LogEventAsync;
            this.OnEvent += logger.LogEventAsync;
        }

        public void AddLogger(ILogger logger)
        {
            this.OnEvent += logger.LogEventAsync;
        }

        
        public async Task AddWarningAsync(string Text)
        {
           await this.OnEvent(LogLevel.Warning, Text);
        }

        public async Task AddErrorAsync(string Text, Exception ex)
        {
            await this.OnEvent(LogLevel.Error, Text, ex);
        }
    }
}
