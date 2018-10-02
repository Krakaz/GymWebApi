using System.Collections.Generic;
using DataLogicLayer.Models;

namespace BusinessLogicLayer.Services
{
    /// <summary>
    /// Интерфейс БЛ работы с акциями
    /// </summary>
    public interface IPromotionsBusinessService
    {
        /// <summary>
        /// Получает список активных акций
        /// </summary>
        IList<PromotionDTO> GetActivePromotions();
    }
}
