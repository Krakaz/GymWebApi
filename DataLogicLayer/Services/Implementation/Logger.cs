using System;
using System.Threading.Tasks;
using Common.Services;
using DataLogicLayer.Models;
using Microsoft.Extensions.Logging;

namespace DataLogicLayer.Services.Implementation
{
    internal class Logger : Common.Services.ILogger
    {
        private LoggerContext db;
        public Logger(LoggerContext context, ICustomLogger customLogger)
        {
            db = context;
            customLogger.AddLogger(this);
        }
        public async Task LogEventAsync(LogLevel logLevel, string Text, Exception exception = null)
        {
            var log = new Log()
            {
                logLevel = logLevel,
                Text = Text,
                EventDate = DateTime.Now,
                StackTrace = exception?.StackTrace
            };
            db.Logs.Add(log);
            await db.SaveChangesAsync();
        }
    }
}
