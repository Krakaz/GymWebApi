using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Http;

namespace WebApi.Models
{
    /// <summary>
    /// Акция
    /// </summary>
    [DataContract]
    public class PromotionInsert
    {
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
    }
}
