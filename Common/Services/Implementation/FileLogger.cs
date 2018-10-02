using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Common.Services.Implementation
{
    internal class FileLogger : ILogger
    {
        public async Task LogEventAsync(LogLevel logLevel, string Text, Exception exception = null)
        {
            string pathToLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            if (!Directory.Exists(pathToLog))
                Directory.CreateDirectory(pathToLog);
            string filename = Path.Combine(pathToLog, string.Format("{0}_{1:dd.MM.yyy}.log",
            AppDomain.CurrentDomain.FriendlyName, DateTime.Now));
            string fullText = $"{DateTime.Now} [{logLevel.ToString()}] - {Text} - StackTrase:{exception?.StackTrace}";
            await File.AppendAllLinesAsync(filename, new List<string>() { fullText });
        }

    }
}
