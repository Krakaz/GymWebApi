﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IPromotions promotions;

        public PromotionsController(IPromotions promotions)
        {
            this.promotions = promotions;
        }
        // GET api/promotions
        /// <summary>
        /// Получает списо акций
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<Promotion>> GetAsync()
        {
            return await this.promotions.GetActivePromotions();
        }
    }
}