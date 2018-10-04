using System.Threading.Tasks;
using DataLogicLayer.Models;

namespace DataLogicLayer.Services
{
    /// <summary>
    /// Интерфейс для работы с файлами
    /// </summary>
    public interface IFileDataService
    {
        /// <summary>
        /// Сохраняет в БД информацию о файле
        /// </summary>
        Task<int> SaveFileAsync(FileDto file);
    }
}
