using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    /// <summary>
    /// Интерфейс работы с акциями
    /// </summary>
    public interface IPromotions
    {
        /// <summary>
        /// Получает список активных акций
        /// </summary>
        Task<IEnumerable<Promotion>> GetActivePromotions();
    }
}
