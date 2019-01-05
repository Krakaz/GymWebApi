﻿using System;
using Microsoft.AspNetCore.Http;

namespace BusinessLogicLayer.Models
{
    public class PromotionBase
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
        /// Дата начала действия акции
        /// </summary>
        public DateTime DtFrom { get; set; }

        /// <summary>
        /// Дата окончания действия акции
        /// </summary>
        public DateTime? DtTo { get; set; }

        /// <summary>
        /// Признак удаления
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Картинка
        /// </summary>
        public IFormFile Image { get; set; }
    }
}