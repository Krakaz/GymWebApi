using System.Collections.Generic;
using DataLogicLayer.Models;

namespace DataLogicLayer.Services
{
    public interface IPromotionService
    {
        /// <summary>
        /// Получает список активных акций
        /// </summary>
        IList<PromotionDTO> GetActivePromotions();
    }
}
