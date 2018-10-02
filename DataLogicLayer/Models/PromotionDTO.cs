using System;

namespace DataLogicLayer.Models
{
    public class PromotionDTO
    {
        /// <summary>
        /// Идентификатор акции
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Ссылка на картинку
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Дата начала действия акции
        /// </summary>
        public DateTime DtFrom { get; set; }

        /// <summary>
        /// Дата окончания действия акции
        /// </summary>
        public DateTime? DtTo { get; set; }
    }
}
