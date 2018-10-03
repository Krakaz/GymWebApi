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
        IList<PromotionDTO> GetActivePromotions();


        /// <summary>
        /// Добавляет новую акцию
        /// </summary>
        /// <param name="promotion">Акция</param>
        Task CreatePromotionAsync(PromotionDTO promotion);
    }
}
