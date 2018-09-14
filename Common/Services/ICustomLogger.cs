using System.Threading.Tasks;

namespace Common.Services
{
    public interface ICustomLogger
    {
        void AddWarning(string Text);

        void AddLogger(ILogger logger);
    }
}
