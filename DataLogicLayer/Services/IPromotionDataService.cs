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
        Task<IList<PromotionDto>> GetActivePromotionsAsync();


        /// <summary>
        /// Добавляет новую акцию
        /// </summary>
        /// <param name="promotion">Акция</param>
        Task CreatePromotionAsync(PromotionDto promotion);

        /// <summary>
        /// Получает детализацию акции
        /// </summary>
        /// <param name="id">Идентификатор акции</param>
        Task<PromotionDto> GetPromotionAsync(int id);

        /// <summary>
        /// Удаление акции из БД
        /// </summary>
        /// <param name="id">Идентификатор акции</param>
        /// <param name="id">Идентификатор акции</param>
        Task DeleteAsync(int id);
    }
}
