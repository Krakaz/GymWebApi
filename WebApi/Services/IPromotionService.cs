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
        Task<IEnumerable<Promotion>> GetActivePromotionsAsync();


        /// <summary>
        /// Добавляет новую акцию
        /// </summary>
        /// <param name="promotion">Акция</param>
        Task<int> CreatePromotionAsync(PromotionInsert promotion);

        /// <summary>
        /// Получает детализацию акции
        /// </summary>
        /// <param name="id">Идентификатор акции</param>
        Task<PromotionDetails> GetPromotionAsync(int id);
    }
}
