using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{

    /// <summary>
    /// Контроллер для работы с акциями
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionsController : ControllerBase
    {
        // GET api/promotions
        /// <summary>
        /// Получает списо акций
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}