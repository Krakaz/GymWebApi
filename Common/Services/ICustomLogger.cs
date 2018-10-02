using System;
using System.Threading.Tasks;

namespace Common.Services
{
    public interface ICustomLogger
    {
        Task AddWarningAsync(string Text);

        Task AddErrorAsync(string Text, Exception ex);
    }
}
