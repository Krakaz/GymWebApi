using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebApi.Models
{
    /// <summary>
    /// Акция
    /// </summary>
    [DataContract]
    public class Promotion
    {
        /// <summary>
        /// Идентификатор акции
        /// </summary>
        [DataMember(Name = "id")]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        [DataMember(Name = "header")]
        [Required]
        public string Header { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [DataMember(Name = "description")]
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Ссылка на картинку
        /// </summary>
        [DataMember(Name = "imageUrl")]
        [Required]
        public string ImageUrl { get; set; }
    }
}
