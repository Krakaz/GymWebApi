using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{

    /// <summary>
    /// Контроллер для работы с акциями
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionsController : ControllerBase
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
        public IEnumerable<Promotion> GetAsync()
        {
            return this.promotions.GetActivePromotions();
        }

        // POST api/promotions
        /// <summary>
        /// Сохраняет новую акцию
        /// </summary>
        [HttpPost]
        public Task PostAsync([FromForm] PromotionInsert promotion)
        {
            return this.promotions.CreatePromotionAsync(promotion, promotion.Image);
        }
    }
}