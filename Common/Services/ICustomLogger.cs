using System;
using System.Threading.Tasks;

namespace Common.Services
{
    public interface ICustomLogger
    {
        Task AddWarningAsync(string Text);

        void AddLogger(ILogger logger);

        Task AddErrorAsync(string Text, Exception ex);
    }
}
