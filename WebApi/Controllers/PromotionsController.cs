using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{

    /// <summary>
    /// Контроллер для работы с акциями
    /// </summary>
    [Route("[controller]")]
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
        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> IndexAsync()
        {
            return View("index",await this.promotions.GetActivePromotionsAsync());
        }

        // GET api/promotions/5
        /// <summary>
        /// Получает списо акций
        /// </summary>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> DetailsAsync(int id)
        {
            return View(await this.promotions.GetPromotionAsync(id));
        }

        /// <summary>
        /// Получает списо акций
        /// </summary>
        [HttpGet("Edit/{id:int}")]
        public async Task<IActionResult> EditAsync(int id)
        {
            return View(await this.promotions.GetPromotionAsync(id));
        }

        /// <summary>
        /// Редактирует акцию
        /// </summary>
        [HttpPost("Edit")]
        public async Task<IActionResult> EditAsync([FromBody] PromotionUpsert promotion)
        {
            if (ModelState.IsValid)
            {
                var promotionId = await this.promotions.CreatePromotionAsync(promotion);
                return RedirectToAction($"DetailsAsync", new { id = promotionId });
            }                
            else
                return View(promotion);
        }


        /// <summary>
        /// Получает списо акций
        /// </summary>
        [HttpGet("Create")]
        public async Task<IActionResult> CreateAsync()
        {
            return View(new PromotionUpsert());
        }

        /// <summary>
        /// Создает акцию и открывает детализацию
        /// </summary>
        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(PromotionUpsert promotion)
        {
            if (ModelState.IsValid)
            {
                var promotionId = await this.promotions.CreatePromotionAsync(promotion);
                return RedirectToAction($"DetailsAsync", new { id = promotionId });
            }                
            else
                return View(promotion);
        }

        /// <summary>
        /// Редактирует акцию
        /// </summary>
        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteAsync(int Id)
        {
            await this.promotions.DeletePromotionAsync(Id);
            return RedirectToAction($"IndexAsync", null);
        }

    }
}