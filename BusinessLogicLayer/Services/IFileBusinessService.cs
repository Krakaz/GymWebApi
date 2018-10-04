using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BusinessLogicLayer.Services
{
    /// <summary>
    /// Интерфейс для работы с файлами
    /// </summary>
    public interface IFileBusinessService
    {
        /// <summary>
        /// Сохраняет файл на диск
        /// </summary>
        Task<string> SaveFileAsync(IFormFile file);
    }
}
