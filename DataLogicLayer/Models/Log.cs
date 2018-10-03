using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Logging;

namespace DataLogicLayer.Models
{
    /// <summary>
    /// Запись в лог
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Идентификатор записи в лог
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Уровень сообщения
        /// </summary>
        public LogLevel logLevel { get; set; }

        /// <summary>
        /// Дата события
        /// </summary>
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Текст события
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Стэк трейс ошибки
        /// </summary>
        public string StackTrace { get; set; }

    }
}
