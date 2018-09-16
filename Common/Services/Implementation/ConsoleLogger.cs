using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Common.Services.Implementation
{
    internal class ConsoleLogger : ILogger
    {
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();

        public ConsoleLogger()
        {
            AllocConsole();
        }

        public Task LogEventAsync(LogLevel logLevel, string Text, Exception exception = null)
        {
            var color = Console.ForegroundColor;
            Console.WriteLine($"{DateTime.Now} [{logLevel.ToString()}] - {Text} - StackTrase:{exception?.StackTrace}");
            Console.ForegroundColor = color;
            return Task.CompletedTask;
        }
    }
}
