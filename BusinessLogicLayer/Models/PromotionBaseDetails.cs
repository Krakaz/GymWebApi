using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BusinessLogicLayer.Models
{
    /// <summary>
    /// Акция
    /// </summary>
    [DataContract]
    public class PromotionBaseDetails
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
        /// Дата начала действия акции
        /// </summary>
        [DataMember(Name = "dtFrom")]
        [Required]
        public DateTime DtFrom { get; set; }

        /// <summary>
        /// Дата окончания действия акции
        /// </summary>
        [DataMember(Name = "dtTo")]
        public DateTime? DtTo { get; set; }

        /// <summary>
        /// Картинка
        /// </summary>
        [DataMember(Name = "image")]
        public byte[] Image { get; set; }
    }
}
