using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Common.Services.Implementation
{
    internal class ConsoleLogger : ILogger
    {
        public Task LogEventAsync(LogLevel logLevel, string Text, Exception exception = null)
        {
            var color = Console.ForegroundColor;
            Console.WriteLine($"{DateTime.Now} [{logLevel.ToString()}] - {Text} - StackTrase:{exception?.StackTrace}");
            Console.ForegroundColor = color;
            return Task.CompletedTask;
        }
    }
}
