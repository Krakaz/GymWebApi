using System;

namespace BusinessLogicLayer.Models
{
    /// <summary>
    /// Акция
    /// </summary>
    public class PromotionListItem
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
        public string ImageName { get; set; }

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
