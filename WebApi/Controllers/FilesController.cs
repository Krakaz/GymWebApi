using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    /// <summary>
    /// Контроллер для работы с файлами
    /// </summary>
    [Route("[controller]")]
    public class FilesController : Controller
    {
        private readonly IFileService fileService;

        public FilesController(IFileService fileService)
        {
            this.fileService = fileService;
        }
        [HttpPost("upload")]
        public async Task<IActionResult> UploadAsync(IFormFile file)
        {            
            ViewBag.ImageId = await this.fileService.UploadFile(file);
            return Ok("Загрузка прошла успешно.");
        }

        [HttpPost("UploadFiles")]
        public async Task<IActionResult> UploadFilesAsync(List<IFormFile> files)
        {
            foreach (var file in files)
            {
                ViewBag.ImageId = await this.fileService.UploadFile(file);
            }
            return Ok("Загрузка прошла успешно.");
        }
    }
}