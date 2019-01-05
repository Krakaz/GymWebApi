using System;
using System.IO;
using System.Threading.Tasks;
using DataLogicLayer.Models;
using DataLogicLayer.Services;
using Microsoft.AspNetCore.Http;

namespace BusinessLogicLayer.Services.Implementation
{
    internal class FileBusinessService : IFileBusinessService
    {
        public FileBusinessService(IFileDataService fileDataService)
        {
            this.fileDataService = fileDataService;
        }

        private readonly string filePath = @"wwwroot\files\";
        private readonly IFileDataService fileDataService;

        public async Task<MemoryStream> GetFileAsync(string fileName)
        {
            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           filePath, fileName);

            var memory = new MemoryStream();
            if (File.Exists(path))
            {
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    await stream.CopyToAsync(memory);
                }
            }
            memory.Position = 0;
            return memory;
        }

        public async Task<string> SaveFileAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentNullException("Изображение не выбрано");
            }

            var fileName = Guid.NewGuid().ToString();
            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), filePath,
                        fileName);

            Directory.CreateDirectory(Path.GetDirectoryName(path));
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;
        }

        public async Task<int> UploadFileAsync(IFormFile file)
        {
            var fileName = await this.SaveFileAsync(file);
            var fileDto = new FileDto()
            {
                Name = fileName,
                ContentType = file.ContentType,
                Label = file.FileName
            };

            fileDto.Id = await this.fileDataService.SaveFileAsync(fileDto);
            return fileDto.Id;
        }
    }
}
