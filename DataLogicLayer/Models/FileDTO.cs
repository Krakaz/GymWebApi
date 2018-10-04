namespace DataLogicLayer.Models
{
    /// <summary>
    /// Файл
    /// </summary>
    public class FileDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя файла
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Имя файла
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string ContentType { get; set; }
    }
}
