using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Http;

namespace WebApi.Services.Implementation
{
    internal class FileService : IFileService
    {
        private readonly IFileBusinessService fileBusinessService;

        public FileService(IFileBusinessService fileBusinessService)
        {
            this.fileBusinessService = fileBusinessService;
        }

        public Task<int> UploadFile(IFormFile file)
        {
            return this.fileBusinessService.UploadFileAsync(file);
        }
    }
}
