using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{

    /// <summary>
    /// Контроллер для работы с акциями
    /// </summary>
    // [Route("api/[controller]")]
    // [ApiController]
    public class PromotionsController : Controller
    {
        private readonly IPromotionService promotions;

        public PromotionsController(IPromotionService promotions)
        {
            this.promotions = promotions;
        }

        // GET api/promotions
        /// <summary>
        /// Получает списо акций
        /// </summary>
        [HttpGet("[controller]")]
        public async Task<IActionResult> IndexAsync()
        {
            return View("index",await this.promotions.GetActivePromotionsAsync());
        }

        // GET api/promotions/5
        /// <summary>
        /// Получает списо акций
        /// </summary>
        [HttpGet("[controller]/{id:int}")]
        public async Task<IActionResult> DetailsAsync(int id)
        {
            return View(await this.promotions.GetPromotionAsync(id));
        }

        // POST api/promotions
        /// <summary>
        /// Сохраняет новую акцию
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> EditAsync([FromForm] PromotionInsert promotion)
        {
            var id = await this.promotions.CreatePromotionAsync(promotion);
            return RedirectToAction($"details/{id}");
        }


    }
}