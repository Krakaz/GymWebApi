using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BusinessLogicLayer.Services.Implementation
{
    internal class FileBusinessService : IFileBusinessService
    {
        private readonly string filePath = @"wwwroot\files\";

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
    }
}
