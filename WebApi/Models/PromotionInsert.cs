using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Http;

namespace WebApi.Models
{
    /// <summary>
    /// Акция
    /// </summary>
    [DataContract]
    public class PromotionUpsert
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [DataMember(Name = "id")]
        [UIHint("HiddenInput")]
        public int Id { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        [DataMember(Name = "header")]
        [Display(Name = "Заголовок")]
        [Required(ErrorMessage = "Не указан заголовок акции")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 100 символов.")]
        public string Header { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [DataMember(Name = "description")]
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Не указано описание акции")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 500 символов.")]
        public string Description { get; set; }

        /// <summary>
        /// Дата начала действия акции
        /// </summary>
        [DataMember(Name = "dtFrom")]
        [Display(Name = "Дата начала действия акции")]
        [Required(ErrorMessage = "Не выбрана дата старта акции.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtFrom { get; set; }

        /// <summary>
        /// Дата окончания действия акции
        /// </summary>
        [DataMember(Name = "dtTo")]
        [Display(Name = "Дата окончания действия акции")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DtTo { get; set; }

        /// <summary>
        /// Картинка
        /// </summary>
        [DataMember(Name = "image")]
        [Display(Name = "Картинка")]
        [Required(ErrorMessage = "Не выбрано сопуствующее изображение акции.")]
        public IFormFile Image { get; set; }
    }
}
