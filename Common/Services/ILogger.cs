using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Common.Services
{
    public interface ILogger
    {
        Task LogEventAsync(LogLevel logLevel, string Text, Exception exception = null);
    }
}
