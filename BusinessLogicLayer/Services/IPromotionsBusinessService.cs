﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogicLayer.Models;
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
        Task<IList<PromotionListItem>> GetActivePromotionsAsync();


        /// <summary>
        /// Добавляет новую акцию
        /// </summary>
        /// <param name="promotion">Акция</param>
        Task CreatePromotionAsync(PromotionBase promotion);

        /// <summary>
        /// Получает детализацию акции
        /// </summary>
        /// <param name="id">Идентификатор акции</param>
        Task<PromotionBaseDetails> GetPromotionAsync(int id);

        /// <summary>
        /// Удаление акции
        /// </summary>
        /// <param name="id">Идентификатор акции</param>
        Task DeletePromotionAsync(int id);
    }
}