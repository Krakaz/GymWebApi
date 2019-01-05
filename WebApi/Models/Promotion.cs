using System;
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
        [Display(Name = "Заголовок")]
        [Required]
        public string Header { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [DataMember(Name = "description")]
        [Display(Name = "Описание")]
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Ссылка на картинку
        /// </summary>
        [DataMember(Name = "imageName")]
        [Required]
        public string ImageName { get; set; }

        /// <summary>
        /// Дата начала действия акции
        /// </summary>
        [Display(Name = "Дата начала действия акции")]
        public DateTime DtFrom { get; set; }

        /// <summary>
        /// Дата окончания действия акции
        /// </summary>
        [Display(Name = "Дата окончания действия акции")]
        public DateTime? DtTo { get; set; }
    }
}
