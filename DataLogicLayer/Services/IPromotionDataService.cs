using System.Collections.Generic;
using System.Threading.Tasks;
using DataLogicLayer.Models;

namespace DataLogicLayer.Services
{
    public interface IPromotionDataService
    {
        /// <summary>
        /// Получает список активных акций
        /// </summary>
        IList<PromotionDto> GetActivePromotions();


        /// <summary>
        /// Добавляет новую акцию
        /// </summary>
        /// <param name="promotion">Акция</param>
        Task CreatePromotionAsync(PromotionDto promotion);
    }
}
