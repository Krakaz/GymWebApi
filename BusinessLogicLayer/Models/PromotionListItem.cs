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
    }
}
