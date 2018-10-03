using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WebApi.Models;

namespace WebApi.Services
{
    /// <summary>
    /// Интерфейс работы с акциями
    /// </summary>
    public interface IPromotionService
    {
        /// <summary>
        /// Получает список активных акций
        /// </summary>
        IEnumerable<Promotion> GetActivePromotions();


        /// <summary>
        /// Добавляет новую акцию
        /// </summary>
        /// <param name="promotion">Акция</param>
        Task CreatePromotionAsync(PromotionInsert promotion, IFormFile file);
    }
}
