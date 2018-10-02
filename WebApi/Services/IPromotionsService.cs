using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Services
{
    /// <summary>
    /// Интерфейс работы с акциями
    /// </summary>
    public interface IPromotionsService
    {
        /// <summary>
        /// Получает список активных акций
        /// </summary>
        IEnumerable<Promotion> GetActivePromotions();
    }
}
