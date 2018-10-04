using System.Threading.Tasks;
using DataLogicLayer.Models;

namespace DataLogicLayer.Services.Implementation
{
    internal class FileDataService : IFileDataService
    {
        private ApplicationContext db;
        public FileDataService(ApplicationContext context)
        {
            db = context;
        }

        public async Task<int> SaveFileAsync(FileDto file)
        {
            this.db.Files.Add(file);
            await this.db.SaveChangesAsync();
            return file.Id;
        }
    }
}
