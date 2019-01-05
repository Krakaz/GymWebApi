﻿using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BusinessLogicLayer.Services
{
    /// <summary>
    /// Интерфейс для работы с файлами
    /// </summary>
    public interface IFileBusinessService
    {
        /// <summary>
        /// Сохраняет файл на диск
        /// </summary>
        Task<string> SaveFileAsync(IFormFile file);

        /// <summary>
        /// Сохраняет файл на диск и в БД
        /// </summary>
        Task<int> UploadFileAsync(IFormFile file);

        /// <summary>
        /// Получает файл
        /// </summary>
        Task<MemoryStream> GetFileAsync(string fileName);
    }
}